using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsEditor
{
	public partial class DecryptForm : Form
	{
		public static byte[] decryptionKey;
		public static byte[] decryptionIV;

		public DecryptForm()
		{
			InitializeComponent();
		}

		private void decryptBtn_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrWhiteSpace(keyTextBox.Text) || !string.IsNullOrWhiteSpace(ivTextBox.Text))
			{
				decryptionKey = Convert.FromBase64String(keyTextBox.Text);
				decryptionIV = Convert.FromBase64String(ivTextBox.Text);
				this.Close();
			}
			else
			{
				MessageBox.Show("Invalid data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}



	}
}
