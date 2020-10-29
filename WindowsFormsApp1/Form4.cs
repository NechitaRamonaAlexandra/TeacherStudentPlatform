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
    public partial class studentPage : Form
    {
        public studentPage()
        {
            InitializeComponent();
            using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nechi\Desktop\WindowsFormsApp1\WindowsFormsApp1\SDBLog.mdf;Integrated Security=True"))
            {
                con.Open();
                SqlDataAdapter ad = new SqlDataAdapter("Select * From Courses", con);
                DataTable dt = new DataTable();
                ad.Fill(dt);

                coursesDG.DataSource = dt;
            }
        }

        private void seeCourseBtn_Click(object sender, EventArgs e)
        {
            Form bb = new SLogin();
            this.Close();
            bb.Show();
        }
    }
}
