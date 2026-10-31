using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace HRM_Payroll.DAL
{
    public class NhanVienDAL
    {
        public DataTable GetAll(string keyword = "")
        {
            using (SqlConnection cn = DBConnection.GetConnection())
            using (SqlCommand cmd = new SqlCommand(@"
                SELECT nv.MaNV, nv.HoTen, nv.NgaySinh, nv.CCCD, nv.MaPB,
                       pb.TenPB, nv.LuongCoBan, nv.HeSoLuong
                FROM NhanVien nv LEFT JOIN PhongBan pb ON nv.MaPB = pb.MaPB
                WHERE (@kw = '' OR nv.HoTen LIKE @like OR nv.CCCD LIKE @like
                       OR pb.TenPB LIKE @like)
                ORDER BY nv.MaNV", cn))
            {
                cmd.Parameters.Add("@kw", SqlDbType.NVarChar, 100).Value = keyword;
                cmd.Parameters.Add("@like", SqlDbType.NVarChar, 120).Value = "%" + keyword + "%";
                DataTable dt = new DataTable();
                using (SqlDataAdapter da = new SqlDataAdapter(cmd)) da.Fill(dt);
                return dt;
            }
        }

        public DataTable GetPhongBan()
        {
            using (SqlConnection cn = DBConnection.GetConnection())
            using (SqlDataAdapter da = new SqlDataAdapter("SELECT MaPB, TenPB FROM PhongBan ORDER BY TenPB", cn))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public void Insert(string hoTen, DateTime? ngaySinh, string cccd, int maPB, decimal luong, double heSo)
        {
            Execute(@"INSERT INTO NhanVien(HoTen,NgaySinh,CCCD,MaPB,LuongCoBan,HeSoLuong)
                      VALUES(@ten,@ns,@cccd,@pb,@luong,@hs)",
                hoTen, ngaySinh, cccd, maPB, luong, heSo);
        }

        public void Update(int maNV, string hoTen, DateTime? ngaySinh, string cccd, int maPB, decimal luong, double heSo)
        {
            using (SqlConnection cn = DBConnection.GetConnection())
            using (SqlCommand cmd = new SqlCommand(@"UPDATE NhanVien SET HoTen=@ten,NgaySinh=@ns,CCCD=@cccd,
                    MaPB=@pb,LuongCoBan=@luong,HeSoLuong=@hs WHERE MaNV=@ma", cn))
            {
                AddParams(cmd, hoTen, ngaySinh, cccd, maPB, luong, heSo);
                cmd.Parameters.Add("@ma", SqlDbType.Int).Value = maNV;
                cn.Open(); cmd.ExecuteNonQuery();
            }
        }

        private void Execute(string sql, string ten, DateTime? ns, string cccd, int pb, decimal luong, double hs)
        {
            using (SqlConnection cn = DBConnection.GetConnection())
            using (SqlCommand cmd = new SqlCommand(sql, cn))
            {
                AddParams(cmd, ten, ns, cccd, pb, luong, hs);
                cn.Open(); cmd.ExecuteNonQuery();
            }
        }

        private void AddParams(SqlCommand cmd, string ten, DateTime? ns, string cccd, int pb, decimal luong, double hs)
        {
            cmd.Parameters.Add("@ten", SqlDbType.NVarChar, 100).Value = ten;
            cmd.Parameters.Add("@ns", SqlDbType.DateTime).Value = (object)ns ?? DBNull.Value;
            cmd.Parameters.Add("@cccd", SqlDbType.VarChar, 20).Value = string.IsNullOrWhiteSpace(cccd) ? (object)DBNull.Value : cccd;
            cmd.Parameters.Add("@pb", SqlDbType.Int).Value = pb;
            cmd.Parameters.Add("@luong", SqlDbType.Decimal).Value = luong;
            cmd.Parameters["@luong"].Precision = 18; cmd.Parameters["@luong"].Scale = 2;
            cmd.Parameters.Add("@hs", SqlDbType.Float).Value = hs;
        }

        public void Delete(int maNV)
        {
            using (SqlConnection cn = DBConnection.GetConnection())
            using (SqlCommand cmd = new SqlCommand("DELETE FROM NhanVien WHERE MaNV=@ma", cn))
            {
                cmd.Parameters.Add("@ma", SqlDbType.Int).Value = maNV;
                cn.Open(); cmd.ExecuteNonQuery();
            }
        }
    }
}
