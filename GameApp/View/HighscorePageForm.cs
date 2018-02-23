using GameQuiz.Controller;
using GameQuiz.Model;
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
    public partial class HighscorePageForm : Form
    {
        Controll controller = new Controll();
        string tempUsername = LoginForm.currentPlayerUsername;
        int highscore = 0;

        public HighscorePageForm(string currentUserName, int currentUserPoints)
        {
            InitializeComponent();
            FindHighscoreAndPrint();
        }

        private void FindHighscoreAndPrint()
        {
            DataTable highscoreList = controller.FindHighscoreList();
            HighscoreDataGridView.DataSource = controller.FindHighscoreList();
        }

        private void backToStartButton_Click(object sender, EventArgs e)
        {
            Plays pl = controller.FindPlayerInTblPlays(tempUsername);
            Plays plays = controller.FindPlayerPoints(pl);
            highscore = plays.points;

            this.Hide();
            new LoggedInForm(tempUsername, highscore).Show();
        }
    }
}
