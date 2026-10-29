using Microsoft.Data.SqlClient;
using System.Data;

namespace Bai5._5.DAL
{
    public class NhaCungCapDAL : Database
    {
        public DataTable GetAll()
        {
            using (SqlConnection conn = GetConnection())
            {
                string sql = @"
                    SELECT
                        MaNCC,
                        TenNCC
                    FROM NhaCungCap";

                SqlDataAdapter adapter =
                    new SqlDataAdapter(sql, conn);

                DataTable dt = new DataTable();

                adapter.Fill(dt);

                return dt;
            }
        }
    }
}