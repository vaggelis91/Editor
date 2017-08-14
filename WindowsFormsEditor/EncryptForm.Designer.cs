namespace WindowsFormsEditor
{
	partial class EncryptForm
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
			this.passwordKeyLbl = new System.Windows.Forms.Label();
			this.encryptionKeyTextBox = new System.Windows.Forms.TextBox();
			this.confirmBtn = new System.Windows.Forms.Button();
			this.sendToEmailCheckBob = new System.Windows.Forms.CheckBox();
			this.encryptionIVTextBox = new System.Windows.Forms.TextBox();
			this.ivLbl = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.email_passwordTextBox = new System.Windows.Forms.TextBox();
			this.emailTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.select_accountComboBox = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.email_subjectTextBox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// passwordKeyLbl
			// 
			this.passwordKeyLbl.AutoSize = true;
			this.passwordKeyLbl.Location = new System.Drawing.Point(18, 34);
			this.passwordKeyLbl.Name = "passwordKeyLbl";
			this.passwordKeyLbl.Size = new System.Drawing.Size(78, 13);
			this.passwordKeyLbl.TabIndex = 0;
			this.passwordKeyLbl.Text = "Encryption Key";
			// 
			// encryptionKeyTextBox
			// 
			this.encryptionKeyTextBox.Location = new System.Drawing.Point(102, 31);
			this.encryptionKeyTextBox.Name = "encryptionKeyTextBox";
			this.encryptionKeyTextBox.ReadOnly = true;
			this.encryptionKeyTextBox.Size = new System.Drawing.Size(222, 20);
			this.encryptionKeyTextBox.TabIndex = 1;
			// 
			// confirmBtn
			// 
			this.confirmBtn.Location = new System.Drawing.Point(279, 250);
			this.confirmBtn.Name = "confirmBtn";
			this.confirmBtn.Size = new System.Drawing.Size(56, 23);
			this.confirmBtn.TabIndex = 2;
			this.confirmBtn.Text = "Send";
			this.confirmBtn.UseVisualStyleBackColor = true;
			this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
			// 
			// sendToEmailCheckBob
			// 
			this.sendToEmailCheckBob.AutoSize = true;
			this.sendToEmailCheckBob.Checked = true;
			this.sendToEmailCheckBob.CheckState = System.Windows.Forms.CheckState.Checked;
			this.sendToEmailCheckBob.Location = new System.Drawing.Point(102, 88);
			this.sendToEmailCheckBob.Name = "sendToEmailCheckBob";
			this.sendToEmailCheckBob.Size = new System.Drawing.Size(93, 17);
			this.sendToEmailCheckBob.TabIndex = 3;
			this.sendToEmailCheckBob.Text = "Send to e-mail";
			this.sendToEmailCheckBob.UseVisualStyleBackColor = true;
			this.sendToEmailCheckBob.CheckedChanged += new System.EventHandler(this.sendToEmailCheckBob_CheckedChanged);
			// 
			// encryptionIVTextBox
			// 
			this.encryptionIVTextBox.Location = new System.Drawing.Point(102, 57);
			this.encryptionIVTextBox.Name = "encryptionIVTextBox";
			this.encryptionIVTextBox.ReadOnly = true;
			this.encryptionIVTextBox.Size = new System.Drawing.Size(222, 20);
			this.encryptionIVTextBox.TabIndex = 6;
			// 
			// ivLbl
			// 
			this.ivLbl.AutoSize = true;
			this.ivLbl.Location = new System.Drawing.Point(26, 60);
			this.ivLbl.Name = "ivLbl";
			this.ivLbl.Size = new System.Drawing.Size(70, 13);
			this.ivLbl.TabIndex = 7;
			this.ivLbl.Text = "Encryption IV";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(64, 126);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 13);
			this.label1.TabIndex = 8;
			this.label1.Text = "Email";
			// 
			// email_passwordTextBox
			// 
			this.email_passwordTextBox.Location = new System.Drawing.Point(102, 149);
			this.email_passwordTextBox.Name = "email_passwordTextBox";
			this.email_passwordTextBox.Size = new System.Drawing.Size(150, 20);
			this.email_passwordTextBox.TabIndex = 9;
			// 
			// emailTextBox
			// 
			this.emailTextBox.Location = new System.Drawing.Point(102, 123);
			this.emailTextBox.Name = "emailTextBox";
			this.emailTextBox.Size = new System.Drawing.Size(150, 20);
			this.emailTextBox.TabIndex = 10;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(43, 152);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 13);
			this.label2.TabIndex = 11;
			this.label2.Text = "Password";
			// 
			// select_accountComboBox
			// 
			this.select_accountComboBox.FormattingEnabled = true;
			this.select_accountComboBox.Items.AddRange(new object[] {
            "Hotmail",
            "Gmail"});
			this.select_accountComboBox.Location = new System.Drawing.Point(102, 201);
			this.select_accountComboBox.Name = "select_accountComboBox";
			this.select_accountComboBox.Size = new System.Drawing.Size(101, 21);
			this.select_accountComboBox.TabIndex = 12;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(16, 204);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 13);
			this.label3.TabIndex = 13;
			this.label3.Text = "Select Account";
			// 
			// email_subjectTextBox
			// 
			this.email_subjectTextBox.Location = new System.Drawing.Point(102, 175);
			this.email_subjectTextBox.Name = "email_subjectTextBox";
			this.email_subjectTextBox.Size = new System.Drawing.Size(150, 20);
			this.email_subjectTextBox.TabIndex = 14;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(25, 178);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(71, 13);
			this.label4.TabIndex = 15;
			this.label4.Text = "Email Subject";
			// 
			// EncryptForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(347, 290);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.email_subjectTextBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.select_accountComboBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.emailTextBox);
			this.Controls.Add(this.email_passwordTextBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.ivLbl);
			this.Controls.Add(this.encryptionIVTextBox);
			this.Controls.Add(this.sendToEmailCheckBob);
			this.Controls.Add(this.confirmBtn);
			this.Controls.Add(this.encryptionKeyTextBox);
			this.Controls.Add(this.passwordKeyLbl);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "EncryptForm";
			this.RightToLeftLayout = true;
			this.Text = "Encrypted File";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EncryptForm_FormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label passwordKeyLbl;
		private System.Windows.Forms.TextBox encryptionKeyTextBox;
		private System.Windows.Forms.Button confirmBtn;
		private System.Windows.Forms.CheckBox sendToEmailCheckBob;
		private System.Windows.Forms.TextBox encryptionIVTextBox;
		private System.Windows.Forms.Label ivLbl;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox email_passwordTextBox;
		private System.Windows.Forms.TextBox emailTextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox select_accountComboBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox email_subjectTextBox;
		private System.Windows.Forms.Label label4;
	}
}