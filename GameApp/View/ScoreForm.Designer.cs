namespace GameQuiz.View
{
    partial class ScoreForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScoreForm));
            this.gameScoreLabel = new System.Windows.Forms.Label();
            this.playAgainButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.yourHighscoreTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // gameScoreLabel
            // 
            this.gameScoreLabel.AutoSize = true;
            this.gameScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.gameScoreLabel.Font = new System.Drawing.Font("Bahnschrift SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameScoreLabel.ForeColor = System.Drawing.Color.White;
            this.gameScoreLabel.Location = new System.Drawing.Point(234, 132);
            this.gameScoreLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gameScoreLabel.Name = "gameScoreLabel";
            this.gameScoreLabel.Size = new System.Drawing.Size(154, 33);
            this.gameScoreLabel.TabIndex = 1;
            this.gameScoreLabel.Text = "Dina poäng:";
            // 
            // playAgainButton
            // 
            this.playAgainButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.playAgainButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playAgainButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.playAgainButton.Location = new System.Drawing.Point(110, 230);
            this.playAgainButton.Margin = new System.Windows.Forms.Padding(2);
            this.playAgainButton.Name = "playAgainButton";
            this.playAgainButton.Size = new System.Drawing.Size(177, 76);
            this.playAgainButton.TabIndex = 2;
            this.playAgainButton.Text = "SPELA IGEN!";
            this.playAgainButton.UseVisualStyleBackColor = false;
            this.playAgainButton.Click += new System.EventHandler(this.PlayAgainButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BackButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackButton.Location = new System.Drawing.Point(332, 230);
            this.BackButton.Margin = new System.Windows.Forms.Padding(2);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(177, 76);
            this.BackButton.TabIndex = 3;
            this.BackButton.Text = "TILLBAKA";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // yourHighscoreTextbox
            // 
            this.yourHighscoreTextbox.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yourHighscoreTextbox.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.yourHighscoreTextbox.Location = new System.Drawing.Point(257, 171);
            this.yourHighscoreTextbox.Name = "yourHighscoreTextbox";
            this.yourHighscoreTextbox.Size = new System.Drawing.Size(105, 40);
            this.yourHighscoreTextbox.TabIndex = 4;
            this.yourHighscoreTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(632, 463);
            this.Controls.Add(this.yourHighscoreTextbox);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.playAgainButton);
            this.Controls.Add(this.gameScoreLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ScoreForm";
            this.Text = "HighscoreForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label gameScoreLabel;
        private System.Windows.Forms.Button playAgainButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.TextBox yourHighscoreTextbox;
    }
}