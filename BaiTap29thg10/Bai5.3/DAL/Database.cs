using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;

namespace Bai5._3.DAL
{
    public class Database
    {
        protected string connectionString =
            @"Data Source=DESKTOP-NSLN2N8\SQLEXPRESS02;Initial Catalog=CafePOSDB;Integrated Security=True;TrustServerCertificate=True";

        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
