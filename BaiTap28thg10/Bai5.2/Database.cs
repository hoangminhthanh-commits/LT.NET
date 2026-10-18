using Microsoft.Data.SqlClient;

namespace Bai5._2
{
    public class Database
    {
        private string connectionString =
            @"Data Source=DESKTOP-NSLN2N8\SQLEXPRESS02;
              Initial Catalog=ql_dangky;
              Integrated Security=True;
              TrustServerCertificate=True;";

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
