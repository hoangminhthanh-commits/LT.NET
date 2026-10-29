using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace Bai5._5.DAL
{
    public class PhieuKhoDAL : Database
    {
        public int LuuPhieu(
            string loaiPhieu,
            int? maNCC,
            decimal tongTien,
            DataTable chiTiet)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();

                SqlTransaction trans = conn.BeginTransaction();

                try
                {
                    string sqlPhieu = @"
                        INSERT INTO PhieuKho
                        (
                            LoaiPhieu,
                            MaNCC,
                            TongTien
                        )
                        VALUES
                        (
                            @LoaiPhieu,
                            @MaNCC,
                            @TongTien
                        );

                        SELECT SCOPE_IDENTITY();";

                    int maPhieu;

                    using (SqlCommand cmd =
                        new SqlCommand(
                            sqlPhieu,
                            conn,
                            trans))
                    {
                        cmd.Parameters.AddWithValue(
                            "@LoaiPhieu",
                            loaiPhieu);

                        if (maNCC.HasValue)
                        {
                            cmd.Parameters.AddWithValue(
                                "@MaNCC",
                                maNCC.Value);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue(
                                "@MaNCC",
                                DBNull.Value);
                        }

                        cmd.Parameters.AddWithValue(
                            "@TongTien",
                            tongTien);

                        maPhieu = Convert.ToInt32(
                            cmd.ExecuteScalar());
                    }

                    foreach (DataRow row in chiTiet.Rows)
                    {
                        string maVatTu =
                            row["MaVatTu"].ToString();

                        decimal soLuong =
                            Convert.ToDecimal(
                                row["SoLuong"]);

                        decimal donGia =
                            Convert.ToDecimal(
                                row["DonGia"]);

                        string sqlChiTiet = @"
                            INSERT INTO ChiTietPhieuKho
                            (
                                MaPhieu,
                                MaVatTu,
                                SoLuong,
                                DonGia
                            )
                            VALUES
                            (
                                @MaPhieu,
                                @MaVatTu,
                                @SoLuong,
                                @DonGia
                            )";

                        using (SqlCommand cmd =
                            new SqlCommand(
                                sqlChiTiet,
                                conn,
                                trans))
                        {
                            cmd.Parameters.AddWithValue(
                                "@MaPhieu",
                                maPhieu);

                            cmd.Parameters.AddWithValue(
                                "@MaVatTu",
                                maVatTu);

                            cmd.Parameters.AddWithValue(
                                "@SoLuong",
                                soLuong);

                            cmd.Parameters.AddWithValue(
                                "@DonGia",
                                donGia);

                            cmd.ExecuteNonQuery();
                        }

                        if (loaiPhieu == "NHAP")
                        {
                            string sqlNhap = @"
                                UPDATE VatTu
                                SET SoLuongTon =
                                    SoLuongTon + @SoLuong
                                WHERE MaVatTu = @MaVatTu";

                            using (SqlCommand cmd =
                                new SqlCommand(
                                    sqlNhap,
                                    conn,
                                    trans))
                            {
                                cmd.Parameters.AddWithValue(
                                    "@SoLuong",
                                    soLuong);

                                cmd.Parameters.AddWithValue(
                                    "@MaVatTu",
                                    maVatTu);

                                cmd.ExecuteNonQuery();
                            }
                        }
                        else if (loaiPhieu == "XUAT")
                        {
                            string sqlKiemTra = @"
                                SELECT SoLuongTon
                                FROM VatTu
                                WHERE MaVatTu = @MaVatTu";

                            decimal tonKho;

                            using (SqlCommand cmd =
                                new SqlCommand(
                                    sqlKiemTra,
                                    conn,
                                    trans))
                            {
                                cmd.Parameters.AddWithValue(
                                    "@MaVatTu",
                                    maVatTu);

                                object result =
                                    cmd.ExecuteScalar();

                                if (result == null)
                                {
                                    throw new Exception(
                                        "Không tìm thấy vật tư: "
                                        + maVatTu);
                                }

                                tonKho =
                                    Convert.ToDecimal(result);
                            }

                            if (tonKho < soLuong)
                            {
                                throw new Exception(
                                    "Không đủ hàng trong kho cho vật tư "
                                    + maVatTu);
                            }

                            string sqlXuat = @"
                                UPDATE VatTu
                                SET SoLuongTon =
                                    SoLuongTon - @SoLuong
                                WHERE MaVatTu = @MaVatTu";

                            using (SqlCommand cmd =
                                new SqlCommand(
                                    sqlXuat,
                                    conn,
                                    trans))
                            {
                                cmd.Parameters.AddWithValue(
                                    "@SoLuong",
                                    soLuong);

                                cmd.Parameters.AddWithValue(
                                    "@MaVatTu",
                                    maVatTu);

                                cmd.ExecuteNonQuery();
                            }
                        }
                    }

                    trans.Commit();

                    return maPhieu;
                }
                catch
                {

                    trans.Rollback();

                    throw;
                }
            }
        }
    }
}