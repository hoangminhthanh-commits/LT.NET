using System.Data;
using Microsoft.Data.SqlClient;
using QuanLyBanHangMini.DTO;

namespace QuanLyBanHangMini.DAL
{
    public class KhachHangDAL
    {
        public DataTable GetAll(string keyword = "")
        {
            using (SqlConnection cn = Database.GetConnection())
            using (SqlCommand cmd = new SqlCommand(
                @"SELECT MaKH,TenKH,DienThoai,DiemTichLuy FROM KhachHang
                  WHERE TenKH LIKE @kw OR DienThoai LIKE @kw ORDER BY TenKH", cn))
            {
                cmd.Parameters.Add("@kw", SqlDbType.NVarChar, 100).Value = "%" + keyword + "%";
                DataTable dt = new DataTable(); cn.Open();
                using (SqlDataAdapter da = new SqlDataAdapter(cmd)) da.Fill(dt);
                return dt;
            }
        }
        public int Insert(KhachHangDTO k)
        {
            using (SqlConnection cn = Database.GetConnection())
            using (SqlCommand cmd = new SqlCommand(
                @"INSERT INTO KhachHang(TenKH,DienThoai) VALUES(@ten,@dt)", cn))
            {
                cmd.Parameters.Add("@ten", SqlDbType.NVarChar, 100).Value = k.TenKH;
                cmd.Parameters.Add("@dt", SqlDbType.VarChar, 15).Value =
                    string.IsNullOrWhiteSpace(k.DienThoai) ? (object)DBNull.Value : k.DienThoai;
                cn.Open(); return cmd.ExecuteNonQuery();
            }
        }
        public int Update(KhachHangDTO k)
        {
            using (SqlConnection cn = Database.GetConnection())
            using (SqlCommand cmd = new SqlCommand(
                @"UPDATE KhachHang SET TenKH=@ten,DienThoai=@dt WHERE MaKH=@ma", cn))
            {
                cmd.Parameters.Add("@ma", SqlDbType.Int).Value = k.MaKH;
                cmd.Parameters.Add("@ten", SqlDbType.NVarChar, 100).Value = k.TenKH;
                cmd.Parameters.Add("@dt", SqlDbType.VarChar, 15).Value =
                    string.IsNullOrWhiteSpace(k.DienThoai) ? (object)DBNull.Value : k.DienThoai;
                cn.Open(); return cmd.ExecuteNonQuery();
            }
        }
        public int Delete(int ma)
        {
            using (SqlConnection cn = Database.GetConnection())
            using (SqlCommand cmd = new SqlCommand("DELETE FROM KhachHang WHERE MaKH=@ma", cn))
            { cmd.Parameters.Add("@ma", SqlDbType.Int).Value = ma; cn.Open(); return cmd.ExecuteNonQuery(); }
        }
    }
}
