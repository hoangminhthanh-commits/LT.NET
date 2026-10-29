using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Bai5._3.DAL
{
    public class MonAnDAL : Database
    {
        public DataTable GetAll()
        {
            using (SqlConnection conn = GetConnection())
            {
                string sql = @"
                    SELECT 
                        MaMon,
                        TenMon,
                        MaDanhMuc,
                        DonGia
                    FROM MonAn";

                SqlDataAdapter adapter =
                    new SqlDataAdapter(sql, conn);

                DataTable dt = new DataTable();

                adapter.Fill(dt);

                return dt;
            }
        }
    }
}
