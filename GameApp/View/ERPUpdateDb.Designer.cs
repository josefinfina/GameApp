namespace GameQuiz.View
{
    partial class ERPUpdateDb
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ERPUpdateDb));
            this.updateDatabasePanel = new System.Windows.Forms.Panel();
            this.deletePanel = new System.Windows.Forms.Panel();
            this.deleteEmployeeNoTextBox = new System.Windows.Forms.TextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.deleteEmployeeNoLabel = new System.Windows.Forms.Label();
            this.updateDatabaseLabel = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.addressLabel = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.employeeNoLabel = new System.Windows.Forms.Label();
            this.employeeNoTextBox = new System.Windows.Forms.TextBox();
            this.lastnameLabel = new System.Windows.Forms.Label();
            this.lastnameTextBox = new System.Windows.Forms.TextBox();
            this.firstnameLabel = new System.Windows.Forms.Label();
            this.firstnameTextBox = new System.Windows.Forms.TextBox();
            this.goBackButton = new System.Windows.Forms.Button();
            this.insertUpdatePanel = new System.Windows.Forms.Panel();
            this.deleteLabel = new System.Windows.Forms.Label();
            this.insertUpdateLabel = new System.Windows.Forms.Label();
            this.updateDatabasePanel.SuspendLayout();
            this.deletePanel.SuspendLayout();
            this.insertUpdatePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // updateDatabasePanel
            // 
            this.updateDatabasePanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.updateDatabasePanel.Controls.Add(this.insertUpdatePanel);
            this.updateDatabasePanel.Controls.Add(this.deletePanel);
            this.updateDatabasePanel.Controls.Add(this.updateDatabaseLabel);
            this.updateDatabasePanel.Location = new System.Drawing.Point(27, 25);
            this.updateDatabasePanel.Name = "updateDatabasePanel";
            this.updateDatabasePanel.Size = new System.Drawing.Size(579, 382);
            this.updateDatabasePanel.TabIndex = 0;
            // 
            // deletePanel
            // 
            this.deletePanel.BackColor = System.Drawing.Color.Gainsboro;
            this.deletePanel.Controls.Add(this.deleteLabel);
            this.deletePanel.Controls.Add(this.deleteEmployeeNoTextBox);
            this.deletePanel.Controls.Add(this.deleteButton);
            this.deletePanel.Controls.Add(this.deleteEmployeeNoLabel);
            this.deletePanel.Location = new System.Drawing.Point(359, 99);
            this.deletePanel.Name = "deletePanel";
            this.deletePanel.Size = new System.Drawing.Size(184, 248);
            this.deletePanel.TabIndex = 14;
            // 
            // deleteEmployeeNoTextBox
            // 
            this.deleteEmployeeNoTextBox.Location = new System.Drawing.Point(42, 93);
            this.deleteEmployeeNoTextBox.Name = "deleteEmployeeNoTextBox";
            this.deleteEmployeeNoTextBox.Size = new System.Drawing.Size(100, 20);
            this.deleteEmployeeNoTextBox.TabIndex = 12;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.DarkGray;
            this.deleteButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(49, 129);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(89, 33);
            this.deleteButton.TabIndex = 10;
            this.deleteButton.Text = "Radera";
            this.deleteButton.UseVisualStyleBackColor = false;
            // 
            // deleteEmployeeNoLabel
            // 
            this.deleteEmployeeNoLabel.AutoSize = true;
            this.deleteEmployeeNoLabel.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteEmployeeNoLabel.ForeColor = System.Drawing.Color.Black;
            this.deleteEmployeeNoLabel.Location = new System.Drawing.Point(54, 69);
            this.deleteEmployeeNoLabel.Name = "deleteEmployeeNoLabel";
            this.deleteEmployeeNoLabel.Size = new System.Drawing.Size(79, 14);
            this.deleteEmployeeNoLabel.TabIndex = 11;
            this.deleteEmployeeNoLabel.Text = "Employee No:";
            this.deleteEmployeeNoLabel.Click += new System.EventHandler(this.deleteEmployeeNoLabel_Click);
            // 
            // updateDatabaseLabel
            // 
            this.updateDatabaseLabel.AutoSize = true;
            this.updateDatabaseLabel.Font = new System.Drawing.Font("Bahnschrift SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateDatabaseLabel.ForeColor = System.Drawing.Color.White;
            this.updateDatabaseLabel.Location = new System.Drawing.Point(169, 40);
            this.updateDatabaseLabel.Name = "updateDatabaseLabel";
            this.updateDatabaseLabel.Size = new System.Drawing.Size(241, 33);
            this.updateDatabaseLabel.TabIndex = 13;
            this.updateDatabaseLabel.Text = "Uppdatera databas";
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.DarkGray;
            this.updateButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(156, 200);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(85, 28);
            this.updateButton.TabIndex = 9;
            this.updateButton.Text = "Uppdatera";
            this.updateButton.UseVisualStyleBackColor = false;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.DarkGray;
            this.addButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(156, 166);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(85, 28);
            this.addButton.TabIndex = 8;
            this.addButton.Text = "Lägg till";
            this.addButton.UseVisualStyleBackColor = false;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLabel.ForeColor = System.Drawing.Color.Black;
            this.addressLabel.Location = new System.Drawing.Point(66, 143);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(49, 13);
            this.addressLabel.TabIndex = 7;
            this.addressLabel.Text = "Address:";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(120, 140);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(121, 20);
            this.addressTextBox.TabIndex = 6;
            // 
            // employeeNoLabel
            // 
            this.employeeNoLabel.AutoSize = true;
            this.employeeNoLabel.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeNoLabel.ForeColor = System.Drawing.Color.Black;
            this.employeeNoLabel.Location = new System.Drawing.Point(41, 65);
            this.employeeNoLabel.Name = "employeeNoLabel";
            this.employeeNoLabel.Size = new System.Drawing.Size(73, 13);
            this.employeeNoLabel.TabIndex = 5;
            this.employeeNoLabel.Text = "Employee No:";
            this.employeeNoLabel.Click += new System.EventHandler(this.employeeNoLabel_Click);
            // 
            // employeeNoTextBox
            // 
            this.employeeNoTextBox.Location = new System.Drawing.Point(120, 62);
            this.employeeNoTextBox.Name = "employeeNoTextBox";
            this.employeeNoTextBox.Size = new System.Drawing.Size(121, 20);
            this.employeeNoTextBox.TabIndex = 4;
            // 
            // lastnameLabel
            // 
            this.lastnameLabel.AutoSize = true;
            this.lastnameLabel.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastnameLabel.ForeColor = System.Drawing.Color.Black;
            this.lastnameLabel.Location = new System.Drawing.Point(56, 117);
            this.lastnameLabel.Name = "lastnameLabel";
            this.lastnameLabel.Size = new System.Drawing.Size(61, 13);
            this.lastnameLabel.TabIndex = 3;
            this.lastnameLabel.Text = "Efternamn:";
            // 
            // lastnameTextBox
            // 
            this.lastnameTextBox.Location = new System.Drawing.Point(120, 114);
            this.lastnameTextBox.Name = "lastnameTextBox";
            this.lastnameTextBox.Size = new System.Drawing.Size(121, 20);
            this.lastnameTextBox.TabIndex = 2;
            // 
            // firstnameLabel
            // 
            this.firstnameLabel.AutoSize = true;
            this.firstnameLabel.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstnameLabel.ForeColor = System.Drawing.Color.Black;
            this.firstnameLabel.Location = new System.Drawing.Point(63, 91);
            this.firstnameLabel.Name = "firstnameLabel";
            this.firstnameLabel.Size = new System.Drawing.Size(53, 13);
            this.firstnameLabel.TabIndex = 1;
            this.firstnameLabel.Text = "Förnamn:";
            // 
            // firstnameTextBox
            // 
            this.firstnameTextBox.Location = new System.Drawing.Point(120, 88);
            this.firstnameTextBox.Name = "firstnameTextBox";
            this.firstnameTextBox.Size = new System.Drawing.Size(121, 20);
            this.firstnameTextBox.TabIndex = 0;
            // 
            // goBackButton
            // 
            this.goBackButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.goBackButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goBackButton.ForeColor = System.Drawing.Color.White;
            this.goBackButton.Location = new System.Drawing.Point(452, 420);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(156, 53);
            this.goBackButton.TabIndex = 1;
            this.goBackButton.Text = "Tillbaka";
            this.goBackButton.UseVisualStyleBackColor = false;
            this.goBackButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // insertUpdatePanel
            // 
            this.insertUpdatePanel.BackColor = System.Drawing.Color.Gainsboro;
            this.insertUpdatePanel.Controls.Add(this.insertUpdateLabel);
            this.insertUpdatePanel.Controls.Add(this.addButton);
            this.insertUpdatePanel.Controls.Add(this.firstnameTextBox);
            this.insertUpdatePanel.Controls.Add(this.firstnameLabel);
            this.insertUpdatePanel.Controls.Add(this.updateButton);
            this.insertUpdatePanel.Controls.Add(this.lastnameTextBox);
            this.insertUpdatePanel.Controls.Add(this.lastnameLabel);
            this.insertUpdatePanel.Controls.Add(this.addressLabel);
            this.insertUpdatePanel.Controls.Add(this.employeeNoTextBox);
            this.insertUpdatePanel.Controls.Add(this.addressTextBox);
            this.insertUpdatePanel.Controls.Add(this.employeeNoLabel);
            this.insertUpdatePanel.Location = new System.Drawing.Point(38, 99);
            this.insertUpdatePanel.Name = "insertUpdatePanel";
            this.insertUpdatePanel.Size = new System.Drawing.Size(295, 248);
            this.insertUpdatePanel.TabIndex = 15;
            this.insertUpdatePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.insertUpdatePanel_Paint);
            // 
            // deleteLabel
            // 
            this.deleteLabel.AutoSize = true;
            this.deleteLabel.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteLabel.ForeColor = System.Drawing.Color.Black;
            this.deleteLabel.Location = new System.Drawing.Point(25, 26);
            this.deleteLabel.Name = "deleteLabel";
            this.deleteLabel.Size = new System.Drawing.Size(137, 19);
            this.deleteLabel.TabIndex = 13;
            this.deleteLabel.Text = "Radera employee";
            this.deleteLabel.Click += new System.EventHandler(this.deleteLabel_Click);
            // 
            // insertUpdateLabel
            // 
            this.insertUpdateLabel.AutoSize = true;
            this.insertUpdateLabel.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertUpdateLabel.ForeColor = System.Drawing.Color.Black;
            this.insertUpdateLabel.Location = new System.Drawing.Point(19, 24);
            this.insertUpdateLabel.Name = "insertUpdateLabel";
            this.insertUpdateLabel.Size = new System.Drawing.Size(259, 19);
            this.insertUpdateLabel.TabIndex = 10;
            this.insertUpdateLabel.Text = "Lägg till eller uppdatera Employee";
            // 
            // ERPUpdateDb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(633, 486);
            this.Controls.Add(this.goBackButton);
            this.Controls.Add(this.updateDatabasePanel);
            this.Name = "ERPUpdateDb";
            this.Text = "CRONUS Databas";
            this.updateDatabasePanel.ResumeLayout(false);
            this.updateDatabasePanel.PerformLayout();
            this.deletePanel.ResumeLayout(false);
            this.deletePanel.PerformLayout();
            this.insertUpdatePanel.ResumeLayout(false);
            this.insertUpdatePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel updateDatabasePanel;
        private System.Windows.Forms.Label updateDatabaseLabel;
        private System.Windows.Forms.TextBox deleteEmployeeNoTextBox;
        private System.Windows.Forms.Label deleteEmployeeNoLabel;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Label employeeNoLabel;
        private System.Windows.Forms.TextBox employeeNoTextBox;
        private System.Windows.Forms.Label lastnameLabel;
        private System.Windows.Forms.TextBox lastnameTextBox;
        private System.Windows.Forms.Label firstnameLabel;
        private System.Windows.Forms.TextBox firstnameTextBox;
        private System.Windows.Forms.Button goBackButton;
        private System.Windows.Forms.Panel deletePanel;
        private System.Windows.Forms.Panel insertUpdatePanel;
        private System.Windows.Forms.Label insertUpdateLabel;
        private System.Windows.Forms.Label deleteLabel;
    }
}