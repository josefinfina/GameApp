using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameQuiz.View
{
    public partial class ERPUpdateDb : Form
    {
        public ERPUpdateDb()
        {
            InitializeComponent();
        }

        private void deleteEmployeeNoLabel_Click(object sender, EventArgs e)
        {

        }

        private void employeeNoLabel_Click(object sender, EventArgs e)
        {

        }

        private void insertUpdatePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm frm = new LoginForm();
            frm.SelectedTab = 2;
            frm.Show();
        }

        private void deleteLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
