using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class regForm : Form
    {
        public regForm()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
           
            SLogin stback = new SLogin();
            stback.Show();
            this.Close();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nechi\Desktop\WindowsFormsApp1\WindowsFormsApp1\SDBLog.mdf;Integrated Security=True"))
            {
                
                SqlCommand cmd = new SqlCommand();
                SqlDataAdapter adap = new SqlDataAdapter("Select count(*) From StudLogIn where Username  = '" + usernameTextBox.Text + "' and Password = '" + passwordTextBox.Text + "'", con);
                DataTable dt = new DataTable();
                adap.Fill(dt);
                //Guid guid = new Guid();
                int i = 7;
                //i = dt.Columns[3].ToInt32();  how to make it insert in database at last position
                cmd.Parameters.AddWithValue("@StudentID", ++i);
                cmd.Parameters.AddWithValue("@Username", usernameTextBox.Text.Trim());
                cmd.Parameters.AddWithValue("@Password", passwordTextBox.Text.Trim());
                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO StudLogIn (StudentID,Username,Password) VALUES (@StudentID,@Username,@Password)";
                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                    //ErrorMessage.Text = "Registered successfully.";
                    
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }
    }
}
