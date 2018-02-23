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
    public partial class ScoreForm : Form
 
    {
        Controller controller = new Controller();
        int currentPlayerPoints = 0;
        //int sum = 0;


        public ScoreForm(int sum)
        {
            InitializeComponent();
            highscoreLabel.Text = sum.ToString();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            //sum = currentPlayerPoints;
            new MainForm(currentPlayerPoints).Show();
        }

        private void playAgainButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new GameForm().Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void highscoreLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void ScoreForm_Load(object sender, EventArgs e)
        {

        }
    }
}
