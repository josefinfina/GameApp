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
    public partial class WSOne : Form
    {
        private WebReference.WebService proxy = new WebReference.WebService();
        string tempTxt;

        public WSOne()
        {
            InitializeComponent();
           
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm frm = new LoginForm();
            frm.SelectedTab = 1;
            frm.Show();
        }

        private void findFileButton_Click(object sender, EventArgs e)
        {

            string filename = searchFileTextBox.Text;

            tempTxt = proxy.txtFile(filename);
            returnFileTextBox.Text = tempTxt;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
