namespace GameQuiz.View
{
    partial class WSOne
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WSOne));
            this.returnFileTextBox = new System.Windows.Forms.TextBox();
            this.goBackButton = new System.Windows.Forms.Button();
            this.searchFileTextBox = new System.Windows.Forms.TextBox();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.findFileButton = new System.Windows.Forms.Button();
            this.searchFilePanel = new System.Windows.Forms.Panel();
            this.searchFileLabel = new System.Windows.Forms.Label();
            this.searchFilePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // returnFileTextBox
            // 
            this.returnFileTextBox.Location = new System.Drawing.Point(106, 124);
            this.returnFileTextBox.Multiline = true;
            this.returnFileTextBox.Name = "returnFileTextBox";
            this.returnFileTextBox.Size = new System.Drawing.Size(235, 111);
            this.returnFileTextBox.TabIndex = 0;
            // 
            // goBackButton
            // 
            this.goBackButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.goBackButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goBackButton.ForeColor = System.Drawing.Color.White;
            this.goBackButton.Location = new System.Drawing.Point(290, 320);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(147, 61);
            this.goBackButton.TabIndex = 1;
            this.goBackButton.Text = "Tillbaka";
            this.goBackButton.UseVisualStyleBackColor = false;
            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
            // 
            // searchFileTextBox
            // 
            this.searchFileTextBox.Location = new System.Drawing.Point(106, 82);
            this.searchFileTextBox.Name = "searchFileTextBox";
            this.searchFileTextBox.Size = new System.Drawing.Size(120, 20);
            this.searchFileTextBox.TabIndex = 2;
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.fileNameLabel.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileNameLabel.ForeColor = System.Drawing.Color.White;
            this.fileNameLabel.Location = new System.Drawing.Point(46, 84);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(57, 16);
            this.fileNameLabel.TabIndex = 3;
            this.fileNameLabel.Text = "Filnamn:";
            // 
            // findFileButton
            // 
            this.findFileButton.BackColor = System.Drawing.Color.Gray;
            this.findFileButton.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findFileButton.ForeColor = System.Drawing.Color.White;
            this.findFileButton.Location = new System.Drawing.Point(249, 77);
            this.findFileButton.Name = "findFileButton";
            this.findFileButton.Size = new System.Drawing.Size(92, 29);
            this.findFileButton.TabIndex = 4;
            this.findFileButton.Text = "Hämta";
            this.findFileButton.UseVisualStyleBackColor = false;
            this.findFileButton.Click += new System.EventHandler(this.findFileButton_Click);
            // 
            // searchFilePanel
            // 
            this.searchFilePanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.searchFilePanel.Controls.Add(this.searchFileLabel);
            this.searchFilePanel.Controls.Add(this.returnFileTextBox);
            this.searchFilePanel.Controls.Add(this.findFileButton);
            this.searchFilePanel.Controls.Add(this.searchFileTextBox);
            this.searchFilePanel.Controls.Add(this.fileNameLabel);
            this.searchFilePanel.Location = new System.Drawing.Point(40, 31);
            this.searchFilePanel.Name = "searchFilePanel";
            this.searchFilePanel.Size = new System.Drawing.Size(397, 275);
            this.searchFilePanel.TabIndex = 5;
            this.searchFilePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // searchFileLabel
            // 
            this.searchFileLabel.AutoSize = true;
            this.searchFileLabel.Font = new System.Drawing.Font("Bahnschrift SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchFileLabel.ForeColor = System.Drawing.Color.White;
            this.searchFileLabel.Location = new System.Drawing.Point(136, 24);
            this.searchFileLabel.Name = "searchFileLabel";
            this.searchFileLabel.Size = new System.Drawing.Size(135, 29);
            this.searchFileLabel.TabIndex = 5;
            this.searchFileLabel.Text = "Sök efter fil";
            // 
            // WSOne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(479, 403);
            this.Controls.Add(this.searchFilePanel);
            this.Controls.Add(this.goBackButton);
            this.Name = "WSOne";
            this.Text = "Web Services";
            this.searchFilePanel.ResumeLayout(false);
            this.searchFilePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox returnFileTextBox;
        private System.Windows.Forms.Button goBackButton;
        private System.Windows.Forms.TextBox searchFileTextBox;
        private System.Windows.Forms.Label fileNameLabel;
        private System.Windows.Forms.Button findFileButton;
        private System.Windows.Forms.Panel searchFilePanel;
        private System.Windows.Forms.Label searchFileLabel;
    }
}