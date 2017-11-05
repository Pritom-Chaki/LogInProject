using LogInProject.BLL;
using LogInProject.DAL.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogInProject
{
    public partial class LoginWindow : Form
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            LogIn aLogIn = new LogIn();
            aLogIn.name = textBox1.Text;
            aLogIn.password = textBox2.Text;

            LogInBL logInBLOBj = new LogInBL();
            bool result = logInBLOBj.ValidateLogInAndSendToDA(aLogIn);

            if (result)
            {

                this.Hide();
                Main mainObject = new Main();
                mainObject.Show();
               // MessageBox.Show("Succesful!!!!");
            

            }

            else
            {
                MessageBox.Show("ERROR!!");
            }

        }


    

    private void addAdminButton_Click(object sender, EventArgs e)
    {
        this.Hide();
        AddAdminUI addAdminObject = new AddAdminUI();
        addAdminObject.Show();

    }
}
}
