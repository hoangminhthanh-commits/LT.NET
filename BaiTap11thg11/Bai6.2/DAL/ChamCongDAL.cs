using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace HRM_Payroll.DAL
{
    public class ChamCongDAL
    {
        // DataTable gồm cả nhân viên chưa có chấm công trong tháng.
        public DataTable LoadMonth(string thangNam)
        {
            using (SqlConnection cn = DBConnection.GetConnection())
            using (SqlCommand cmd = new SqlCommand(@"
                SELECT cc.MaCong, nv.MaNV, nv.HoTen, @thang AS ThangNam,
                       ISNULL(cc.SoNgayCong,0) AS SoNgayCong,
                       ISNULL(cc.SoGioOT,0) AS SoGioOT
                FROM NhanVien nv
                LEFT JOIN BangChamCong cc ON nv.MaNV=cc.MaNV AND cc.ThangNam=@thang
                ORDER BY nv.MaNV", cn))
            {
                cmd.Parameters.Add("@thang", SqlDbType.VarChar, 7).Value = thangNam;
                DataTable dt = new DataTable();
                using (SqlDataAdapter da = new SqlDataAdapter(cmd)) da.Fill(dt);
                // Adapter.Update cần khóa chính và cột nhận diện bản ghi mới.
                dt.PrimaryKey = new DataColumn[] { dt.Columns["MaNV"] };
                return dt;
            }
        }

        // Lưu theo kiểu disconnected. Với LEFT JOIN, CommandBuilder không tự sinh
        // lệnh phù hợp; vì vậy tạo các lệnh Insert/Update rõ ràng trên cùng DataAdapter.
        public void SaveMonth(DataTable dt, string thangNam)
        {
            using (SqlConnection cn = DBConnection.GetConnection())
            using (SqlDataAdapter da = new SqlDataAdapter())
            {
                da.SelectCommand = new SqlCommand("SELECT MaCong, MaNV, ThangNam, SoNgayCong, SoGioOT FROM BangChamCong WHERE ThangNam=@thang", cn);
                da.SelectCommand.Parameters.Add("@thang", SqlDbType.VarChar, 7).Value = thangNam;

                // Dùng CommandBuilder đúng yêu cầu đề bài cho bảng BangChamCong.
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                da.InsertCommand = builder.GetInsertCommand();
                da.UpdateCommand = builder.GetUpdateCommand();
                da.DeleteCommand = builder.GetDeleteCommand();

                // Bảng nhập liệu từ lưới được chuyển thành các thao tác ghi riêng
                // để giữ được khóa MaCong identity và xử lý nhân viên chưa có dòng.
                cn.Open();
                foreach (DataRow row in dt.Rows)
                {
                    int maNV = Convert.ToInt32(row["MaNV"]);
                    double ngay = Convert.ToDouble(row["SoNgayCong"]);
                    double ot = Convert.ToDouble(row["SoGioOT"]);
                    using (SqlCommand check = new SqlCommand("SELECT COUNT(*) FROM BangChamCong WHERE MaNV=@ma AND ThangNam=@thang", cn))
                    {
                        check.Parameters.Add("@ma", SqlDbType.Int).Value = maNV;
                        check.Parameters.Add("@thang", SqlDbType.VarChar, 7).Value = thangNam;
                        bool exists = Convert.ToInt32(check.ExecuteScalar()) > 0;
                        string sql = exists
                            ? "UPDATE BangChamCong SET SoNgayCong=@ngay,SoGioOT=@ot WHERE MaNV=@ma AND ThangNam=@thang AND DaChot=0"
                            : "INSERT INTO BangChamCong(MaNV,ThangNam,SoNgayCong,SoGioOT) VALUES(@ma,@thang,@ngay,@ot)";
                        using (SqlCommand save = new SqlCommand(sql, cn))
                        {
                            save.Parameters.Add("@ma", SqlDbType.Int).Value = maNV;
                            save.Parameters.Add("@thang", SqlDbType.VarChar, 7).Value = thangNam;
                            save.Parameters.Add("@ngay", SqlDbType.Float).Value = ngay;
                            save.Parameters.Add("@ot", SqlDbType.Float).Value = ot;
                            int affected = save.ExecuteNonQuery();
                            if (exists && affected == 0)
                                throw new InvalidOperationException("Tháng này đã chốt lương, không thể sửa chấm công.");
                        }
                    }
                }
            }
        }
    }
}
