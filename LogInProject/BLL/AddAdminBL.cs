using LogInProject.DAL;
using LogInProject.DAL.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogInProject.BLL
{
    class AddAdminBL
    {

        public bool AddAdminToDB(AddAdmin aAddAdmin)
        {
            if(aAddAdmin.name == "" || aAddAdmin.password== "" || aAddAdmin.role =="")
            {
                return false;
            }
            else
            {
                AddAdminDA addAdminDAOBj = new AddAdminDA();
                bool result = addAdminDAOBj.SaveNewAdminToDB(aAddAdmin);
                return result;
            }

        }
    }
}
