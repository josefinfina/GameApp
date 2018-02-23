namespace GameQuiz.View
{
    partial class LoggedInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoggedInForm));
            this.playerHighscoreLabel = new System.Windows.Forms.Label();
            this.playButton = new System.Windows.Forms.Button();
            this.highscoreButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.yourHighscorePanel = new System.Windows.Forms.Panel();
            this.yourHighscoreTextBox = new System.Windows.Forms.TextBox();
            this.smallLoggedInPanel = new System.Windows.Forms.Panel();
            this.welcomeUserTextBox = new System.Windows.Forms.TextBox();
            this.bigLoggedInPanel = new System.Windows.Forms.Panel();
            this.yourHighscorePanel.SuspendLayout();
            this.smallLoggedInPanel.SuspendLayout();
            this.bigLoggedInPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // playerHighscoreLabel
            // 
            this.playerHighscoreLabel.AutoSize = true;
            this.playerHighscoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.playerHighscoreLabel.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerHighscoreLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.playerHighscoreLabel.Location = new System.Drawing.Point(33, 19);
            this.playerHighscoreLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.playerHighscoreLabel.Name = "playerHighscoreLabel";
            this.playerHighscoreLabel.Size = new System.Drawing.Size(113, 19);
            this.playerHighscoreLabel.TabIndex = 0;
            this.playerHighscoreLabel.Text = "Ditt highscore:";
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.Orange;
            this.playButton.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.playButton.Location = new System.Drawing.Point(163, 19);
            this.playButton.Margin = new System.Windows.Forms.Padding(2);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(211, 92);
            this.playButton.TabIndex = 2;
            this.playButton.Text = "SPELA!";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // highscoreButton
            // 
            this.highscoreButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.highscoreButton.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highscoreButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.highscoreButton.Location = new System.Drawing.Point(308, 128);
            this.highscoreButton.Margin = new System.Windows.Forms.Padding(2);
            this.highscoreButton.Name = "highscoreButton";
            this.highscoreButton.Size = new System.Drawing.Size(173, 44);
            this.highscoreButton.TabIndex = 3;
            this.highscoreButton.Text = "TOPPLISTAN";
            this.highscoreButton.UseVisualStyleBackColor = false;
            this.highscoreButton.Click += new System.EventHandler(this.HighscoreButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.logoutButton.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.logoutButton.Location = new System.Drawing.Point(308, 189);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(2);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(173, 44);
            this.logoutButton.TabIndex = 4;
            this.logoutButton.Text = "LOGGA UT";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // yourHighscorePanel
            // 
            this.yourHighscorePanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.yourHighscorePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.yourHighscorePanel.Controls.Add(this.yourHighscoreTextBox);
            this.yourHighscorePanel.Controls.Add(this.playerHighscoreLabel);
            this.yourHighscorePanel.Location = new System.Drawing.Point(57, 128);
            this.yourHighscorePanel.Name = "yourHighscorePanel";
            this.yourHighscorePanel.Size = new System.Drawing.Size(173, 105);
            this.yourHighscorePanel.TabIndex = 6;
            // 
            // yourHighscoreTextBox
            // 
            this.yourHighscoreTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.yourHighscoreTextBox.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yourHighscoreTextBox.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.yourHighscoreTextBox.Location = new System.Drawing.Point(39, 46);
            this.yourHighscoreTextBox.Name = "yourHighscoreTextBox";
            this.yourHighscoreTextBox.Size = new System.Drawing.Size(100, 33);
            this.yourHighscoreTextBox.TabIndex = 1;
            this.yourHighscoreTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // smallLoggedInPanel
            // 
            this.smallLoggedInPanel.BackColor = System.Drawing.Color.CadetBlue;
            this.smallLoggedInPanel.Controls.Add(this.welcomeUserTextBox);
            this.smallLoggedInPanel.Location = new System.Drawing.Point(153, 51);
            this.smallLoggedInPanel.Name = "smallLoggedInPanel";
            this.smallLoggedInPanel.Size = new System.Drawing.Size(350, 79);
            this.smallLoggedInPanel.TabIndex = 10;
            // 
            // welcomeUserTextBox
            // 
            this.welcomeUserTextBox.BackColor = System.Drawing.Color.CadetBlue;
            this.welcomeUserTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.welcomeUserTextBox.Font = new System.Drawing.Font("Bahnschrift SemiLight", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeUserTextBox.ForeColor = System.Drawing.Color.White;
            this.welcomeUserTextBox.Location = new System.Drawing.Point(10, 23);
            this.welcomeUserTextBox.Name = "welcomeUserTextBox";
            this.welcomeUserTextBox.Size = new System.Drawing.Size(328, 35);
            this.welcomeUserTextBox.TabIndex = 0;
            this.welcomeUserTextBox.TabStop = false;
            this.welcomeUserTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bigLoggedInPanel
            // 
            this.bigLoggedInPanel.BackColor = System.Drawing.Color.CadetBlue;
            this.bigLoggedInPanel.Controls.Add(this.logoutButton);
            this.bigLoggedInPanel.Controls.Add(this.highscoreButton);
            this.bigLoggedInPanel.Controls.Add(this.playButton);
            this.bigLoggedInPanel.Controls.Add(this.yourHighscorePanel);
            this.bigLoggedInPanel.Location = new System.Drawing.Point(60, 152);
            this.bigLoggedInPanel.Name = "bigLoggedInPanel";
            this.bigLoggedInPanel.Size = new System.Drawing.Size(531, 251);
            this.bigLoggedInPanel.TabIndex = 11;
            // 
            // LoggedInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(632, 458);
            this.Controls.Add(this.bigLoggedInPanel);
            this.Controls.Add(this.smallLoggedInPanel);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LoggedInForm";
            this.Text = "Quizzy";
            this.yourHighscorePanel.ResumeLayout(false);
            this.yourHighscorePanel.PerformLayout();
            this.smallLoggedInPanel.ResumeLayout(false);
            this.smallLoggedInPanel.PerformLayout();
            this.bigLoggedInPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label playerHighscoreLabel;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button highscoreButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Panel yourHighscorePanel;
        private System.Windows.Forms.TextBox yourHighscoreTextBox;
        private System.Windows.Forms.Panel smallLoggedInPanel;
        private System.Windows.Forms.Panel bigLoggedInPanel;
        private System.Windows.Forms.TextBox welcomeUserTextBox;
    }
}