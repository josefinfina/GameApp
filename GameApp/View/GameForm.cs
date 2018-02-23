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
    public partial class GameForm : Form
    {
        Controll controller = new Controll();
        Question currentQuestion;
        public static int currentSum = 0;
        public int timeLeft;
        string currentPlayerUsername = LoginForm.currentPlayerUsername;
        int currentPlayerPoints = LoginForm.currentPlayerPoints;
        int highschore = 0;
        public int buttonColor = 0;

        public GameForm(string currentPlayerUsername, int currentPlayerPoints)

        {
            InitializeComponent();
            
            FindQuestionAndPrint();
            currentSum = 0;
            timeLeft = 30;
            buttonColor = 1;
            timer.Start();
        }

        private void FindQuestionAndPrint()
        {
            this.currentQuestion = controller.FindQuestion();
            questionTextBox.Text = this.currentQuestion.questTxt+".";
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft--;
                tickingTimeLabel.Text = timeLeft.ToString();
            }

            if (timeLeft == 0)
            {
                timer.Stop();

                Plays pl = controller.FindPlayerInTblPlays(currentPlayerUsername);
                Plays plays = controller.FindPlayerPoints(pl);
                highschore = plays.points;

                this.Hide();
                new ScoreForm(currentSum, currentPlayerUsername, highschore).Show();
            }
        }
        private bool CheckAnswer(bool answer)
        {
            bool correctAnswer;
            if (this.currentQuestion.answer == "0")
            {
                correctAnswer = true;
            }
            else
            {
                correctAnswer = false;
            }
            bool isCorrect = answer == correctAnswer;
            return isCorrect;
        }
        private void AnswerTrueButton_Click(object sender, EventArgs e)
        {
            bool isCorrect = this.CheckAnswer(true);
            if (isCorrect == true)
            {
                currentSum += 3;
            }
            FindQuestionAndPrint();
            answerFalseButton.BackColor = Color.CadetBlue;

            Control ctrl = ((Control)sender);

            {
                if (isCorrect)
                {
                    ctrl.BackColor = Color.Green;
                    buttonColorTimer.Start();
                }
                else
                {
                    ctrl.BackColor = Color.Red;
                    buttonColorTimer.Start();
                }
            }
        }
        private void AnswerFalseButton_Click(object sender, EventArgs e)
        {
            bool isCorrect = this.CheckAnswer(false);
            if (isCorrect == false)
            {
                currentSum--;
            }
            FindQuestionAndPrint();
            Control ctrl = ((Control)sender);
            answerTrueButton.BackColor = Color.CadetBlue;

            {
                if (isCorrect)
                {
                    ctrl.BackColor = Color.Green;
                    buttonColorTimer.Start();
                }
                else
                {
                    ctrl.BackColor = Color.Red;
                    buttonColorTimer.Start();
                }
            }
        }
        private void QuitGameButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Plays pl = controller.FindPlayerInTblPlays(currentPlayerUsername);
            Plays plays = controller.FindPlayerPoints(pl);
            highschore = plays.points;

            new LoggedInForm(currentPlayerUsername, highschore).Show();
        }
        private void GameForm_Load(object sender, EventArgs e)
        {
            timer.Enabled = true;
            timer.Stop();
        }

        private void buttonColorTimer_Tick(object sender, EventArgs e)
        {
            buttonColorTimer.Stop();
            answerFalseButton.BackColor = Color.CadetBlue;
            answerTrueButton.BackColor = Color.CadetBlue;
        }
    }
}
