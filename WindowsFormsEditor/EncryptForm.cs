using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsEditor
{
	public partial class EncryptForm : Form
	{
		bool isMailSent = false;
		public EncryptForm(byte[] encryptionKey, byte[] encryptionIV)
		{
			InitializeComponent();

			select_accountComboBox.SelectedIndex = 0;
			this.encryptionKeyTextBox.Text = Convert.ToBase64String(encryptionKey); 
			this.encryptionIVTextBox.Text = Convert.ToBase64String(encryptionIV);  
		}

		private void confirmBtn_Click(object sender, EventArgs e)
		{
			if (sendToEmailCheckBob.Checked)
			{
				if (!ValidateEmail(emailTextBox.Text) || string.IsNullOrWhiteSpace(email_passwordTextBox.Text))
				{
					MessageBox.Show("Invalid data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else
				{
					confirmBtn.Enabled = false;
					try
					{
						SendEmail();
						MessageBox.Show("Mail sent successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
						isMailSent = true;
					}
					catch (Exception)
					{
						MessageBox.Show("Mail was not sent. Check your credentials.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}

					confirmBtn.Enabled = true;
				}
			}
			else
			{
				this.Close();
			}
		}

		public bool ValidateEmail(string email)
		{
			try
			{
				MailAddress emailAddress = new MailAddress(email);
				return true;
			}
			catch
			{
				return false;
			}
		}

		private void SendEmail()
		{
			MailMessage mail = new MailMessage();
			SmtpClient SmtpServer;
			if (select_accountComboBox.SelectedIndex == 0)
			{
				SmtpServer = new SmtpClient("smtp.live.com");
			}
			else
			{
				SmtpServer = new SmtpClient("smtp.gmail.com");
			}

			mail.From = new MailAddress(emailTextBox.Text);
			mail.To.Add(emailTextBox.Text);
			mail.Subject = email_subjectTextBox.Text;
			mail.Body = "Key: " + encryptionKeyTextBox.Text + "\nIV: " + encryptionIVTextBox.Text;

			SmtpServer.Port = 587;
			SmtpServer.Credentials = new System.Net.NetworkCredential(emailTextBox.Text, email_passwordTextBox.Text);
			SmtpServer.EnableSsl = true;
			SmtpServer.Send(mail);
		}

		private void sendToEmailCheckBob_CheckedChanged(object sender, EventArgs e)
		{
			if (sendToEmailCheckBob.Checked)
			{
				SetContentToTrue();
			}
			else
			{
				SetContentToFalse();
			}
		}

		public void SetContentToTrue()
		{
			emailTextBox.Enabled = true;
			email_passwordTextBox.Enabled = true;
			email_subjectTextBox.Enabled = true;
			select_accountComboBox.Enabled = true;
			confirmBtn.Text = "Send";
		}

		public void SetContentToFalse()
		{
			emailTextBox.Enabled = false;
			email_passwordTextBox.Enabled = false;
			email_subjectTextBox.Enabled = false;
			select_accountComboBox.Enabled = false;
			confirmBtn.Text = "OK";
		}

		private void EncryptForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (isMailSent == false)
			{
				if (MessageBox.Show("Are you sure you don't want to recieve an email?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
				{
					e.Cancel = false;
				}
				else
				{
					e.Cancel = true;
				}
			}
		}



	}
}
