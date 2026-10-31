using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace HRM_Payroll.DAL
{
    public class BangLuongDAL
    {
        public DataTable GetByMonth(string thangNam)
        {
            using (SqlConnection cn = DBConnection.GetConnection())
            using (SqlCommand cmd = new SqlCommand(@"
                SELECT bl.MaLuong,nv.MaNV,nv.HoTen,bl.ThangNam,bl.ThucLinh
                FROM BangLuong bl JOIN NhanVien nv ON bl.MaNV=nv.MaNV
                WHERE bl.ThangNam=@thang ORDER BY nv.MaNV", cn))
            {
                cmd.Parameters.Add("@thang", SqlDbType.VarChar, 7).Value = thangNam;
                DataTable dt = new DataTable();
                using (SqlDataAdapter da = new SqlDataAdapter(cmd)) da.Fill(dt);
                return dt;
            }
        }

        public void ChotLuong(string thangNam)
        {
            using (SqlConnection cn = DBConnection.GetConnection())
            {
                cn.Open();
                using (SqlTransaction tran = cn.BeginTransaction())
                {
                    try
                    {
                        using (SqlCommand exists = new SqlCommand("SELECT COUNT(*) FROM BangLuong WHERE ThangNam=@t", cn, tran))
                        {
                            exists.Parameters.Add("@t", SqlDbType.VarChar, 7).Value = thangNam;
                            if (Convert.ToInt32(exists.ExecuteScalar()) > 0)
                                throw new InvalidOperationException("Tháng này đã được chốt lương trước đó.");
                        }

                        using (SqlCommand cmd = new SqlCommand(@"
                            INSERT INTO BangLuong(MaNV,ThangNam,ThucLinh)
                            SELECT nv.MaNV,@t,
                                   CAST((nv.LuongCoBan * nv.HeSoLuong / 22.0) * cc.SoNgayCong
                                        + (cc.SoGioOT * 50000) AS DECIMAL(18,2))
                            FROM NhanVien nv
                            INNER JOIN BangChamCong cc ON nv.MaNV=cc.MaNV
                            WHERE cc.ThangNam=@t AND cc.DaChot=0", cn, tran))
                        {
                            cmd.Parameters.Add("@t", SqlDbType.VarChar, 7).Value = thangNam;
                            int count = cmd.ExecuteNonQuery();
                            if (count == 0) throw new InvalidOperationException("Không có dữ liệu chấm công để chốt lương.");
                        }

                        using (SqlCommand lockCmd = new SqlCommand("UPDATE BangChamCong SET DaChot=1 WHERE ThangNam=@t", cn, tran))
                        {
                            lockCmd.Parameters.Add("@t", SqlDbType.VarChar, 7).Value = thangNam;
                            lockCmd.ExecuteNonQuery();
                        }
                        tran.Commit();
                    }
                    catch
                    {
                        tran.Rollback();
                        throw;
                    }
                }
            }
        }
    }
}
