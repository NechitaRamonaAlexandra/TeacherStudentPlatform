using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;
using System.Configuration;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class teacherLogIn : Form
    {
        public teacherLogIn()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
            UniversityAppPanel p = new UniversityAppPanel();
            p.Show();
        }

        private bool isUsernameValid()
        {
            if (usernameTextBox.Text == "")
            {
                MessageBox.Show("Please enter username!");
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool isPasswordValid()
        {
            if (passwordTextBox.Text == "")
            {
                MessageBox.Show("Please enter password!");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void PLogInBtn_Click(object sender, EventArgs e)
        {
            if (isPasswordValid() && isUsernameValid())
            {
                SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nechi\Desktop\WindowsFormsApp1\WindowsFormsApp1\SDBLog.mdf;Integrated Security=True");
                SqlDataAdapter adap = new SqlDataAdapter("Select count(*) From ProfLogIn where Username  = '" + usernameTextBox.Text + "' and Password = '" + passwordTextBox.Text + "'", connection);
                DataTable dt = new DataTable();
                adap.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("Congratulations! You entered right");
                }
                else
                {
                    MessageBox.Show("Something is wrong..");
                }
            }
        }
    }
}
