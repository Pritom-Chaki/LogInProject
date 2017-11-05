using LogInProject.DAL;
using LogInProject.DAL.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogInProject.BLL
{
    class LogInBL
    {
        public bool ValidateLogInAndSendToDA(LogIn aLogIn)
        {
            

            if (aLogIn.name == "" || aLogIn.password == "")
            {

                return false;
                
            }

            else
            {
                LogInDA aLogInDA = new LogInDA();
                bool result = aLogInDA.ConfrimAdminFromDB(aLogIn);
                return result;

            }

        }
    }
}
