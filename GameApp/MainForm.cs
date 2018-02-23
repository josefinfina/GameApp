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
    public partial class MainForm : Form
    {
        public MainForm(int currentPlayerPoints)
        {
            InitializeComponent();
            playerHighcoreLabel.Text = currentPlayerPoints.ToString();

        }
    

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginForm().Show();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new GameForm().Show();

        }

        private void highscoreButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new HighscorePageForm().Show();
        }

        

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void playerHighcoreLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
