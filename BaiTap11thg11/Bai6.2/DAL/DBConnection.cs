using Microsoft.Data.SqlClient;

namespace HRM_Payroll.DAL
{
    public static class DBConnection
    {
        // Sửa Server theo tên SQL Server trên máy của bạn.
        public static string ConnectionString =
            @"Data Source=DESKTOP-NSLN2N8\SQLEXPRESS02;
              Initial Catalog=HRMDB;
              Integrated Security=True;
              TrustServerCertificate=True";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }
    }
}
