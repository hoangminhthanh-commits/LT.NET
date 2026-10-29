using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Bai5._3.DAL
{
    public class BanAnDAL : Database
    {
        public DataTable GetAll()
        {
            using (SqlConnection conn = GetConnection())
            {
                string sql = "SELECT * FROM BanAn";

                SqlDataAdapter adapter =
                    new SqlDataAdapter(sql, conn);

                DataTable dt = new DataTable();

                adapter.Fill(dt);

                return dt;
            }
        }

        public void CapNhatTrangThai(int maBan, string trangThai)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();

                string sql = @"
                    UPDATE BanAn
                    SET TrangThai = @TrangThai
                    WHERE MaBan = @MaBan";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@MaBan", maBan);
                cmd.Parameters.AddWithValue("@TrangThai", trangThai);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
