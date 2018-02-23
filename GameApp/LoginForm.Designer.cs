namespace GameApp
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
            this.loginButton = new System.Windows.Forms.Button();
            this.regButton = new System.Windows.Forms.Button();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameRegLabel = new System.Windows.Forms.Label();
            this.passwordRegLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.message2Label = new System.Windows.Forms.Label();
            this.messageRegLabel = new System.Windows.Forms.Label();
            this.regMessageLabel = new System.Windows.Forms.Label();
            this.passwordRegCheckBox = new System.Windows.Forms.CheckBox();
            this.usernameRegTextBox = new System.Windows.Forms.TextBox();
            this.passwordRegTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.loginMessageLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passwordCheckBox = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.CadetBlue;
            this.loginButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loginButton.Location = new System.Drawing.Point(320, 173);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(217, 66);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "LOGGA IN";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // regButton
            // 
            this.regButton.BackColor = System.Drawing.Color.CadetBlue;
            this.regButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.regButton.Location = new System.Drawing.Point(250, 227);
            this.regButton.Name = "regButton";
            this.regButton.Size = new System.Drawing.Size(218, 66);
            this.regButton.TabIndex = 1;
            this.regButton.Text = "REGISTRERA";
            this.regButton.UseVisualStyleBackColor = false;
            this.regButton.Click += new System.EventHandler(this.regButton_Click_1);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Bahnschrift", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.usernameLabel.Location = new System.Drawing.Point(97, 38);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(198, 33);
            this.usernameLabel.TabIndex = 2;
            this.usernameLabel.Text = "Användarnamn";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Bahnschrift", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.passwordLabel.Location = new System.Drawing.Point(165, 109);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(130, 33);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Lösenord";
            // 
            // usernameRegLabel
            // 
            this.usernameRegLabel.AutoSize = true;
            this.usernameRegLabel.Font = new System.Drawing.Font("Bahnschrift", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameRegLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.usernameRegLabel.Location = new System.Drawing.Point(46, 100);
            this.usernameRegLabel.Name = "usernameRegLabel";
            this.usernameRegLabel.Size = new System.Drawing.Size(198, 33);
            this.usernameRegLabel.TabIndex = 4;
            this.usernameRegLabel.Text = "Användarnamn";
            // 
            // passwordRegLabel
            // 
            this.passwordRegLabel.AutoSize = true;
            this.passwordRegLabel.Font = new System.Drawing.Font("Bahnschrift", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordRegLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.passwordRegLabel.Location = new System.Drawing.Point(114, 164);
            this.passwordRegLabel.Name = "passwordRegLabel";
            this.passwordRegLabel.Size = new System.Drawing.Size(130, 33);
            this.passwordRegLabel.TabIndex = 5;
            this.passwordRegLabel.Text = "Lösenord";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(751, 737);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 31);
            this.textBox1.TabIndex = 6;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-7, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1292, 923);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1276, 876);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "PK";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.message2Label);
            this.panel2.Controls.Add(this.messageRegLabel);
            this.panel2.Controls.Add(this.usernameRegLabel);
            this.panel2.Controls.Add(this.regMessageLabel);
            this.panel2.Controls.Add(this.passwordRegLabel);
            this.panel2.Controls.Add(this.regButton);
            this.panel2.Controls.Add(this.passwordRegCheckBox);
            this.panel2.Controls.Add(this.usernameRegTextBox);
            this.panel2.Controls.Add(this.passwordRegTextBox);
            this.panel2.Location = new System.Drawing.Point(294, 503);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(688, 349);
            this.panel2.TabIndex = 17;
            // 
            // message2Label
            // 
            this.message2Label.AutoSize = true;
            this.message2Label.Font = new System.Drawing.Font("Bahnschrift", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.message2Label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.message2Label.Location = new System.Drawing.Point(194, 39);
            this.message2Label.Name = "message2Label";
            this.message2Label.Size = new System.Drawing.Size(283, 33);
            this.message2Label.TabIndex = 15;
            this.message2Label.Text = "Regristrera dig nedan!";
            // 
            // messageRegLabel
            // 
            this.messageRegLabel.AutoSize = true;
            this.messageRegLabel.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageRegLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.messageRegLabel.Location = new System.Drawing.Point(138, 0);
            this.messageRegLabel.Name = "messageRegLabel";
            this.messageRegLabel.Size = new System.Drawing.Size(401, 39);
            this.messageRegLabel.TabIndex = 10;
            this.messageRegLabel.Text = "Har du inte redan ett konto? ";
            this.messageRegLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // regMessageLabel
            // 
            this.regMessageLabel.AutoSize = true;
            this.regMessageLabel.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regMessageLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.regMessageLabel.Location = new System.Drawing.Point(253, 296);
            this.regMessageLabel.Name = "regMessageLabel";
            this.regMessageLabel.Size = new System.Drawing.Size(203, 33);
            this.regMessageLabel.TabIndex = 14;
            this.regMessageLabel.Text = "Felmeddelande";
            this.regMessageLabel.Visible = false;
            // 
            // passwordRegCheckBox
            // 
            this.passwordRegCheckBox.AutoSize = true;
            this.passwordRegCheckBox.Font = new System.Drawing.Font("Bahnschrift", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordRegCheckBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.passwordRegCheckBox.Location = new System.Drawing.Point(492, 166);
            this.passwordRegCheckBox.Name = "passwordRegCheckBox";
            this.passwordRegCheckBox.Size = new System.Drawing.Size(167, 29);
            this.passwordRegCheckBox.TabIndex = 12;
            this.passwordRegCheckBox.Text = "Visa lösenord";
            this.passwordRegCheckBox.UseVisualStyleBackColor = true;
            this.passwordRegCheckBox.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // usernameRegTextBox
            // 
            this.usernameRegTextBox.Location = new System.Drawing.Point(250, 100);
            this.usernameRegTextBox.Name = "usernameRegTextBox";
            this.usernameRegTextBox.Size = new System.Drawing.Size(218, 31);
            this.usernameRegTextBox.TabIndex = 8;
            // 
            // passwordRegTextBox
            // 
            this.passwordRegTextBox.Location = new System.Drawing.Point(250, 164);
            this.passwordRegTextBox.Name = "passwordRegTextBox";
            this.passwordRegTextBox.Size = new System.Drawing.Size(218, 31);
            this.passwordRegTextBox.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.usernameTextBox);
            this.panel1.Controls.Add(this.loginMessageLabel);
            this.panel1.Controls.Add(this.loginButton);
            this.panel1.Controls.Add(this.passwordTextBox);
            this.panel1.Controls.Add(this.passwordCheckBox);
            this.panel1.Controls.Add(this.usernameLabel);
            this.panel1.Controls.Add(this.passwordLabel);
            this.panel1.Location = new System.Drawing.Point(213, 183);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(839, 301);
            this.panel1.TabIndex = 16;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(319, 42);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(218, 31);
            this.usernameTextBox.TabIndex = 6;
            this.usernameTextBox.TextChanged += new System.EventHandler(this.usernameTextBox_TextChanged);
            // 
            // loginMessageLabel
            // 
            this.loginMessageLabel.AutoSize = true;
            this.loginMessageLabel.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginMessageLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.loginMessageLabel.Location = new System.Drawing.Point(325, 251);
            this.loginMessageLabel.Name = "loginMessageLabel";
            this.loginMessageLabel.Size = new System.Drawing.Size(203, 33);
            this.loginMessageLabel.TabIndex = 15;
            this.loginMessageLabel.Text = "Felmeddelande";
            this.loginMessageLabel.Visible = false;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(319, 109);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(218, 31);
            this.passwordTextBox.TabIndex = 7;
            // 
            // passwordCheckBox
            // 
            this.passwordCheckBox.AutoSize = true;
            this.passwordCheckBox.Font = new System.Drawing.Font("Bahnschrift", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordCheckBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.passwordCheckBox.Location = new System.Drawing.Point(554, 115);
            this.passwordCheckBox.Name = "passwordCheckBox";
            this.passwordCheckBox.Size = new System.Drawing.Size(171, 29);
            this.passwordCheckBox.TabIndex = 11;
            this.passwordCheckBox.Text = "Visa lösenord ";
            this.passwordCheckBox.UseVisualStyleBackColor = true;
            this.passwordCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(8, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1276, 876);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "WS";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(11, -20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(555, 197);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1275, 940);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.textBox1);
            this.DoubleBuffered = true;
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button regButton;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label usernameRegLabel;
        private System.Windows.Forms.Label passwordRegLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox passwordRegTextBox;
        private System.Windows.Forms.TextBox usernameRegTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label messageRegLabel;
        private System.Windows.Forms.CheckBox passwordCheckBox;
        private System.Windows.Forms.CheckBox passwordRegCheckBox;
        private System.Windows.Forms.Label regMessageLabel;
        private System.Windows.Forms.Label loginMessageLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label message2Label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}