namespace EmailDatabaseTable
{
    partial class SettingsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtServerIp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDatabaseUserId = new System.Windows.Forms.TextBox();
            this.txtDatabasePassword = new System.Windows.Forms.TextBox();
            this.txtSenderEmailPassword = new System.Windows.Forms.TextBox();
            this.txtSenderEmailId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtReceiverEmailId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Database Server IP";
            // 
            // txtServerIp
            // 
            this.txtServerIp.Location = new System.Drawing.Point(219, 19);
            this.txtServerIp.Name = "txtServerIp";
            this.txtServerIp.Size = new System.Drawing.Size(220, 20);
            this.txtServerIp.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Database User ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Database Password";
            // 
            // txtDatabaseUserId
            // 
            this.txtDatabaseUserId.Location = new System.Drawing.Point(219, 53);
            this.txtDatabaseUserId.Name = "txtDatabaseUserId";
            this.txtDatabaseUserId.Size = new System.Drawing.Size(220, 20);
            this.txtDatabaseUserId.TabIndex = 4;
            // 
            // txtDatabasePassword
            // 
            this.txtDatabasePassword.Location = new System.Drawing.Point(219, 90);
            this.txtDatabasePassword.Name = "txtDatabasePassword";
            this.txtDatabasePassword.Size = new System.Drawing.Size(220, 20);
            this.txtDatabasePassword.TabIndex = 5;
            this.txtDatabasePassword.UseSystemPasswordChar = true;
            // 
            // txtSenderEmailPassword
            // 
            this.txtSenderEmailPassword.Location = new System.Drawing.Point(220, 165);
            this.txtSenderEmailPassword.Name = "txtSenderEmailPassword";
            this.txtSenderEmailPassword.Size = new System.Drawing.Size(219, 20);
            this.txtSenderEmailPassword.TabIndex = 9;
            this.txtSenderEmailPassword.UseSystemPasswordChar = true;
            // 
            // txtSenderEmailId
            // 
            this.txtSenderEmailId.Location = new System.Drawing.Point(220, 128);
            this.txtSenderEmailId.Name = "txtSenderEmailId";
            this.txtSenderEmailId.Size = new System.Drawing.Size(219, 20);
            this.txtSenderEmailId.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sender Email Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Sender Email ID";
            // 
            // txtReceiverEmailId
            // 
            this.txtReceiverEmailId.Location = new System.Drawing.Point(221, 199);
            this.txtReceiverEmailId.Name = "txtReceiverEmailId";
            this.txtReceiverEmailId.Size = new System.Drawing.Size(218, 20);
            this.txtReceiverEmailId.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Receiver Email ID";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(219, 296);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 350);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtReceiverEmailId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSenderEmailPassword);
            this.Controls.Add(this.txtSenderEmailId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDatabasePassword);
            this.Controls.Add(this.txtDatabaseUserId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtServerIp);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtServerIp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDatabaseUserId;
        private System.Windows.Forms.TextBox txtDatabasePassword;
        private System.Windows.Forms.TextBox txtSenderEmailPassword;
        private System.Windows.Forms.TextBox txtSenderEmailId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtReceiverEmailId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSave;
    }
}