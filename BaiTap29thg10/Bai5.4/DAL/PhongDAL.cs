using Microsoft.Data.SqlClient;
using System.Data;

namespace Bai5._4.DAL
{
    public class PhongDAL : Database
    {
        public DataTable GetAll()
        {
            using (SqlConnection conn = GetConnection())
            {
                string sql = @"
                    SELECT
                        SoPhong,
                        LoaiPhong,
                        GiaTheoGio,
                        TrangThai
                    FROM Phong
                    ORDER BY SoPhong";

                SqlDataAdapter adapter =
                    new SqlDataAdapter(sql, conn);

                DataTable dt = new DataTable();

                adapter.Fill(dt);

                return dt;
            }
        }

        public DataTable GetPhongTrong()
        {
            using (SqlConnection conn = GetConnection())
            {
                string sql = @"
                    SELECT
                        SoPhong,
                        LoaiPhong,
                        GiaTheoGio,
                        TrangThai
                    FROM Phong
                    WHERE TrangThai = N'Trống'
                    ORDER BY SoPhong";

                SqlDataAdapter adapter =
                    new SqlDataAdapter(sql, conn);

                DataTable dt = new DataTable();

                adapter.Fill(dt);

                return dt;
            }
        }

        public void CapNhatTrangThai(
            string soPhong,
            string trangThai)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();

                string sql = @"
                    UPDATE Phong
                    SET TrangThai = @TrangThai
                    WHERE SoPhong = @SoPhong";

                using (SqlCommand cmd =
                    new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue(
                        "@SoPhong", soPhong);

                    cmd.Parameters.AddWithValue(
                        "@TrangThai", trangThai);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}