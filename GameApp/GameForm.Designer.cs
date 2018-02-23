namespace GameApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.QuitGameButton = new System.Windows.Forms.Button();
            this.timeLeftLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.questionTextBox = new System.Windows.Forms.TextBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // answerFalseButton
            // 
            this.answerFalseButton.BackColor = System.Drawing.Color.CadetBlue;
            this.answerFalseButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerFalseButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.answerFalseButton.Location = new System.Drawing.Point(734, 630);
            this.answerFalseButton.Name = "answerFalseButton";
            this.answerFalseButton.Size = new System.Drawing.Size(390, 188);
            this.answerFalseButton.TabIndex = 2;
            this.answerFalseButton.Text = "FALSKT";
            this.answerFalseButton.UseVisualStyleBackColor = false;
            this.answerFalseButton.Click += new System.EventHandler(this.answerFalseButton_Click);
            // 
            // answerTrueButton
            // 
            this.answerTrueButton.BackColor = System.Drawing.Color.CadetBlue;
            this.answerTrueButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerTrueButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.answerTrueButton.Location = new System.Drawing.Point(164, 630);
            this.answerTrueButton.Name = "answerTrueButton";
            this.answerTrueButton.Size = new System.Drawing.Size(388, 188);
            this.answerTrueButton.TabIndex = 3;
            this.answerTrueButton.Text = "SANT";
            this.answerTrueButton.UseVisualStyleBackColor = false;
            this.answerTrueButton.Click += new System.EventHandler(this.answerTrueButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiLight", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(570, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 45);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tid kvar:";
            // 
            // QuitGameButton
            // 
            this.QuitGameButton.BackColor = System.Drawing.Color.CadetBlue;
            this.QuitGameButton.Font = new System.Drawing.Font("Bahnschrift", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuitGameButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.QuitGameButton.Location = new System.Drawing.Point(1115, 16);
            this.QuitGameButton.Name = "QuitGameButton";
            this.QuitGameButton.Size = new System.Drawing.Size(173, 65);
            this.QuitGameButton.TabIndex = 5;
            this.QuitGameButton.Text = "Avbryt spel";
            this.QuitGameButton.UseVisualStyleBackColor = false;
            this.QuitGameButton.Click += new System.EventHandler(this.QuitGameButton_Click);
            // 
            // timeLeftLabel
            // 
            this.timeLeftLabel.AutoSize = true;
            this.timeLeftLabel.BackColor = System.Drawing.Color.Transparent;
            this.timeLeftLabel.Font = new System.Drawing.Font("Bahnschrift SemiLight", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLeftLabel.ForeColor = System.Drawing.Color.Teal;
            this.timeLeftLabel.Location = new System.Drawing.Point(617, 93);
            this.timeLeftLabel.Name = "timeLeftLabel";
            this.timeLeftLabel.Size = new System.Drawing.Size(60, 45);
            this.timeLeftLabel.TabIndex = 6;
            this.timeLeftLabel.Text = "30";
            this.timeLeftLabel.Click += new System.EventHandler(this.timeLeftLabel_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // questionTextBox
            // 
            this.questionTextBox.BackColor = System.Drawing.Color.Teal;
            this.questionTextBox.Font = new System.Drawing.Font("Bahnschrift Light", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionTextBox.ForeColor = System.Drawing.Color.White;
            this.questionTextBox.Location = new System.Drawing.Point(164, 194);
            this.questionTextBox.Multiline = true;
            this.questionTextBox.Name = "questionTextBox";
            this.questionTextBox.Size = new System.Drawing.Size(960, 398);
            this.questionTextBox.TabIndex = 7;
            this.questionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.questionTextBox.TextChanged += new System.EventHandler(this.questionTextBox_TextChanged);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-3, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(228, 187);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1316, 920);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.questionTextBox);
            this.Controls.Add(this.timeLeftLabel);
            this.Controls.Add(this.QuitGameButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.answerTrueButton);
            this.Controls.Add(this.answerFalseButton);
            this.Name = "GameForm";
            this.Text = "GameForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button answerFalseButton;
        private System.Windows.Forms.Button answerTrueButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button QuitGameButton;
        private System.Windows.Forms.Label timeLeftLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox questionTextBox;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}