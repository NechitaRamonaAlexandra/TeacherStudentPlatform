using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class UniversityAppPanel : Form
    {
        public UniversityAppPanel()
        {
            InitializeComponent();
        }

        

        private void StudentBtn_Click(object sender, EventArgs e)
        {
            SLogin f2 = new SLogin();
            this.Hide();
            f2.Show();
        }

        private void ProfBtn_Click(object sender, EventArgs e)
        {
            teacherLogIn t = new teacherLogIn();
            this.Hide();
            t.Show();
        }
    }
}
