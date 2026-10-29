using Microsoft.Data.SqlClient;
using System;

namespace Bai5._4.DAL
{
    public class KhachHangDAL : Database
    {
        public int TimKhachHangTheoCCCD(
            string cccd)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();

                string sql = @"
                    SELECT MaKH
                    FROM KhachHang
                    WHERE CCCD = @CCCD";

                using (SqlCommand cmd =
                    new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue(
                        "@CCCD", cccd);

                    object result =
                        cmd.ExecuteScalar();

                    if (result == null)
                        return -1;

                    return Convert.ToInt32(result);
                }
            }
        }

        public object GetKhachHangTheoCCCD(
            string cccd)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();

                string sql = @"
                    SELECT
                        MaKH,
                        HoTen,
                        CCCD,
                        SoDienThoai
                    FROM KhachHang
                    WHERE CCCD = @CCCD";

                using (SqlCommand cmd =
                    new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue(
                        "@CCCD", cccd);

                    using (SqlDataReader reader =
                        cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new
                            {
                                MaKH = Convert.ToInt32(
                                    reader["MaKH"]),

                                HoTen =
                                    reader["HoTen"].ToString(),

                                CCCD =
                                    reader["CCCD"].ToString(),

                                SoDienThoai =
                                    reader["SoDienThoai"]
                                    == DBNull.Value
                                    ? ""
                                    : reader["SoDienThoai"]
                                      .ToString()
                            };
                        }
                    }
                }
            }

            return null;
        }

        public int ThemKhachHang(
            string hoTen,
            string cccd,
            string soDienThoai)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();

                string sql = @"
                    INSERT INTO KhachHang
                    (
                        HoTen,
                        CCCD,
                        SoDienThoai
                    )
                    OUTPUT INSERTED.MaKH
                    VALUES
                    (
                        @HoTen,
                        @CCCD,
                        @SoDienThoai
                    )";

                using (SqlCommand cmd =
                    new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue(
                        "@HoTen", hoTen);

                    cmd.Parameters.AddWithValue(
                        "@CCCD", cccd);

                    cmd.Parameters.AddWithValue(
                        "@SoDienThoai",
                        soDienThoai);

                    return Convert.ToInt32(
                        cmd.ExecuteScalar());
                }
            }
        }
    }
}