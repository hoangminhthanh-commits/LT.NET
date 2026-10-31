using System.Data;
using Microsoft.Data.SqlClient;
using QuanLyBanHangMini.DTO;

namespace QuanLyBanHangMini.DAL
{
    public class NhanVienDAL
    {
        public DataTable GetAll(string keyword = "")
        {
            using (SqlConnection cn = Database.GetConnection())
            using (SqlCommand cmd = new SqlCommand(
                @"SELECT MaNV,TenNV,SoDienThoai,ChucVu FROM NhanVien
                  WHERE TenNV LIKE @kw OR SoDienThoai LIKE @kw ORDER BY TenNV", cn))
            {
                cmd.Parameters.Add("@kw", SqlDbType.NVarChar, 100).Value = "%" + keyword + "%";
                DataTable dt = new DataTable(); cn.Open();
                using (SqlDataAdapter da = new SqlDataAdapter(cmd)) da.Fill(dt);
                return dt;
            }
        }
        public int Insert(NhanVienDTO n)
        {
            using (SqlConnection cn = Database.GetConnection())
            using (SqlCommand cmd = new SqlCommand(
                @"INSERT INTO NhanVien(TenNV,SoDienThoai,ChucVu) VALUES(@ten,@dt,@cv)", cn))
            {
                cmd.Parameters.Add("@ten", SqlDbType.NVarChar, 100).Value = n.TenNV;
                cmd.Parameters.Add("@dt", SqlDbType.VarChar, 15).Value =
                    string.IsNullOrWhiteSpace(n.SoDienThoai) ? (object)DBNull.Value : n.SoDienThoai;
                cmd.Parameters.Add("@cv", SqlDbType.NVarChar, 50).Value =
                    string.IsNullOrWhiteSpace(n.ChucVu) ? (object)DBNull.Value : n.ChucVu;
                cn.Open(); return cmd.ExecuteNonQuery();
            }
        }
        public int Update(NhanVienDTO n)
        {
            using (SqlConnection cn = Database.GetConnection())
            using (SqlCommand cmd = new SqlCommand(
                @"UPDATE NhanVien SET TenNV=@ten,SoDienThoai=@dt,ChucVu=@cv WHERE MaNV=@ma", cn))
            {
                cmd.Parameters.Add("@ma", SqlDbType.Int).Value = n.MaNV;
                cmd.Parameters.Add("@ten", SqlDbType.NVarChar, 100).Value = n.TenNV;
                cmd.Parameters.Add("@dt", SqlDbType.VarChar, 15).Value =
                    string.IsNullOrWhiteSpace(n.SoDienThoai) ? (object)DBNull.Value : n.SoDienThoai;
                cmd.Parameters.Add("@cv", SqlDbType.NVarChar, 50).Value =
                    string.IsNullOrWhiteSpace(n.ChucVu) ? (object)DBNull.Value : n.ChucVu;
                cn.Open(); return cmd.ExecuteNonQuery();
            }
        }
        public int Delete(int ma)
        {
            using (SqlConnection cn = Database.GetConnection())
            using (SqlCommand cmd = new SqlCommand("DELETE FROM NhanVien WHERE MaNV=@ma", cn))
            { cmd.Parameters.Add("@ma", SqlDbType.Int).Value = ma; cn.Open(); return cmd.ExecuteNonQuery(); }
        }
    }
}
