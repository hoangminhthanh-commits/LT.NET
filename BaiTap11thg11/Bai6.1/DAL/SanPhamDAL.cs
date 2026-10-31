using System;
using System.Data;
using Microsoft.Data.SqlClient;
using QuanLyBanHangMini.DTO;

namespace QuanLyBanHangMini.DAL
{
    public class SanPhamDAL
    {
        public DataTable GetAll(string keyword = "")
        {
            using (SqlConnection cn = Database.GetConnection())
            using (SqlCommand cmd = new SqlCommand(
                @"SELECT MaSP,TenSP,GiaBan,SoLuongTon FROM SanPham
                  WHERE MaSP LIKE @kw OR TenSP LIKE @kw ORDER BY TenSP", cn))
            {
                cmd.Parameters.Add("@kw", SqlDbType.NVarChar, 150).Value = "%" + keyword + "%";
                DataTable dt = new DataTable();
                cn.Open();
                using (SqlDataAdapter da = new SqlDataAdapter(cmd)) da.Fill(dt);
                return dt;
            }
        }

        public int Insert(SanPhamDTO p)
        {
            return Execute(@"INSERT INTO SanPham(MaSP,TenSP,GiaBan,SoLuongTon)
                             VALUES(@ma,@ten,@gia,@ton)",
                p);
        }

        public int Update(SanPhamDTO p)
        {
            return Execute(@"UPDATE SanPham SET TenSP=@ten,GiaBan=@gia,SoLuongTon=@ton
                             WHERE MaSP=@ma", p);
        }

        public int Delete(string ma)
        {
            using (SqlConnection cn = Database.GetConnection())
            using (SqlCommand cmd = new SqlCommand("DELETE FROM SanPham WHERE MaSP=@ma", cn))
            {
                cmd.Parameters.Add("@ma", SqlDbType.VarChar, 20).Value = ma;
                cn.Open();
                return cmd.ExecuteNonQuery();
            }
        }

        private int Execute(string sql, SanPhamDTO p)
        {
            using (SqlConnection cn = Database.GetConnection())
            using (SqlCommand cmd = new SqlCommand(sql, cn))
            {
                cmd.Parameters.Add("@ma", SqlDbType.VarChar, 20).Value = p.MaSP;
                cmd.Parameters.Add("@ten", SqlDbType.NVarChar, 150).Value = p.TenSP;
                cmd.Parameters.Add("@gia", SqlDbType.Decimal).Value = p.GiaBan;
                cmd.Parameters["@gia"].Precision = 18; cmd.Parameters["@gia"].Scale = 2;
                cmd.Parameters.Add("@ton", SqlDbType.Int).Value = p.SoLuongTon;
                cn.Open();
                return cmd.ExecuteNonQuery();
            }
        }
    }
}
