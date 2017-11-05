using LogInProject.DAL.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogInProject.DAL
{
    class LogInDA
    {


        public bool ConfrimAdminFromDB(LogIn aLogIn) 
        {

            SqlConnection connection = DatabaseConnection.OpenAnSqlConnection();
            string query = "SELECT Role FROM LogIN WHERE Username = '" +aLogIn.name+ "' AND Password = '" +aLogIn.password+ "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
           int result = sda.Fill(dt);
            if (result==1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
