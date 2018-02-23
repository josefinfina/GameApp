using GameQuiz.Controller;
using GameQuiz.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GameQuiz
{
    public partial class LoginForm : Form
    {
        private WebReference.WebService proxy = new WebReference.WebService();
        Controll controller = new Controll();
        Player currentUser = null;
        public static int currentPlayerPoints = 0;
        public static string currentPlayerUsername = null;

        public LoginForm()
        {
            InitializeComponent();
            currentPlayerPoints = 0;
            currentPlayerUsername = null;
            passwordLoginTextBox.UseSystemPasswordChar = true;
            passwordRegTextBox.UseSystemPasswordChar = true;

        }

        public int SelectedTab
        {
            get { return tabControl.SelectedIndex; }
            set { tabControl.SelectedIndex = value; }
        }

        private void RegButton_Click(object sender, EventArgs e) 
        {
            regMessageTextBox.Text = "";
            loginMessageTextBox.Text = "";
            string username = usernameRegTextBox.Text;
            string password = passwordRegTextBox.Text;

            if (string.IsNullOrWhiteSpace(usernameRegTextBox.Text) || string.IsNullOrWhiteSpace(passwordRegTextBox.Text))
            {
                regMessageTextBox.Text = "Fältet för användarnamn eller lösenord är tomt.";
            }
            else
            {
                Player play = controller.FindPlayer(username, password);

                if (play != null)
                {
                    regMessageTextBox.Text = "Användarnamn är upptaget.";
                }
                else
                {
                    controller.AddPlayer(username, password);
                    controller.UpdateNewPlayerHighscore(username, 1, 1);

                    Plays pl = controller.FindPlayerInTblPlays(username);
                    Plays plays = controller.FindPlayerPoints(pl);
                    currentPlayerPoints = plays.points;
                    currentPlayerUsername = username;
                    this.Hide();

                    new View.LoggedInForm(username, currentPlayerPoints).Show();
                }
             
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            regMessageTextBox.Text = "";
            loginMessageTextBox.Text = "";
            string username = usernameTextBox.Text;
            string password = passwordLoginTextBox.Text;

            if (string.IsNullOrWhiteSpace(usernameTextBox.Text) || string.IsNullOrWhiteSpace(passwordLoginTextBox.Text))
            {
                loginMessageTextBox.Text = "Fältet för användarnamn eller lösenord är tomt.";
            }
            else
            {
                currentUser = controller.FindPlayer(username, password);
                if(currentUser == null)
                {
                    loginMessageTextBox.Text = "Användare kan inte hittas.";
                }
                else
                {
                    currentUser = controller.FindPlayer(username, password);
                    currentPlayerUsername = currentUser.Username;

                    Plays pl = controller.FindPlayerInTblPlays(username);
                    Plays plays = controller.FindPlayerPoints(pl);
                    currentPlayerPoints = plays.points;

                    this.Hide();
                    new View.LoggedInForm(currentPlayerUsername, currentPlayerPoints).Show();
                }
            }
        }

        private void passwordLoginCheckBox_CheckedChanged(object sender, EventArgs e) 
        {
             if (passwordLoginCheckBox.Checked)
            {
                passwordLoginTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                passwordLoginTextBox.UseSystemPasswordChar = true;
            }
        }

        private void RegCheckBox_CheckedChanged(object sender, EventArgs e) 
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


        //Web Services Page

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new View.WSTwo().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new View.WSOne().Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();

            new View.ERPCronusMetadata().Show();
        }

        private void FindEmployeeAndPrint()
        {
            proxy.FindEmployee();

            DataTable employee = proxy.FindEmployee();
            FindDataDataGridView.DataSource = proxy.FindEmployee();
        }

        private void FindEmployeeRelativeAndPrint()
        {
            proxy.FindEmployeeRelative();

            DataTable employeeRelative = proxy.FindEmployeeRelative();
            FindDataDataGridView.DataSource = proxy.FindEmployeeRelative();
        }

        private void FindSickestEmployeeAndPrint()
        {
            proxy.FindSickestEmployee();

            DataTable sickestEmployee = proxy.FindSickestEmployee();
            FindDataDataGridView.DataSource = proxy.FindSickestEmployee();
        }

        private void FindSickEmployeesYearAndPrint()
        {
            proxy.FindSickEmployeesYear();

            DataTable sickEmployees = proxy.FindSickEmployeesYear();
            FindDataDataGridView.DataSource = proxy.FindSickEmployeesYear();
        }

        private void findEmployeeButton_Click(object sender, EventArgs e)
        {
            FindEmployeeAndPrint();
        }

        private void findEmployeeRelativeButton_Click(object sender, EventArgs e)
        {
            FindEmployeeRelativeAndPrint();
        }

        private void sickestEmployeeButton_Click(object sender, EventArgs e)
        {
            FindSickestEmployeeAndPrint();
        }

        private void sickEmployees2004Button_Click(object sender, EventArgs e)
        {
            FindSickEmployeesYearAndPrint();
        }

        private void updateDatabaseButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new View.ERPUpdateDb().Show();
        }
    }
}
