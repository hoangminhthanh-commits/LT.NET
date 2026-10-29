using Microsoft.Data.SqlClient;
using System;
using System.Data;

namespace Bai5._3.DAL
{
    public class HoaDonDAL : Database
    {
        public int GetHoaDonDangMo(int maBan)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();

                string sql = @"
                    SELECT MaHoaDon
                    FROM HoaDon
                    WHERE MaBan = @MaBan
                    AND TrangThai = 0";

                using (SqlCommand cmd =
                    new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue(
                        "@MaBan", maBan);

                    object result =
                        cmd.ExecuteScalar();

                    if (result == null)
                        return -1;

                    return Convert.ToInt32(result);
                }
            }
        }

        public DataTable GetChiTietHoaDon(int maBan)
        {
            using (SqlConnection conn = GetConnection())
            {
                string sql = @"
                    SELECT
                        cthd.MaMon,
                        mon.TenMon,
                        cthd.SoLuong,
                        cthd.DonGia,
                        cthd.SoLuong * cthd.DonGia AS ThanhTien
                    FROM HoaDon hd
                    INNER JOIN ChiTietHoaDon cthd
                        ON hd.MaHoaDon = cthd.MaHoaDon
                    INNER JOIN MonAn mon
                        ON cthd.MaMon = mon.MaMon
                    WHERE hd.MaBan = @MaBan
                    AND hd.TrangThai = 0";

                SqlDataAdapter adapter =
                    new SqlDataAdapter(sql, conn);

                adapter.SelectCommand.Parameters.AddWithValue(
                    "@MaBan", maBan);

                DataTable dt = new DataTable();

                adapter.Fill(dt);

                return dt;
            }
        }

        public void ThemMon(
            int maBan,
            int maMon,
            int soLuong)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();

                SqlTransaction transaction =
                    conn.BeginTransaction();

                try
                {
                    int maHoaDon = -1;

                    string sqlHoaDon = @"
                        SELECT MaHoaDon
                        FROM HoaDon
                        WHERE MaBan = @MaBan
                        AND TrangThai = 0";

                    using (SqlCommand cmd =
                        new SqlCommand(
                            sqlHoaDon,
                            conn,
                            transaction))
                    {
                        cmd.Parameters.AddWithValue(
                            "@MaBan", maBan);

                        object result =
                            cmd.ExecuteScalar();

                        if (result != null)
                        {
                            maHoaDon =
                                Convert.ToInt32(result);
                        }
                    }

                    if (maHoaDon == -1)
                    {
                        string sqlTaoHoaDon = @"
                            INSERT INTO HoaDon
                            (
                                MaBan,
                                GioVao,
                                TongTien,
                                TrangThai
                            )
                            VALUES
                            (
                                @MaBan,
                                GETDATE(),
                                0,
                                0
                            );

                            SELECT SCOPE_IDENTITY();";

                        using (SqlCommand cmd =
                            new SqlCommand(
                                sqlTaoHoaDon,
                                conn,
                                transaction))
                        {
                            cmd.Parameters.AddWithValue(
                                "@MaBan", maBan);

                            maHoaDon =
                                Convert.ToInt32(
                                    cmd.ExecuteScalar());
                        }
                    }

                    decimal donGia;

                    string sqlGia = @"
                        SELECT DonGia
                        FROM MonAn
                        WHERE MaMon = @MaMon";

                    using (SqlCommand cmd =
                        new SqlCommand(
                            sqlGia,
                            conn,
                            transaction))
                    {
                        cmd.Parameters.AddWithValue(
                            "@MaMon", maMon);

                        object result =
                            cmd.ExecuteScalar();

                        if (result == null)
                            throw new Exception(
                                "Không tìm thấy món ăn.");

                        donGia =
                            Convert.ToDecimal(result);
                    }

                    string sqlKiemTra = @"
                        SELECT COUNT(*)
                        FROM ChiTietHoaDon
                        WHERE MaHoaDon = @MaHoaDon
                        AND MaMon = @MaMon";

                    int tonTai;

                    using (SqlCommand cmd =
                        new SqlCommand(
                            sqlKiemTra,
                            conn,
                            transaction))
                    {
                        cmd.Parameters.AddWithValue(
                            "@MaHoaDon", maHoaDon);

                        cmd.Parameters.AddWithValue(
                            "@MaMon", maMon);

                        tonTai =
                            Convert.ToInt32(
                                cmd.ExecuteScalar());
                    }

                    if (tonTai > 0)
                    {
                        string sqlUpdate = @"
                            UPDATE ChiTietHoaDon
                            SET SoLuong = SoLuong + @SoLuong
                            WHERE MaHoaDon = @MaHoaDon
                            AND MaMon = @MaMon";

                        using (SqlCommand cmd =
                            new SqlCommand(
                                sqlUpdate,
                                conn,
                                transaction))
                        {
                            cmd.Parameters.AddWithValue(
                                "@SoLuong", soLuong);

                            cmd.Parameters.AddWithValue(
                                "@MaHoaDon", maHoaDon);

                            cmd.Parameters.AddWithValue(
                                "@MaMon", maMon);

                            cmd.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        string sqlInsert = @"
                            INSERT INTO ChiTietHoaDon
                            (
                                MaHoaDon,
                                MaMon,
                                SoLuong,
                                DonGia
                            )
                            VALUES
                            (
                                @MaHoaDon,
                                @MaMon,
                                @SoLuong,
                                @DonGia
                            )";

                        using (SqlCommand cmd =
                            new SqlCommand(
                                sqlInsert,
                                conn,
                                transaction))
                        {
                            cmd.Parameters.AddWithValue(
                                "@MaHoaDon", maHoaDon);

                            cmd.Parameters.AddWithValue(
                                "@MaMon", maMon);

                            cmd.Parameters.AddWithValue(
                                "@SoLuong", soLuong);

                            cmd.Parameters.AddWithValue(
                                "@DonGia", donGia);

                            cmd.ExecuteNonQuery();
                        }
                    }

                    string sqlBan = @"
                        UPDATE BanAn
                        SET TrangThai = N'Có khách'
                        WHERE MaBan = @MaBan";

                    using (SqlCommand cmd =
                        new SqlCommand(
                            sqlBan,
                            conn,
                            transaction))
                    {
                        cmd.Parameters.AddWithValue(
                            "@MaBan", maBan);

                        cmd.ExecuteNonQuery();
                    }

                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        public void SuaMon(
            int maBan,
            int maMon,
            int soLuong)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();

                string sql = @"
                    UPDATE cthd
                    SET cthd.SoLuong = @SoLuong
                    FROM ChiTietHoaDon cthd
                    INNER JOIN HoaDon hd
                        ON cthd.MaHoaDon = hd.MaHoaDon
                    WHERE hd.MaBan = @MaBan
                    AND hd.TrangThai = 0
                    AND cthd.MaMon = @MaMon";

                using (SqlCommand cmd =
                    new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue(
                        "@MaBan", maBan);

                    cmd.Parameters.AddWithValue(
                        "@MaMon", maMon);

                    cmd.Parameters.AddWithValue(
                        "@SoLuong", soLuong);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void XoaMon(
            int maBan,
            int maMon)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();

                string sql = @"
                    DELETE cthd
                    FROM ChiTietHoaDon cthd
                    INNER JOIN HoaDon hd
                        ON cthd.MaHoaDon = hd.MaHoaDon
                    WHERE hd.MaBan = @MaBan
                    AND hd.TrangThai = 0
                    AND cthd.MaMon = @MaMon";

                using (SqlCommand cmd =
                    new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue(
                        "@MaBan", maBan);

                    cmd.Parameters.AddWithValue(
                        "@MaMon", maMon);

                    cmd.ExecuteNonQuery();
                }
            }
        }


        public void ThanhToan(
            int maBan,
            decimal tongTien)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();

                SqlTransaction transaction =
                    conn.BeginTransaction();

                try
                {
                    int maHoaDon = -1;

                    string sqlHoaDon = @"
                        SELECT MaHoaDon
                        FROM HoaDon
                        WHERE MaBan = @MaBan
                        AND TrangThai = 0";

                    using (SqlCommand cmd =
                        new SqlCommand(
                            sqlHoaDon,
                            conn,
                            transaction))
                    {
                        cmd.Parameters.AddWithValue(
                            "@MaBan", maBan);

                        object result =
                            cmd.ExecuteScalar();

                        if (result != null)
                        {
                            maHoaDon =
                                Convert.ToInt32(result);
                        }
                    }

                    if (maHoaDon == -1)
                    {
                        throw new Exception(
                            "Bàn này chưa có hóa đơn.");
                    }

                    string sqlThanhToan = @"
                        UPDATE HoaDon
                        SET
                            GioRa = GETDATE(),
                            TongTien = @TongTien,
                            TrangThai = 1
                        WHERE MaHoaDon = @MaHoaDon";

                    using (SqlCommand cmd =
                        new SqlCommand(
                            sqlThanhToan,
                            conn,
                            transaction))
                    {
                        cmd.Parameters.AddWithValue(
                            "@TongTien", tongTien);

                        cmd.Parameters.AddWithValue(
                            "@MaHoaDon", maHoaDon);

                        cmd.ExecuteNonQuery();
                    }

                    string sqlBan = @"
                        UPDATE BanAn
                        SET TrangThai = N'Trống'
                        WHERE MaBan = @MaBan";

                    using (SqlCommand cmd =
                        new SqlCommand(
                            sqlBan,
                            conn,
                            transaction))
                    {
                        cmd.Parameters.AddWithValue(
                            "@MaBan", maBan);

                        cmd.ExecuteNonQuery();
                    }

                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }
    }
}