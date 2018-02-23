namespace GameQuiz.View
{
    partial class WSTwo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WSTwo));
            this.highscoresDataGridView = new System.Windows.Forms.DataGridView();
            this.goBackButton = new System.Windows.Forms.Button();
            this.findHighscoresButton = new System.Windows.Forms.Button();
            this.getHighscoresPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.highscoresDataGridView)).BeginInit();
            this.getHighscoresPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // highscoresDataGridView
            // 
            this.highscoresDataGridView.AllowUserToAddRows = false;
            this.highscoresDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.highscoresDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.highscoresDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.highscoresDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.highscoresDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.highscoresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.highscoresDataGridView.Location = new System.Drawing.Point(81, 82);
            this.highscoresDataGridView.Name = "highscoresDataGridView";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.highscoresDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.highscoresDataGridView.RowHeadersVisible = false;
            this.highscoresDataGridView.Size = new System.Drawing.Size(247, 247);
            this.highscoresDataGridView.TabIndex = 0;
            // 
            // goBackButton
            // 
            this.goBackButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.goBackButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goBackButton.ForeColor = System.Drawing.Color.White;
            this.goBackButton.Location = new System.Drawing.Point(316, 396);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(126, 53);
            this.goBackButton.TabIndex = 1;
            this.goBackButton.Text = "Tillbaka";
            this.goBackButton.UseVisualStyleBackColor = false;
            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
            // 
            // findHighscoresButton
            // 
            this.findHighscoresButton.BackColor = System.Drawing.Color.Gray;
            this.findHighscoresButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findHighscoresButton.ForeColor = System.Drawing.Color.White;
            this.findHighscoresButton.Location = new System.Drawing.Point(103, 21);
            this.findHighscoresButton.Name = "findHighscoresButton";
            this.findHighscoresButton.Size = new System.Drawing.Size(199, 46);
            this.findHighscoresButton.TabIndex = 3;
            this.findHighscoresButton.Text = "Hämta alla highschores";
            this.findHighscoresButton.UseVisualStyleBackColor = false;
            this.findHighscoresButton.Click += new System.EventHandler(this.findHighscoresButton_Click);
            // 
            // getHighscoresPanel
            // 
            this.getHighscoresPanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.getHighscoresPanel.Controls.Add(this.highscoresDataGridView);
            this.getHighscoresPanel.Controls.Add(this.findHighscoresButton);
            this.getHighscoresPanel.Location = new System.Drawing.Point(46, 36);
            this.getHighscoresPanel.Name = "getHighscoresPanel";
            this.getHighscoresPanel.Size = new System.Drawing.Size(396, 352);
            this.getHighscoresPanel.TabIndex = 4;
            // 
            // WSTwo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(491, 469);
            this.Controls.Add(this.getHighscoresPanel);
            this.Controls.Add(this.goBackButton);
            this.Name = "WSTwo";
            this.Text = "Web Services";
            ((System.ComponentModel.ISupportInitialize)(this.highscoresDataGridView)).EndInit();
            this.getHighscoresPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView highscoresDataGridView;
        private System.Windows.Forms.Button goBackButton;
        private System.Windows.Forms.Button findHighscoresButton;
        private System.Windows.Forms.Panel getHighscoresPanel;
    }
}