using Microsoft.Data.SqlClient;
using System;
using System.Data;

namespace Bai5._4.DAL
{
    public class PhieuDatPhongDAL : Database
    {
        // ==========================================
        // LẤY PHIẾU ĐANG Ở CỦA PHÒNG
        // ==========================================
        public int GetPhieuDangO(string soPhong)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();

                string sql = @"
                    SELECT TOP 1 MaPhieu
                    FROM PhieuDatPhong
                    WHERE SoPhong = @SoPhong
                    AND NgayTraPhong IS NULL
                    ORDER BY MaPhieu DESC";

                using (SqlCommand cmd =
                    new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue(
                        "@SoPhong", soPhong);

                    object result =
                        cmd.ExecuteScalar();

                    if (result == null)
                        return -1;

                    return Convert.ToInt32(result);
                }
            }
        }


        // ==========================================
        // CHECK-IN
        // INSERT PHIẾU + UPDATE PHÒNG
        // ==========================================
        public int CheckIn(
            string soPhong,
            int maKH)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();

                SqlTransaction transaction =
                    conn.BeginTransaction();

                try
                {
                    // 1. Kiểm tra phòng còn trống
                    string sqlCheck = @"
                        SELECT TrangThai
                        FROM Phong
                        WHERE SoPhong = @SoPhong";

                    string trangThai;

                    using (SqlCommand cmd =
                        new SqlCommand(
                            sqlCheck,
                            conn,
                            transaction))
                    {
                        cmd.Parameters.AddWithValue(
                            "@SoPhong", soPhong);

                        object result =
                            cmd.ExecuteScalar();

                        if (result == null)
                            throw new Exception(
                                "Không tìm thấy phòng!");

                        trangThai =
                            result.ToString();
                    }

                    if (trangThai != "Trống")
                    {
                        throw new Exception(
                            "Phòng này không còn trống!");
                    }


                    // 2. Tạo phiếu nhận phòng
                    string sqlInsert = @"
                        INSERT INTO PhieuDatPhong
                        (
                            SoPhong,
                            MaKH,
                            NgayNhanPhong,
                            TongTienThanhToan
                        )
                        OUTPUT INSERTED.MaPhieu
                        VALUES
                        (
                            @SoPhong,
                            @MaKH,
                            GETDATE(),
                            0
                        )";

                    int maPhieu;

                    using (SqlCommand cmd =
                        new SqlCommand(
                            sqlInsert,
                            conn,
                            transaction))
                    {
                        cmd.Parameters.AddWithValue(
                            "@SoPhong", soPhong);

                        cmd.Parameters.AddWithValue(
                            "@MaKH", maKH);

                        maPhieu =
                            Convert.ToInt32(
                                cmd.ExecuteScalar());
                    }


                    // 3. Chuyển phòng sang Đang ở
                    string sqlUpdate = @"
                        UPDATE Phong
                        SET TrangThai = N'Đang ở'
                        WHERE SoPhong = @SoPhong";

                    using (SqlCommand cmd =
                        new SqlCommand(
                            sqlUpdate,
                            conn,
                            transaction))
                    {
                        cmd.Parameters.AddWithValue(
                            "@SoPhong", soPhong);

                        cmd.ExecuteNonQuery();
                    }

                    transaction.Commit();

                    return maPhieu;
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }


        // ==========================================
        // THÊM DỊCH VỤ
        // ==========================================
        public void ThemDichVu(
            int maPhieu,
            int maDV,
            int soLuong)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();

                string sql = @"
                    INSERT INTO SuDungDichVu
                    (
                        MaPhieu,
                        MaDV,
                        SoLuong,
                        ThoiGian
                    )
                    VALUES
                    (
                        @MaPhieu,
                        @MaDV,
                        @SoLuong,
                        GETDATE()
                    )";

                using (SqlCommand cmd =
                    new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue(
                        "@MaPhieu", maPhieu);

                    cmd.Parameters.AddWithValue(
                        "@MaDV", maDV);

                    cmd.Parameters.AddWithValue(
                        "@SoLuong", soLuong);

                    cmd.ExecuteNonQuery();
                }
            }
        }


        // ==========================================
        // LẤY DANH SÁCH DỊCH VỤ ĐÃ DÙNG
        // ==========================================
        public DataTable GetDichVuDaDung(
            int maPhieu)
        {
            using (SqlConnection conn = GetConnection())
            {
                string sql = @"
                    SELECT
                        sdv.MaDV,
                        dv.TenDV,
                        sdv.SoLuong,
                        dv.DonGia,
                        sdv.SoLuong * dv.DonGia
                            AS ThanhTien,
                        sdv.ThoiGian
                    FROM SuDungDichVu sdv
                    INNER JOIN DichVu dv
                        ON sdv.MaDV = dv.MaDV
                    WHERE sdv.MaPhieu = @MaPhieu
                    ORDER BY sdv.ThoiGian";

                SqlDataAdapter adapter =
                    new SqlDataAdapter(sql, conn);

                adapter.SelectCommand.Parameters.AddWithValue(
                    "@MaPhieu", maPhieu);

                DataTable dt = new DataTable();

                adapter.Fill(dt);

                return dt;
            }
        }


        // ==========================================
        // LẤY THỜI GIAN NHẬN PHÒNG
        // ==========================================
        public DateTime GetNgayNhanPhong(
            int maPhieu)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();

                string sql = @"
                    SELECT NgayNhanPhong
                    FROM PhieuDatPhong
                    WHERE MaPhieu = @MaPhieu";

                using (SqlCommand cmd =
                    new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue(
                        "@MaPhieu", maPhieu);

                    object result =
                        cmd.ExecuteScalar();

                    if (result == null)
                        throw new Exception(
                            "Không tìm thấy phiếu!");

                    return Convert.ToDateTime(result);
                }
            }
        }


        // ==========================================
        // LẤY GIÁ PHÒNG
        // ==========================================
        public decimal GetGiaPhong(
            string soPhong)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();

                string sql = @"
                    SELECT GiaTheoGio
                    FROM Phong
                    WHERE SoPhong = @SoPhong";

                using (SqlCommand cmd =
                    new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue(
                        "@SoPhong", soPhong);

                    object result =
                        cmd.ExecuteScalar();

                    if (result == null)
                        throw new Exception(
                            "Không tìm thấy giá phòng!");

                    return Convert.ToDecimal(result);
                }
            }
        }


        // ==========================================
        // TÍNH TIỀN DỊCH VỤ
        // ==========================================
        public decimal TinhTienDichVu(
            int maPhieu)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();

                string sql = @"
                    SELECT ISNULL(
                        SUM(
                            sdv.SoLuong * dv.DonGia
                        ),
                        0
                    )
                    FROM SuDungDichVu sdv
                    INNER JOIN DichVu dv
                        ON sdv.MaDV = dv.MaDV
                    WHERE sdv.MaPhieu = @MaPhieu";

                using (SqlCommand cmd =
                    new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue(
                        "@MaPhieu", maPhieu);

                    return Convert.ToDecimal(
                        cmd.ExecuteScalar());
                }
            }
        }


        // ==========================================
        // CHECK-OUT + TRANSACTION
        // ==========================================
        public void CheckOut(
            int maPhieu,
            string soPhong,
            decimal tongTien)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();

                SqlTransaction transaction =
                    conn.BeginTransaction();

                try
                {
                    // 1. Cập nhật phiếu
                    string sqlPhieu = @"
                        UPDATE PhieuDatPhong
                        SET
                            NgayTraPhong = GETDATE(),
                            TongTienThanhToan = @TongTien
                        WHERE MaPhieu = @MaPhieu
                        AND NgayTraPhong IS NULL";

                    using (SqlCommand cmd =
                        new SqlCommand(
                            sqlPhieu,
                            conn,
                            transaction))
                    {
                        cmd.Parameters.AddWithValue(
                            "@MaPhieu", maPhieu);

                        cmd.Parameters.AddWithValue(
                            "@TongTien", tongTien);

                        int rows =
                            cmd.ExecuteNonQuery();

                        if (rows == 0)
                        {
                            throw new Exception(
                                "Phiếu này đã được thanh toán!");
                        }
                    }


                    // 2. Chuyển phòng sang Đang dọn dẹp
                    string sqlPhong = @"
                        UPDATE Phong
                        SET TrangThai = N'Đang dọn dẹp'
                        WHERE SoPhong = @SoPhong";

                    using (SqlCommand cmd =
                        new SqlCommand(
                            sqlPhong,
                            conn,
                            transaction))
                    {
                        cmd.Parameters.AddWithValue(
                            "@SoPhong", soPhong);

                        cmd.ExecuteNonQuery();
                    }


                    // 3. Commit
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