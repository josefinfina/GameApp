namespace GameQuiz.View
{
    partial class GameForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.answerFalseButton = new System.Windows.Forms.Button();
            this.answerTrueButton = new System.Windows.Forms.Button();
            this.timeLeftLabel = new System.Windows.Forms.Label();
            this.quitGameButton = new System.Windows.Forms.Button();
            this.questionTextBox = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.tickingTimeLabel = new System.Windows.Forms.Label();
            this.questionsPanel = new System.Windows.Forms.Panel();
            this.buttonColorTimer = new System.Windows.Forms.Timer(this.components);
            this.questionsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // answerFalseButton
            // 
            this.answerFalseButton.BackColor = System.Drawing.Color.CadetBlue;
            this.answerFalseButton.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerFalseButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.answerFalseButton.Location = new System.Drawing.Point(369, 307);
            this.answerFalseButton.Margin = new System.Windows.Forms.Padding(2);
            this.answerFalseButton.Name = "answerFalseButton";
            this.answerFalseButton.Size = new System.Drawing.Size(195, 98);
            this.answerFalseButton.TabIndex = 2;
            this.answerFalseButton.Text = "FALSKT";
            this.answerFalseButton.UseVisualStyleBackColor = false;
            this.answerFalseButton.Click += new System.EventHandler(this.AnswerFalseButton_Click);
            // 
            // answerTrueButton
            // 
            this.answerTrueButton.BackColor = System.Drawing.Color.CadetBlue;
            this.answerTrueButton.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerTrueButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.answerTrueButton.Location = new System.Drawing.Point(82, 307);
            this.answerTrueButton.Margin = new System.Windows.Forms.Padding(2);
            this.answerTrueButton.Name = "answerTrueButton";
            this.answerTrueButton.Size = new System.Drawing.Size(194, 98);
            this.answerTrueButton.TabIndex = 3;
            this.answerTrueButton.Text = "SANT";
            this.answerTrueButton.UseVisualStyleBackColor = false;
            this.answerTrueButton.Click += new System.EventHandler(this.AnswerTrueButton_Click);
            // 
            // timeLeftLabel
            // 
            this.timeLeftLabel.AutoSize = true;
            this.timeLeftLabel.BackColor = System.Drawing.Color.Transparent;
            this.timeLeftLabel.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLeftLabel.ForeColor = System.Drawing.Color.White;
            this.timeLeftLabel.Location = new System.Drawing.Point(280, 33);
            this.timeLeftLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timeLeftLabel.Name = "timeLeftLabel";
            this.timeLeftLabel.Size = new System.Drawing.Size(79, 23);
            this.timeLeftLabel.TabIndex = 4;
            this.timeLeftLabel.Text = "Tid kvar:";
            // 
            // quitGameButton
            // 
            this.quitGameButton.BackColor = System.Drawing.Color.DarkCyan;
            this.quitGameButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitGameButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.quitGameButton.Location = new System.Drawing.Point(558, 13);
            this.quitGameButton.Margin = new System.Windows.Forms.Padding(2);
            this.quitGameButton.Name = "quitGameButton";
            this.quitGameButton.Size = new System.Drawing.Size(86, 34);
            this.quitGameButton.TabIndex = 5;
            this.quitGameButton.Text = "Avbryt spel";
            this.quitGameButton.UseVisualStyleBackColor = false;
            this.quitGameButton.Click += new System.EventHandler(this.QuitGameButton_Click);
            // 
            // questionTextBox
            // 
            this.questionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.questionTextBox.BackColor = System.Drawing.Color.White;
            this.questionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.questionTextBox.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionTextBox.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.questionTextBox.Location = new System.Drawing.Point(14, 63);
            this.questionTextBox.Multiline = true;
            this.questionTextBox.Name = "questionTextBox";
            this.questionTextBox.Size = new System.Drawing.Size(459, 106);
            this.questionTextBox.TabIndex = 6;
            this.questionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // tickingTimeLabel
            // 
            this.tickingTimeLabel.AutoSize = true;
            this.tickingTimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.tickingTimeLabel.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tickingTimeLabel.ForeColor = System.Drawing.Color.White;
            this.tickingTimeLabel.Location = new System.Drawing.Point(299, 57);
            this.tickingTimeLabel.Name = "tickingTimeLabel";
            this.tickingTimeLabel.Size = new System.Drawing.Size(44, 33);
            this.tickingTimeLabel.TabIndex = 7;
            this.tickingTimeLabel.Text = "30";
            // 
            // questionsPanel
            // 
            this.questionsPanel.BackColor = System.Drawing.Color.White;
            this.questionsPanel.Controls.Add(this.questionTextBox);
            this.questionsPanel.Location = new System.Drawing.Point(82, 107);
            this.questionsPanel.Name = "questionsPanel";
            this.questionsPanel.Size = new System.Drawing.Size(482, 168);
            this.questionsPanel.TabIndex = 8;
            // 
            // buttonColorTimer
            // 
            this.buttonColorTimer.Tick += new System.EventHandler(this.buttonColorTimer_Tick);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(658, 458);
            this.Controls.Add(this.questionsPanel);
            this.Controls.Add(this.tickingTimeLabel);
            this.Controls.Add(this.quitGameButton);
            this.Controls.Add(this.timeLeftLabel);
            this.Controls.Add(this.answerTrueButton);
            this.Controls.Add(this.answerFalseButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GameForm";
            this.Text = "Quizzy";
            this.questionsPanel.ResumeLayout(false);
            this.questionsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button answerFalseButton;
        private System.Windows.Forms.Button answerTrueButton;
        private System.Windows.Forms.Label timeLeftLabel;
        private System.Windows.Forms.Button quitGameButton;
        private System.Windows.Forms.TextBox questionTextBox;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label tickingTimeLabel;
        private System.Windows.Forms.Panel questionsPanel;
        private System.Windows.Forms.Timer buttonColorTimer;
    }
}