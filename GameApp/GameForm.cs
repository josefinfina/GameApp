using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameApp
{
    public partial class GameForm : Form
    {

        Controller controller = new Controller();
        
        public int timeLeft;
        private Question currentQuestion;
        int sum = 0;
        int currentPlayerPoints = 0;
        public int timeLeftTimer2;

        public GameForm()
        {
            InitializeComponent();

            FindQuestionAndPrint();
            
            timeLeft = 30;
            timer1.Start();
            timeLeftTimer2 = 1;
 

        }

        private void FindQuestionAndPrint()
        {
            this.currentQuestion = controller.FindQuestion();
            questionTextBox.Text = this.currentQuestion.questTxt;
         
        }

        private bool checkAnswer(bool answer)
        {
            bool correctAnswer;

            if (this.currentQuestion.answer == "0")
            {
                correctAnswer = true;
            } else
            {
                correctAnswer = false;
            }
            bool isCorrect = answer == correctAnswer;
            return isCorrect;

        }

        private void QuitGameButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainForm(currentPlayerPoints).Show();
        }

        private void timeLeftLabel_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft--;
                timeLeftLabel.Text = timeLeft.ToString();
            }

            if (timeLeft == 0)
            {
                timer1.Stop();
                this.Hide();
                new ScoreForm(sum).Show();
            }

        }

        private void answerTrueButton_Click(object sender, EventArgs e)
        {
            bool isCorrect = this.checkAnswer(true);
            if (isCorrect == true)
            {
                sum+=3;
            }
            
            FindQuestionAndPrint();

            answerFalseButton.BackColor = Color.CadetBlue;

            Control ctrl = ((Control)sender);
            
            {
                if (isCorrect)
                {
                    ctrl.BackColor = Color.Green;
                    timer2.Start();
                    
                }
                else
                {
                    ctrl.BackColor = Color.Red;
                    timer2.Start();
                }

                

            }
        }

        private void answerFalseButton_Click(object sender, EventArgs e)
        {
            bool isCorrect = this.checkAnswer(false);
            if (isCorrect == false)
            {
                sum--;
            }
            
            FindQuestionAndPrint();
            
           
            Control ctrl = ((Control)sender);

            answerTrueButton.BackColor = Color.CadetBlue;
            {
                if (isCorrect)
                { 
                    ctrl.BackColor = Color.Green;
                    timer2.Start();
                }
                else
                {
                    ctrl.BackColor = Color.Red;
                    timer2.Start();
                }   
            }
        }

        private void questionTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            answerFalseButton.BackColor = Color.CadetBlue;
            answerTrueButton.BackColor = Color.CadetBlue;
        }
    }

}
