using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using QuanLyBanHangMini.DTO;

namespace QuanLyBanHangMini.DAL
{
    public class HoaDonDAL
    {
        // Toàn bộ thao tác lập hóa đơn nằm trong MỘT transaction.
        public int ThanhToan(int maNV, int? maKH, List<ChiTietHoaDonDTO> gioHang)
        {
            if (gioHang == null || gioHang.Count == 0)
                throw new Exception("Giỏ hàng đang trống.");

            using (SqlConnection cn = Database.GetConnection())
            {
                cn.Open();
                using (SqlTransaction trans = cn.BeginTransaction(IsolationLevel.ReadCommitted))
                {
                    try
                    {
                        decimal tongTien = 0;
                        foreach (ChiTietHoaDonDTO item in gioHang)
                        {
                            if (item.SoLuong <= 0) throw new Exception("Số lượng phải lớn hơn 0.");
                            tongTien += item.SoLuong * item.DonGia;
                        }

                        int maHD;
                        using (SqlCommand cmd = new SqlCommand(
                            @"INSERT INTO HoaDon(MaNV,MaKH,TongTien)
                              VALUES(@nv,@kh,@tong); SELECT CAST(SCOPE_IDENTITY() AS INT);", cn, trans))
                        {
                            cmd.Parameters.Add("@nv", SqlDbType.Int).Value = maNV;
                            cmd.Parameters.Add("@kh", SqlDbType.Int).Value = maKH.HasValue ? (object)maKH.Value : DBNull.Value;
                            SqlParameter pTong = cmd.Parameters.Add("@tong", SqlDbType.Decimal);
                            pTong.Precision = 18; pTong.Scale = 2; pTong.Value = tongTien;
                            maHD = (int)cmd.ExecuteScalar();
                        }

                        foreach (ChiTietHoaDonDTO item in gioHang)
                        {
                            // UPDATE có điều kiện số lượng tồn để tránh bán vượt tồn kho.
                            using (SqlCommand cmdTon = new SqlCommand(
                                @"UPDATE SanPham SET SoLuongTon = SoLuongTon - @sl
                                  WHERE MaSP=@ma AND SoLuongTon >= @sl", cn, trans))
                            {
                                cmdTon.Parameters.Add("@sl", SqlDbType.Int).Value = item.SoLuong;
                                cmdTon.Parameters.Add("@ma", SqlDbType.VarChar, 20).Value = item.MaSP;
                                if (cmdTon.ExecuteNonQuery() != 1)
                                    throw new Exception("Sản phẩm " + item.MaSP + " không tồn tại hoặc không đủ tồn kho.");
                            }

                            using (SqlCommand cmdCT = new SqlCommand(
                                @"INSERT INTO ChiTietHoaDon(MaHD,MaSP,SoLuong,DonGia)
                                  VALUES(@hd,@sp,@sl,@gia)", cn, trans))
                            {
                                cmdCT.Parameters.Add("@hd", SqlDbType.Int).Value = maHD;
                                cmdCT.Parameters.Add("@sp", SqlDbType.VarChar, 20).Value = item.MaSP;
                                cmdCT.Parameters.Add("@sl", SqlDbType.Int).Value = item.SoLuong;
                                SqlParameter pGia = cmdCT.Parameters.Add("@gia", SqlDbType.Decimal);
                                pGia.Precision = 18; pGia.Scale = 2; pGia.Value = item.DonGia;
                                cmdCT.ExecuteNonQuery();
                            }
                        }

                        if (maKH.HasValue)
                        {
                            // Quy đổi: 1 điểm cho mỗi 100.000 đồng, lấy phần nguyên.
                            using (SqlCommand cmdDiem = new SqlCommand(
                                @"UPDATE KhachHang SET DiemTichLuy = DiemTichLuy + @diem
                                  WHERE MaKH=@kh", cn, trans))
                            {
                                cmdDiem.Parameters.Add("@diem", SqlDbType.Int).Value =
                                    decimal.ToInt32(decimal.Floor(tongTien / 100000m));
                                cmdDiem.Parameters.Add("@kh", SqlDbType.Int).Value = maKH.Value;
                                if (cmdDiem.ExecuteNonQuery() != 1)
                                    throw new Exception("Không tìm thấy khách hàng.");
                            }
                        }

                        trans.Commit();
                        return maHD;
                    }
                    catch
                    {
                        trans.Rollback();
                        throw;
                    }
                }
            }
        }

        public DataTable DoanhThu(DateTime tuNgay, DateTime denNgay)
        {
            using (SqlConnection cn = Database.GetConnection())
            using (SqlCommand cmd = new SqlCommand(
                @"SELECT CAST(NgayLap AS date) Ngay, SUM(TongTien) DoanhThu
                  FROM HoaDon WHERE NgayLap >= @tu AND NgayLap < @den
                  GROUP BY CAST(NgayLap AS date) ORDER BY Ngay", cn))
            {
                cmd.Parameters.Add("@tu", SqlDbType.DateTime).Value = tuNgay.Date;
                cmd.Parameters.Add("@den", SqlDbType.DateTime).Value = denNgay.Date.AddDays(1);
                DataTable dt = new DataTable(); cn.Open();
                using (SqlDataAdapter da = new SqlDataAdapter(cmd)) da.Fill(dt);
                return dt;
            }
        }

        public decimal TongDoanhThu(DateTime tuNgay, DateTime denNgay)
        {
            using (SqlConnection cn = Database.GetConnection())
            using (SqlCommand cmd = new SqlCommand(
                "SELECT ISNULL(SUM(TongTien),0) FROM HoaDon WHERE NgayLap>=@tu AND NgayLap<@den", cn))
            {
                cmd.Parameters.Add("@tu", SqlDbType.DateTime).Value = tuNgay.Date;
                cmd.Parameters.Add("@den", SqlDbType.DateTime).Value = denNgay.Date.AddDays(1);
                cn.Open(); return Convert.ToDecimal(cmd.ExecuteScalar());
            }
        }

        public DataTable Top5()
        {
            using (SqlConnection cn = Database.GetConnection())
            using (SqlCommand cmd = new SqlCommand(
                @"SELECT TOP 5 sp.MaSP,sp.TenSP,SUM(ct.SoLuong) TongSoLuong
                  FROM ChiTietHoaDon ct JOIN SanPham sp ON ct.MaSP=sp.MaSP
                  GROUP BY sp.MaSP,sp.TenSP
                  ORDER BY SUM(ct.SoLuong) DESC", cn))
            {
                DataTable dt = new DataTable(); cn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                    dt.Load(reader);
                return dt;
            }
        }
    }
}
