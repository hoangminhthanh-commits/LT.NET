using Microsoft.Data.SqlClient;

namespace Bai5._4.DAL
{
    public class Database
    {
        protected string connectionString =
            @"Data Source=DESKTOP-NSLN2N8\SQLEXPRESS02;
              Initial Catalog=HotelDB;
              Integrated Security=True;
              TrustServerCertificate=True";

        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}