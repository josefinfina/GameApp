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
    public partial class LoginForm : Form
    {
        Controller controller = new Controller();
        Player currentUser = new Player();
        Plays currentPlayer = new Plays();
        int currentPlayerPoints = 0;

        public LoginForm()

        {
            InitializeComponent();

            passwordRegTextBox.UseSystemPasswordChar = true;
            passwordTextBox.UseSystemPasswordChar = true;

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void regButton_Click_1(object sender, EventArgs e) //Lägger till en användare och tar dig vidare FUNGERAR
        {
            

            loginMessageLabel.Hide();
            string username = usernameRegTextBox.Text;
            string password = passwordRegTextBox.Text;

            if (string.IsNullOrWhiteSpace(usernameRegTextBox.Text) || string.IsNullOrWhiteSpace(passwordRegTextBox.Text))
            {
                regMessageLabel.Show();
            }
            else
            {
                Player play = controller.FindPlayers(username, password);
                if(play != null)
                {
                    regMessageLabel.Show();
                }
                else
                {
                regMessageLabel.Hide();
                controller.AddPlayer(username, password);
                this.Hide();
                new MainForm(currentPlayerPoints).Show();
                }
                
            }



        }

        private void loginButton_Click(object sender, EventArgs e) // Login, tar dig vidare om användarnman och lösenord matchas FUNGERAR
        {
            //passwordTextBox.PasswordChar = '*';
            //string username = usernameTextBox.Text;
            //string password = passwordTextBox.Text

            //controller.FindPlayers(username, password);

            //this.Hide();
            //new MainForm().Show();


            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            if (string.IsNullOrWhiteSpace(usernameTextBox.Text) || string.IsNullOrWhiteSpace(passwordTextBox.Text))
            {
                loginMessageLabel.Show();
            }
            else
            {
                currentUser = controller.FindPlayers(username, password);
                if (currentUser == null)
                {
                    loginMessageLabel.Show();
                }
                else
                { 
                    Plays player = controller.FindPlayerPoints(currentUser);
                    currentPlayerPoints = player.points;

                    loginMessageLabel.Hide();
                    Player play = controller.FindPlayers(username, password);
                    if (play != null)
                    {
                        this.Hide();

                        new MainForm(currentPlayerPoints).Show();
                    }
                    
                }
                

            }
        }

            private void checkBox1_CheckedChanged(object sender, EventArgs e) // döljer lösenordet FUNGERAR
        {
            if(passwordCheckBox.Checked)
            {
                passwordTextBox.UseSystemPasswordChar = false; 
            }
            else
            {
                passwordTextBox.UseSystemPasswordChar = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e) //döljer lösenordet FUNGERAR
        {
            if (passwordRegCheckBox.Checked)
            {
                passwordRegTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                passwordRegTextBox.UseSystemPasswordChar = true;
            }
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}

