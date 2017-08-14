using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsEditor
{
    public partial class ReplaceForm : Form
    {
		public static bool selectionMode;
		string richboxText;
		
		public ReplaceForm(string richboxSelectedText, string richboxText)
        {
            InitializeComponent();

			selectedTextBox.Text = richboxSelectedText;
			this.richboxText = richboxText;
		}

		public void replaceBtn_Click(object sender, EventArgs e)
        {
			if (replaceSelectedText_radioBtn.Checked && !string.IsNullOrEmpty(newTextBox.Text))
			{
				selectionMode = true;
				this.Close();
			}
			else if (replaceAll_radioBtn.Checked && !string.IsNullOrEmpty(newTextBox.Text))
			{
				selectionMode = false;
				this.Close();
			}
			else
			{
				MessageBox.Show("Set text to replace.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		public string ReplaceSelectedText()
		{
			if (string.IsNullOrEmpty(newTextBox.Text))
			{
				return newTextBox.Text = selectedTextBox.Text;
			}
			else
			{
				return newTextBox.Text;
			}			
		}

		public string ReplaceAllText()
		{
			if (string.IsNullOrEmpty(newTextBox.Text))
			{
				Regex r = new Regex(selectedTextBox.Text);
				return r.Replace(richboxText, selectedTextBox.Text);
			}
			else
			{
				Regex r = new Regex(selectedTextBox.Text);
				return r.Replace(richboxText, newTextBox.Text);
			}
		}


	}
}
