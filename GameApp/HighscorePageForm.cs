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
    public partial class HighscorePageForm : Form
    {
        Controller controller = new Controller();
        int currentPlayerPoints = 0;
        


        public HighscorePageForm()
        {
            InitializeComponent();

            FindHighscoreAndPrint();

         
        }
        private void FindHighscoreAndPrint()
        {
            //List<Plays> FindHighscore = controller.FindHighscore();
            ////playersHighscoreTextBox.Text = FindHighscore.ToString();
        }

        private void backToStartButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainForm(currentPlayerPoints).Show();
        }

        

    

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
