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
    public partial class LoggedInForm : Form
    {
        string tempUsername = LoginForm.currentPlayerUsername;
        int tempPoints = LoginForm.currentPlayerPoints;
        //int tempNewHighscore = ScoreForm.newHighscore;
        public static int highscore = 0;

        public LoggedInForm(string tempUsername, int currentPlayerPoints)
        {
            InitializeComponent();
            highscore = currentPlayerPoints;

            if (tempPoints>currentPlayerPoints)
            {
                yourHighscoreTextBox.Text = tempPoints.ToString();
            }
            else if (tempPoints>currentPlayerPoints)
            {
                yourHighscoreTextBox.Text = currentPlayerPoints.ToString();
            }
            else
            {
                yourHighscoreTextBox.Text = currentPlayerPoints.ToString();
            }
            welcomeUserTextBox.Text = "Hej, "+ tempUsername + "!";
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginForm().Show();
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            //if(tempPoints>tempNewHighscore)
            //{
            //    this.Hide();
            //    new GameForm(tempUsername, tempPoints).Show();
            //}
            //else
            //{
                this.Hide();
               new GameForm(tempUsername, highscore).Show();
            
        }

        private void HighscoreButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new HighscorePageForm(tempUsername, highscore).Show();
        }
    }
}
