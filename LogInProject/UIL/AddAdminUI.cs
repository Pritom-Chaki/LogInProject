using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogInProject.DAL.DAO;
using LogInProject.BLL;

namespace LogInProject
{
    public partial class AddAdminUI : Form
    {
        public AddAdminUI()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddAdmin aAddAdmin = new AddAdmin(); 
            aAddAdmin.name = nameTextBox.Text;
            aAddAdmin.password = passwordTextBox.Text;
            aAddAdmin.role = rollTextBox.Text;

            AddAdminBL AddAdminBLOBj = new AddAdminBL();
            bool result = AddAdminBLOBj.AddAdminToDB(aAddAdmin);

            if (result)
            {
                MessageBox.Show("Success!!!");
                nameTextBox.Clear();
                passwordTextBox.Clear();
                rollTextBox.Clear();
            }
            else
            {
                MessageBox.Show("ERROR!!!!");
            }
        }

    private void backButton_Click(object sender, EventArgs e)
        {
           LoginWindow logInobject = new LoginWindow();
            logInobject.Show();
            this.Hide();
        }
    }
}
