using Microsoft.Data.SqlClient;
using System.Data;

namespace Bai5._4.DAL
{
    public class DichVuDAL : Database
    {
        public DataTable GetAll()
        {
            using (SqlConnection conn = GetConnection())
            {
                string sql = @"
                    SELECT
                        MaDV,
                        TenDV,
                        DonGia
                    FROM DichVu
                    ORDER BY TenDV";

                SqlDataAdapter adapter =
                    new SqlDataAdapter(sql, conn);

                DataTable dt = new DataTable();

                adapter.Fill(dt);

                return dt;
            }
        }
    }
}