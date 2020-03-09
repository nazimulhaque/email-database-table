using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmailDatabaseTable
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsValidFormFields())
            {
                // Save user settings data
                Properties.Settings.Default.DatabaseServerIp = txtServerIp.Text;
                Properties.Settings.Default.DatabaseUserId = txtDatabaseUserId.Text;
                Properties.Settings.Default.DatabaseUserPassword = txtDatabasePassword.Text;
                Properties.Settings.Default.SenderEmailId = txtSenderEmailId.Text;
                Properties.Settings.Default.SenderEmailPassword = txtSenderEmailPassword.Text;
                Properties.Settings.Default.ReceiverEmailId = txtReceiverEmailId.Text;
                Properties.Settings.Default.EmailSubject = txtEmailSubject.Text;
                Properties.Settings.Default.EmailMessage = txtEmailMessage.Text;
                Properties.Settings.Default.Save();

                SendEmailForm sendEmailForm = new SendEmailForm();
                this.Hide();
                sendEmailForm.ShowDialog();
                this.Close();
            }
        }
        bool IsValidFormFields()
        {
            try
            {
                if (!IsValidIpAddress(txtServerIp.Text))
                {
                    MessageBox.Show("Invalid IP address.");
                    return false;
                }
                else if (string.IsNullOrEmpty(txtDatabaseUserId.Text))
                {
                    MessageBox.Show("Database User ID cannot be empty.");
                    return false;
                }
                else if (string.IsNullOrEmpty(txtDatabasePassword.Text))
                {
                    MessageBox.Show("Database password cannot be empty.");
                    return false;
                }
                else if (!IsValidEmail(txtSenderEmailId.Text))
                {
                    MessageBox.Show("Sender E-mail ID is not valid.");
                    return false;
                }
                else if (!IsValidGmailId(txtSenderEmailId.Text))
                {
                    MessageBox.Show("Sender E-mail ID must be a Gmail ID.");
                    return false;
                }
                else if (string.IsNullOrEmpty(txtSenderEmailPassword.Text))
                {
                    MessageBox.Show("Sender E-mail password cannot be empty.");
                    return false;
                }
                else if (!IsValidEmail(txtReceiverEmailId.Text))
                {
                    MessageBox.Show("Receiver E-mail ID is not valid.");
                    return false;
                }
                else if (string.IsNullOrEmpty(txtEmailSubject.Text))
                {
                    MessageBox.Show("E-mail subject cannot be empty.");
                    return false;
                }
                else if (string.IsNullOrEmpty(txtEmailMessage.Text))
                {
                    MessageBox.Show("E-mail message cannot be empty.");
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        bool IsValidGmailId(string email)
        {
            return IsValidEmail(email) && email.Substring(email.Length - 10, 10).Equals("@gmail.com");
        }

        bool IsValidIpAddress(string input)
        {
            System.Net.IPAddress address;
            if (System.Net.IPAddress.TryParse(input, out address))
            {
                switch (address.AddressFamily)
                {
                    case System.Net.Sockets.AddressFamily.InterNetwork:
                        // we have IPv4
                        return true;
                    case System.Net.Sockets.AddressFamily.InterNetworkV6:
                        // we have IPv6
                        return true;
                    default:
                        // invalid
                        return false;
                }
            }
            return false;
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            if (!Properties.Settings.Default.DatabaseServerIp.ToString().Trim().Equals("BLANK"))
            {
                txtServerIp.Text = Properties.Settings.Default.DatabaseServerIp;
                txtDatabaseUserId.Text = Properties.Settings.Default.DatabaseUserId;
                txtDatabasePassword.Text = Properties.Settings.Default.DatabaseUserPassword;
                txtSenderEmailId.Text = Properties.Settings.Default.SenderEmailId;
                txtSenderEmailPassword.Text = Properties.Settings.Default.SenderEmailPassword;
                txtReceiverEmailId.Text = Properties.Settings.Default.ReceiverEmailId;
                txtEmailSubject.Text = Properties.Settings.Default.EmailSubject;
                txtEmailMessage.Text = Properties.Settings.Default.EmailMessage;
            }
        }
    }
}
