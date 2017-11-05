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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void allAdminButton_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-5GATMRA\SQLEXPRESS; Database=LOGIN_DATABASE; Integrated Security = SSPI";
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;
            connection.Open();
            // MessageBox.Show("DONE!!");

            //String Query = ("SELECT * FROM LogIN");
            //SqlCommand command = new SqlCommand(Query, connection);
            //MessageBox.Show(Query);
        }
    }
}
