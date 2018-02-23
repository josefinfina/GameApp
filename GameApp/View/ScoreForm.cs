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
    public partial class ScoreForm : Form
    {
        Controll controller = new Controll();
        int newHighscore = 0;
        string tempUsername = LoginForm.currentPlayerUsername;
        int tempCurrentHighscore = LoginForm.currentPlayerPoints;
        int tempNewPoints = GameForm.currentSum;
        int tempHighscore = LoggedInForm.highscore;
        int currentHighscore = 0;

        public ScoreForm(int tempNewPoints, string currentPlayerUsername, int currentPlayerPoints)
        {
            InitializeComponent();
            yourHighscoreTextbox.Text = tempNewPoints.ToString();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Plays player = controller.FindPlayerInTblPlays(tempUsername);
            Plays plays = controller.FindPlayerPoints(player);
            currentHighscore = plays.points;

            //currentHighscore = player.points;
            //player.points = currentHighscore;

            if (tempNewPoints > currentHighscore)
            {
                controller.UpdatePlayerHighscore(tempNewPoints, player);
                newHighscore = tempNewPoints;
                this.Hide();
                new LoggedInForm(tempUsername, newHighscore).Show();
            }
            else
            {
                newHighscore = currentHighscore;
                this.Hide();
                new LoggedInForm(tempUsername, newHighscore).Show();
            }
        }

        private void PlayAgainButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new GameForm(tempUsername, tempCurrentHighscore).Show();
        }
    }
}
