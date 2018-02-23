namespace GameQuiz
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.loginButton = new System.Windows.Forms.Button();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameRegLabel = new System.Windows.Forms.Label();
            this.passwordRegLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.bigQuizzyLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.loginMessageTextBox = new System.Windows.Forms.TextBox();
            this.passwordLoginTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordLoginCheckBox = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.regMessageTextBox = new System.Windows.Forms.TextBox();
            this.registerLabel = new System.Windows.Forms.Label();
            this.dontHaveAnAccountLabel = new System.Windows.Forms.Label();
            this.passwordRegCheckBox = new System.Windows.Forms.CheckBox();
            this.passwordRegTextBox = new System.Windows.Forms.TextBox();
            this.regButton = new System.Windows.Forms.Button();
            this.usernameRegTextBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.taskTwoButton = new System.Windows.Forms.Button();
            this.taskOneButton = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.sickEmployees2004Button = new System.Windows.Forms.Button();
            this.sickestEmployeeButton = new System.Windows.Forms.Button();
            this.findEmployeeRelativeButton = new System.Windows.Forms.Button();
            this.infoEmployeesLabel = new System.Windows.Forms.Label();
            this.FindDataDataGridView = new System.Windows.Forms.DataGridView();
            this.findEmployeeButton = new System.Windows.Forms.Button();
            this.updateDatabaseButton = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FindDataDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.loginButton.Font = new System.Drawing.Font("Bahnschrift", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loginButton.Location = new System.Drawing.Point(274, 30);
            this.loginButton.Margin = new System.Windows.Forms.Padding(2);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(114, 38);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "LOGGA IN";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.Color.White;
            this.usernameLabel.Location = new System.Drawing.Point(41, 35);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(99, 16);
            this.usernameLabel.TabIndex = 2;
            this.usernameLabel.Text = "Användarnamn:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.Color.White;
            this.passwordLabel.Location = new System.Drawing.Point(75, 74);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(65, 16);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Lösenord:";
            // 
            // usernameRegLabel
            // 
            this.usernameRegLabel.AutoSize = true;
            this.usernameRegLabel.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameRegLabel.ForeColor = System.Drawing.Color.White;
            this.usernameRegLabel.Location = new System.Drawing.Point(32, 65);
            this.usernameRegLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.usernameRegLabel.Name = "usernameRegLabel";
            this.usernameRegLabel.Size = new System.Drawing.Size(92, 14);
            this.usernameRegLabel.TabIndex = 4;
            this.usernameRegLabel.Text = "Användarnamn:";
            // 
            // passwordRegLabel
            // 
            this.passwordRegLabel.AutoSize = true;
            this.passwordRegLabel.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordRegLabel.ForeColor = System.Drawing.Color.White;
            this.passwordRegLabel.Location = new System.Drawing.Point(62, 98);
            this.passwordRegLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passwordRegLabel.Name = "passwordRegLabel";
            this.passwordRegLabel.Size = new System.Drawing.Size(62, 14);
            this.passwordRegLabel.TabIndex = 5;
            this.passwordRegLabel.Text = "Lösenord:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(376, 383);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(52, 20);
            this.textBox1.TabIndex = 6;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(-4, 3);
            this.tabControl.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(647, 480);
            this.tabControl.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.bigQuizzyLabel);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(639, 451);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "PK";
            // 
            // bigQuizzyLabel
            // 
            this.bigQuizzyLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bigQuizzyLabel.BackColor = System.Drawing.Color.Transparent;
            this.bigQuizzyLabel.Font = new System.Drawing.Font("Bahnschrift", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigQuizzyLabel.ForeColor = System.Drawing.Color.White;
            this.bigQuizzyLabel.Location = new System.Drawing.Point(226, 25);
            this.bigQuizzyLabel.Name = "bigQuizzyLabel";
            this.bigQuizzyLabel.Size = new System.Drawing.Size(184, 60);
            this.bigQuizzyLabel.TabIndex = 15;
            this.bigQuizzyLabel.Text = "Quizzy!";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CadetBlue;
            this.panel2.Controls.Add(this.loginMessageTextBox);
            this.panel2.Controls.Add(this.passwordLoginTextBox);
            this.panel2.Controls.Add(this.usernameTextBox);
            this.panel2.Controls.Add(this.passwordLoginCheckBox);
            this.panel2.Controls.Add(this.passwordLabel);
            this.panel2.Controls.Add(this.loginButton);
            this.panel2.Controls.Add(this.usernameLabel);
            this.panel2.Location = new System.Drawing.Point(107, 95);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(415, 123);
            this.panel2.TabIndex = 14;
            // 
            // loginMessageTextBox
            // 
            this.loginMessageTextBox.BackColor = System.Drawing.Color.CadetBlue;
            this.loginMessageTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loginMessageTextBox.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginMessageTextBox.Location = new System.Drawing.Point(25, 100);
            this.loginMessageTextBox.Name = "loginMessageTextBox";
            this.loginMessageTextBox.Size = new System.Drawing.Size(357, 15);
            this.loginMessageTextBox.TabIndex = 15;
            this.loginMessageTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // passwordLoginTextBox
            // 
            this.passwordLoginTextBox.Font = new System.Drawing.Font("Bahnschrift Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLoginTextBox.Location = new System.Drawing.Point(140, 72);
            this.passwordLoginTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.passwordLoginTextBox.Name = "passwordLoginTextBox";
            this.passwordLoginTextBox.Size = new System.Drawing.Size(111, 22);
            this.passwordLoginTextBox.TabIndex = 7;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Font = new System.Drawing.Font("Bahnschrift Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextBox.Location = new System.Drawing.Point(140, 33);
            this.usernameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(111, 22);
            this.usernameTextBox.TabIndex = 6;
            // 
            // passwordLoginCheckBox
            // 
            this.passwordLoginCheckBox.AutoSize = true;
            this.passwordLoginCheckBox.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLoginCheckBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.passwordLoginCheckBox.Location = new System.Drawing.Point(258, 76);
            this.passwordLoginCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.passwordLoginCheckBox.Name = "passwordLoginCheckBox";
            this.passwordLoginCheckBox.Size = new System.Drawing.Size(93, 17);
            this.passwordLoginCheckBox.TabIndex = 11;
            this.passwordLoginCheckBox.Text = "Visa lösenord ";
            this.passwordLoginCheckBox.UseVisualStyleBackColor = true;
            this.passwordLoginCheckBox.CheckedChanged += new System.EventHandler(this.passwordLoginCheckBox_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.regMessageTextBox);
            this.panel1.Controls.Add(this.registerLabel);
            this.panel1.Controls.Add(this.dontHaveAnAccountLabel);
            this.panel1.Controls.Add(this.passwordRegCheckBox);
            this.panel1.Controls.Add(this.usernameRegLabel);
            this.panel1.Controls.Add(this.passwordRegLabel);
            this.panel1.Controls.Add(this.passwordRegTextBox);
            this.panel1.Controls.Add(this.regButton);
            this.panel1.Controls.Add(this.usernameRegTextBox);
            this.panel1.Location = new System.Drawing.Point(144, 236);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(345, 179);
            this.panel1.TabIndex = 13;
            // 
            // regMessageTextBox
            // 
            this.regMessageTextBox.BackColor = System.Drawing.Color.CadetBlue;
            this.regMessageTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.regMessageTextBox.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regMessageTextBox.Location = new System.Drawing.Point(3, 158);
            this.regMessageTextBox.Name = "regMessageTextBox";
            this.regMessageTextBox.Size = new System.Drawing.Size(339, 15);
            this.regMessageTextBox.TabIndex = 14;
            this.regMessageTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // registerLabel
            // 
            this.registerLabel.AutoSize = true;
            this.registerLabel.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerLabel.ForeColor = System.Drawing.Color.White;
            this.registerLabel.Location = new System.Drawing.Point(112, 32);
            this.registerLabel.Name = "registerLabel";
            this.registerLabel.Size = new System.Drawing.Size(128, 16);
            this.registerLabel.TabIndex = 13;
            this.registerLabel.Text = "Registrera dig nedan!";
            // 
            // dontHaveAnAccountLabel
            // 
            this.dontHaveAnAccountLabel.AutoSize = true;
            this.dontHaveAnAccountLabel.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dontHaveAnAccountLabel.ForeColor = System.Drawing.Color.White;
            this.dontHaveAnAccountLabel.Location = new System.Drawing.Point(104, 15);
            this.dontHaveAnAccountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dontHaveAnAccountLabel.Name = "dontHaveAnAccountLabel";
            this.dontHaveAnAccountLabel.Size = new System.Drawing.Size(149, 18);
            this.dontHaveAnAccountLabel.TabIndex = 10;
            this.dontHaveAnAccountLabel.Text = "Har du inte ett konto? ";
            // 
            // passwordRegCheckBox
            // 
            this.passwordRegCheckBox.AutoSize = true;
            this.passwordRegCheckBox.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordRegCheckBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.passwordRegCheckBox.Location = new System.Drawing.Point(241, 98);
            this.passwordRegCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.passwordRegCheckBox.Name = "passwordRegCheckBox";
            this.passwordRegCheckBox.Size = new System.Drawing.Size(91, 17);
            this.passwordRegCheckBox.TabIndex = 12;
            this.passwordRegCheckBox.Text = "Visa lösenord";
            this.passwordRegCheckBox.UseVisualStyleBackColor = true;
            this.passwordRegCheckBox.CheckedChanged += new System.EventHandler(this.RegCheckBox_CheckedChanged);
            // 
            // passwordRegTextBox
            // 
            this.passwordRegTextBox.Font = new System.Drawing.Font("Bahnschrift Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordRegTextBox.Location = new System.Drawing.Point(123, 94);
            this.passwordRegTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.passwordRegTextBox.Name = "passwordRegTextBox";
            this.passwordRegTextBox.Size = new System.Drawing.Size(111, 22);
            this.passwordRegTextBox.TabIndex = 9;
            // 
            // regButton
            // 
            this.regButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.regButton.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.regButton.Location = new System.Drawing.Point(120, 126);
            this.regButton.Margin = new System.Windows.Forms.Padding(2);
            this.regButton.Name = "regButton";
            this.regButton.Size = new System.Drawing.Size(117, 30);
            this.regButton.TabIndex = 1;
            this.regButton.Text = "REGISTRERA";
            this.regButton.UseVisualStyleBackColor = false;
            this.regButton.Click += new System.EventHandler(this.RegButton_Click);
            // 
            // usernameRegTextBox
            // 
            this.usernameRegTextBox.Font = new System.Drawing.Font("Bahnschrift Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameRegTextBox.Location = new System.Drawing.Point(123, 60);
            this.usernameRegTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.usernameRegTextBox.Name = "usernameRegTextBox";
            this.usernameRegTextBox.Size = new System.Drawing.Size(111, 22);
            this.usernameRegTextBox.TabIndex = 8;
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage2.BackgroundImage")));
            this.tabPage2.Controls.Add(this.taskTwoButton);
            this.tabPage2.Controls.Add(this.taskOneButton);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(639, 451);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "WS";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // taskTwoButton
            // 
            this.taskTwoButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.taskTwoButton.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskTwoButton.ForeColor = System.Drawing.Color.White;
            this.taskTwoButton.Location = new System.Drawing.Point(74, 164);
            this.taskTwoButton.Name = "taskTwoButton";
            this.taskTwoButton.Size = new System.Drawing.Size(217, 111);
            this.taskTwoButton.TabIndex = 2;
            this.taskTwoButton.Text = "Uppgift 1";
            this.taskTwoButton.UseVisualStyleBackColor = false;
            this.taskTwoButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // taskOneButton
            // 
            this.taskOneButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.taskOneButton.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskOneButton.ForeColor = System.Drawing.Color.White;
            this.taskOneButton.Location = new System.Drawing.Point(343, 164);
            this.taskOneButton.Name = "taskOneButton";
            this.taskOneButton.Size = new System.Drawing.Size(217, 111);
            this.taskOneButton.TabIndex = 1;
            this.taskOneButton.Text = "Uppgift 2";
            this.taskOneButton.UseVisualStyleBackColor = false;
            this.taskOneButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage3.BackgroundImage")));
            this.tabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage3.Controls.Add(this.updateDatabaseButton);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.panel4);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(639, 451);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "ERP";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(337, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 49);
            this.button1.TabIndex = 4;
            this.button1.Text = "Metadata";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel4.Controls.Add(this.sickEmployees2004Button);
            this.panel4.Controls.Add(this.sickestEmployeeButton);
            this.panel4.Controls.Add(this.findEmployeeRelativeButton);
            this.panel4.Controls.Add(this.infoEmployeesLabel);
            this.panel4.Controls.Add(this.FindDataDataGridView);
            this.panel4.Controls.Add(this.findEmployeeButton);
            this.panel4.Location = new System.Drawing.Point(31, 29);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(574, 336);
            this.panel4.TabIndex = 3;
            // 
            // sickEmployees2004Button
            // 
            this.sickEmployees2004Button.Location = new System.Drawing.Point(350, 269);
            this.sickEmployees2004Button.Name = "sickEmployees2004Button";
            this.sickEmployees2004Button.Size = new System.Drawing.Size(179, 29);
            this.sickEmployees2004Button.TabIndex = 9;
            this.sickEmployees2004Button.Text = "Sick Employees in 2004";
            this.sickEmployees2004Button.UseVisualStyleBackColor = true;
            this.sickEmployees2004Button.Click += new System.EventHandler(this.sickEmployees2004Button_Click);
            // 
            // sickestEmployeeButton
            // 
            this.sickestEmployeeButton.Location = new System.Drawing.Point(350, 211);
            this.sickestEmployeeButton.Name = "sickestEmployeeButton";
            this.sickestEmployeeButton.Size = new System.Drawing.Size(179, 29);
            this.sickestEmployeeButton.TabIndex = 8;
            this.sickestEmployeeButton.Text = "Sickest Employee";
            this.sickestEmployeeButton.UseVisualStyleBackColor = true;
            this.sickestEmployeeButton.Click += new System.EventHandler(this.sickestEmployeeButton_Click);
            // 
            // findEmployeeRelativeButton
            // 
            this.findEmployeeRelativeButton.Location = new System.Drawing.Point(350, 152);
            this.findEmployeeRelativeButton.Name = "findEmployeeRelativeButton";
            this.findEmployeeRelativeButton.Size = new System.Drawing.Size(179, 29);
            this.findEmployeeRelativeButton.TabIndex = 7;
            this.findEmployeeRelativeButton.Text = "Employee Relative";
            this.findEmployeeRelativeButton.UseVisualStyleBackColor = true;
            this.findEmployeeRelativeButton.Click += new System.EventHandler(this.findEmployeeRelativeButton_Click);
            // 
            // infoEmployeesLabel
            // 
            this.infoEmployeesLabel.AutoSize = true;
            this.infoEmployeesLabel.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoEmployeesLabel.ForeColor = System.Drawing.Color.White;
            this.infoEmployeesLabel.Location = new System.Drawing.Point(194, 33);
            this.infoEmployeesLabel.Name = "infoEmployeesLabel";
            this.infoEmployeesLabel.Size = new System.Drawing.Size(199, 33);
            this.infoEmployeesLabel.TabIndex = 6;
            this.infoEmployeesLabel.Text = "Employees Info";
            // 
            // FindDataDataGridView
            // 
            this.FindDataDataGridView.AllowUserToAddRows = false;
            this.FindDataDataGridView.AllowUserToDeleteRows = false;
            this.FindDataDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FindDataDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.FindDataDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.FindDataDataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FindDataDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.FindDataDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.FindDataDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.FindDataDataGridView.Location = new System.Drawing.Point(37, 93);
            this.FindDataDataGridView.Name = "FindDataDataGridView";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FindDataDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.FindDataDataGridView.RowHeadersVisible = false;
            this.FindDataDataGridView.Size = new System.Drawing.Size(288, 205);
            this.FindDataDataGridView.TabIndex = 5;
            // 
            // findEmployeeButton
            // 
            this.findEmployeeButton.Location = new System.Drawing.Point(350, 93);
            this.findEmployeeButton.Name = "findEmployeeButton";
            this.findEmployeeButton.Size = new System.Drawing.Size(179, 29);
            this.findEmployeeButton.TabIndex = 1;
            this.findEmployeeButton.Text = "Employee";
            this.findEmployeeButton.UseVisualStyleBackColor = true;
            this.findEmployeeButton.Click += new System.EventHandler(this.findEmployeeButton_Click);
            // 
            // updateDatabaseButton
            // 
            this.updateDatabaseButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.updateDatabaseButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateDatabaseButton.ForeColor = System.Drawing.Color.White;
            this.updateDatabaseButton.Location = new System.Drawing.Point(119, 382);
            this.updateDatabaseButton.Name = "updateDatabaseButton";
            this.updateDatabaseButton.Size = new System.Drawing.Size(194, 49);
            this.updateDatabaseButton.TabIndex = 5;
            this.updateDatabaseButton.Text = "Uppdatera databas";
            this.updateDatabaseButton.UseVisualStyleBackColor = false;
            this.updateDatabaseButton.Click += new System.EventHandler(this.updateDatabaseButton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(633, 479);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.textBox1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LoginForm";
            this.Text = "Quizzy";
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FindDataDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label usernameRegLabel;
        private System.Windows.Forms.Label passwordRegLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox passwordLoginTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label dontHaveAnAccountLabel;
        private System.Windows.Forms.CheckBox passwordLoginCheckBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label registerLabel;
        private System.Windows.Forms.Label bigQuizzyLabel;
        private System.Windows.Forms.TextBox loginMessageTextBox;
        private System.Windows.Forms.TextBox regMessageTextBox;
        private System.Windows.Forms.CheckBox passwordRegCheckBox;
        private System.Windows.Forms.TextBox passwordRegTextBox;
        private System.Windows.Forms.Button regButton;
        private System.Windows.Forms.TextBox usernameRegTextBox;
        private System.Windows.Forms.Button taskTwoButton;
        private System.Windows.Forms.Button taskOneButton;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button findEmployeeButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView FindDataDataGridView;
        private System.Windows.Forms.Label infoEmployeesLabel;
        private System.Windows.Forms.Button sickEmployees2004Button;
        private System.Windows.Forms.Button sickestEmployeeButton;
        private System.Windows.Forms.Button findEmployeeRelativeButton;
        private System.Windows.Forms.Button updateDatabaseButton;
    }
}

