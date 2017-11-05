using LogInProject.DAL.DAO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogInProject.DAL
{
    class AddAdminDA
    {
        public bool SaveNewAdminToDB(AddAdmin aAddAdmin)
        {

            SqlConnection connection = DatabaseConnection.OpenAnSqlConnection();
            string query = "INSERT INTO LogIN  VALUES ('" +aAddAdmin.name + "', '" + aAddAdmin.password + "','" + aAddAdmin.role + "')";
            SqlCommand command = new SqlCommand(query, connection);
            int rowsAffected = command.ExecuteNonQuery();
            if(rowsAffected == 1)
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
