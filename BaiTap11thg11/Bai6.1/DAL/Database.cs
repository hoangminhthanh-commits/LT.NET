using System.Configuration;
using Microsoft.Data.SqlClient;

namespace QuanLyBanHangMini.DAL
{
    public static class Database
    {
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(
                ConfigurationManager.ConnectionStrings["SalesDB"].ConnectionString);
        }
    }
}
