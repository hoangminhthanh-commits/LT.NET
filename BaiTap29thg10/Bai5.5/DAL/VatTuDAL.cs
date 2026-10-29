using Microsoft.Data.SqlClient;
using System.Data;

namespace Bai5._5.DAL
{
    public class VatTuDAL : Database
    {
        // =========================
        // LẤY TẤT CẢ
        // =========================

        public DataTable GetAll()
        {
            using (SqlConnection conn = GetConnection())
            {
                string sql = @"
                    SELECT
                        MaVatTu,
                        TenVatTu,
                        DVT,
                        SoLuongTon
                    FROM VatTu";

                SqlDataAdapter adapter =
                    new SqlDataAdapter(sql, conn);

                DataTable dt =
                    new DataTable();

                adapter.Fill(dt);

                return dt;
            }
        }

        // =========================
        // THÊM
        // =========================

        public void Them(
            string ma,
            string ten,
            string dvt,
            decimal soLuong)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();

                string sql = @"
                    INSERT INTO VatTu
                    (
                        MaVatTu,
                        TenVatTu,
                        DVT,
                        SoLuongTon
                    )
                    VALUES
                    (
                        @Ma,
                        @Ten,
                        @DVT,
                        @SoLuong
                    )";

                using (SqlCommand cmd =
                    new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue(
                        "@Ma", ma);

                    cmd.Parameters.AddWithValue(
                        "@Ten", ten);

                    cmd.Parameters.AddWithValue(
                        "@DVT", dvt);

                    cmd.Parameters.AddWithValue(
                        "@SoLuong", soLuong);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        // =========================
        // SỬA
        // =========================

        public void Sua(
            string ma,
            string ten,
            string dvt,
            decimal soLuong)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();

                string sql = @"
                    UPDATE VatTu
                    SET
                        TenVatTu = @Ten,
                        DVT = @DVT,
                        SoLuongTon = @SoLuong
                    WHERE MaVatTu = @Ma";

                using (SqlCommand cmd =
                    new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue(
                        "@Ma", ma);

                    cmd.Parameters.AddWithValue(
                        "@Ten", ten);

                    cmd.Parameters.AddWithValue(
                        "@DVT", dvt);

                    cmd.Parameters.AddWithValue(
                        "@SoLuong", soLuong);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        // =========================
        // XÓA
        // =========================

        public void Xoa(string ma)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();

                string sql = @"
                    DELETE FROM VatTu
                    WHERE MaVatTu = @Ma";

                using (SqlCommand cmd =
                    new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue(
                        "@Ma", ma);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        // =========================
        // TÌM KIẾM
        // =========================

        public DataTable TimKiem(
            string tuKhoa)
        {
            using (SqlConnection conn = GetConnection())
            {
                string sql = @"
                    SELECT
                        MaVatTu,
                        TenVatTu,
                        DVT,
                        SoLuongTon
                    FROM VatTu
                    WHERE MaVatTu LIKE @TuKhoa
                       OR TenVatTu LIKE @TuKhoa";

                SqlDataAdapter adapter =
                    new SqlDataAdapter(sql, conn);

                adapter.SelectCommand
                    .Parameters.AddWithValue(
                        "@TuKhoa",
                        "%" + tuKhoa + "%");

                DataTable dt =
                    new DataTable();

                adapter.Fill(dt);

                return dt;
            }
        }
    }
}