namespace GameApp
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.playerHighscoreLabel = new System.Windows.Forms.Label();
            this.playButton = new System.Windows.Forms.Button();
            this.highscoreButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.playerHighcoreLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // playerHighscoreLabel
            // 
            this.playerHighscoreLabel.AutoSize = true;
            this.playerHighscoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.playerHighscoreLabel.Font = new System.Drawing.Font("Bahnschrift Light", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerHighscoreLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.playerHighscoreLabel.Location = new System.Drawing.Point(154, 52);
            this.playerHighscoreLabel.Name = "playerHighscoreLabel";
            this.playerHighscoreLabel.Size = new System.Drawing.Size(295, 52);
            this.playerHighscoreLabel.TabIndex = 0;
            this.playerHighscoreLabel.Text = "Ditt highscore:";
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.CadetBlue;
            this.playButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.playButton.Location = new System.Drawing.Point(163, 222);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(248, 85);
            this.playButton.TabIndex = 2;
            this.playButton.Text = "SPELA!";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // highscoreButton
            // 
            this.highscoreButton.BackColor = System.Drawing.Color.CadetBlue;
            this.highscoreButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highscoreButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.highscoreButton.Location = new System.Drawing.Point(163, 345);
            this.highscoreButton.Name = "highscoreButton";
            this.highscoreButton.Size = new System.Drawing.Size(248, 85);
            this.highscoreButton.TabIndex = 3;
            this.highscoreButton.Text = "HIGHSCORE";
            this.highscoreButton.UseVisualStyleBackColor = false;
            this.highscoreButton.Click += new System.EventHandler(this.highscoreButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.CadetBlue;
            this.logoutButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.logoutButton.Location = new System.Drawing.Point(163, 475);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(248, 85);
            this.logoutButton.TabIndex = 4;
            this.logoutButton.Text = "LOGGA UT";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiLight", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(232, 833);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(861, 45);
            this.label1.TabIndex = 5;
            this.label1.Text = "Du är nu inloggad! Tryck på SPELA för att köra igång!";
            // 
            // playerHighcoreLabel
            // 
            this.playerHighcoreLabel.AutoSize = true;
            this.playerHighcoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.playerHighcoreLabel.Font = new System.Drawing.Font("Bahnschrift Light", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerHighcoreLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.playerHighcoreLabel.Location = new System.Drawing.Point(264, 117);
            this.playerHighcoreLabel.Name = "playerHighcoreLabel";
            this.playerHighcoreLabel.Size = new System.Drawing.Size(57, 64);
            this.playerHighcoreLabel.TabIndex = 7;
            this.playerHighcoreLabel.Text = "0";
            this.playerHighcoreLabel.Click += new System.EventHandler(this.playerHighcoreLabel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.playButton);
            this.panel1.Controls.Add(this.playerHighcoreLabel);
            this.panel1.Controls.Add(this.highscoreButton);
            this.panel1.Controls.Add(this.logoutButton);
            this.panel1.Controls.Add(this.playerHighscoreLabel);
            this.panel1.Location = new System.Drawing.Point(363, 122);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(582, 676);
            this.panel1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-20, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(364, 310);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1311, 924);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label playerHighscoreLabel;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button highscoreButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label playerHighcoreLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}