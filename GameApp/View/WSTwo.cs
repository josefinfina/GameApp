using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameQuiz.View;

namespace GameQuiz.View
{
    public partial class WSTwo : Form
    {
        private WebReference.WebService proxy = new WebReference.WebService();
        int tempPlayerPoints = LoginForm.currentPlayerPoints;
        string tempUsername = LoginForm.currentPlayerUsername;

        public WSTwo()
        {
            InitializeComponent();
        }

        private void FindHighscoreAndPrint()
        {
            proxy.FindHighscoreList();

            DataTable highscoreList = proxy.FindHighscoreList();
            highscoresDataGridView.DataSource = proxy.FindHighscoreList();
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm frm = new LoginForm();
            frm.SelectedTab = 1;
            frm.Show();
        }

        private void findHighscoresButton_Click(object sender, EventArgs e)
        {
            FindHighscoreAndPrint();
        }
    }
}
