namespace EmailDatabaseTable
{
    partial class SendEmailForm
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
            this.comboBoxSelectDatabase = new System.Windows.Forms.ComboBox();
            this.comboBoxSelectTable = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSendEmail = new System.Windows.Forms.Button();
            this.btnGoToSettings = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxSelectDate = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboBoxSelectDatabase
            // 
            this.comboBoxSelectDatabase.FormattingEnabled = true;
            this.comboBoxSelectDatabase.Location = new System.Drawing.Point(251, 44);
            this.comboBoxSelectDatabase.Name = "comboBoxSelectDatabase";
            this.comboBoxSelectDatabase.Size = new System.Drawing.Size(266, 21);
            this.comboBoxSelectDatabase.TabIndex = 0;
            this.comboBoxSelectDatabase.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectDatabase_SelectedIndexChanged);
            // 
            // comboBoxSelectTable
            // 
            this.comboBoxSelectTable.FormattingEnabled = true;
            this.comboBoxSelectTable.Location = new System.Drawing.Point(251, 89);
            this.comboBoxSelectTable.Name = "comboBoxSelectTable";
            this.comboBoxSelectTable.Size = new System.Drawing.Size(266, 21);
            this.comboBoxSelectTable.TabIndex = 1;
            this.comboBoxSelectTable.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectTable_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Database";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select Table";
            // 
            // btnSendEmail
            // 
            this.btnSendEmail.Location = new System.Drawing.Point(331, 220);
            this.btnSendEmail.Name = "btnSendEmail";
            this.btnSendEmail.Size = new System.Drawing.Size(75, 23);
            this.btnSendEmail.TabIndex = 4;
            this.btnSendEmail.Text = "Send Email";
            this.btnSendEmail.UseVisualStyleBackColor = true;
            this.btnSendEmail.Click += new System.EventHandler(this.btnSendEmail_Click);
            // 
            // btnGoToSettings
            // 
            this.btnGoToSettings.Location = new System.Drawing.Point(107, 220);
            this.btnGoToSettings.Name = "btnGoToSettings";
            this.btnGoToSettings.Size = new System.Drawing.Size(83, 23);
            this.btnGoToSettings.TabIndex = 5;
            this.btnGoToSettings.Text = "Go to Settings";
            this.btnGoToSettings.UseVisualStyleBackColor = true;
            this.btnGoToSettings.Click += new System.EventHandler(this.btnGoToSettings_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Select Date";
            // 
            // comboBoxSelectDate
            // 
            this.comboBoxSelectDate.FormattingEnabled = true;
            this.comboBoxSelectDate.Location = new System.Drawing.Point(251, 129);
            this.comboBoxSelectDate.Name = "comboBoxSelectDate";
            this.comboBoxSelectDate.Size = new System.Drawing.Size(266, 21);
            this.comboBoxSelectDate.TabIndex = 7;
            // 
            // SendEmailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 314);
            this.Controls.Add(this.comboBoxSelectDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGoToSettings);
            this.Controls.Add(this.btnSendEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxSelectTable);
            this.Controls.Add(this.comboBoxSelectDatabase);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "SendEmailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Send Email";
            this.Load += new System.EventHandler(this.SendEmailForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSelectDatabase;
        private System.Windows.Forms.ComboBox comboBoxSelectTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSendEmail;
        private System.Windows.Forms.Button btnGoToSettings;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxSelectDate;
    }
}

