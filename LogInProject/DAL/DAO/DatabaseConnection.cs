using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogInProject.DAL.DAO
{
    class DatabaseConnection
    {

        public static SqlConnection OpenAnSqlConnection()
        {
            string connectionString = @"Data Source=DESKTOP-L6QSFLT\SQLEXPRESS; Database= LOGIN_DATABASE; Integrated Security = SSPI";
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;
            connection.Open();
            return connection;
        }
    }
}
