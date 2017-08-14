using System;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.Threading;
using System.Security.Cryptography;

namespace WindowsFormsEditor
{
    public partial class Editor : Form
    {
		Dictionary<string, byte[]> decryptionFileKeyPairs = new Dictionary<string, byte[]>();
		Dictionary<string, byte[]> decryptionFileIVPairs = new Dictionary<string, byte[]>();

		List<string> searchTextList = new List<string>();
		List<string> historyFilePathList = new List<string>();
		
		public Editor()
        {
            InitializeComponent();          
        }

        private void Editor_Load(object sender, EventArgs e)
        {
			richBox.AllowDrop = true;
			this.richBox.DragDrop += new DragEventHandler(richBox_DragDrop);
		}

		//
		// FILE MENU SECTION
		//
		private void newMenuItem_Click(object sender, EventArgs e)
		{
			richBox.Clear();
			this.Text = "new - Editor";
		}

		private void fileOpen_Click(object sender, EventArgs e)
		{
			string fileToOpen = OpenDialog();
			if (!string.IsNullOrEmpty(fileToOpen))
			{
				OpenFile(fileToOpen);
				this.Text = Path.GetFileNameWithoutExtension(fileToOpen) + " - Editor";
				AddFilesToHistory(fileToOpen);
			}
		}

		private string OpenDialog()
		{
			OpenFileDialog openDialog = new OpenFileDialog();
			openDialog.Title = "Open File";
			openDialog.InitialDirectory = "C:\\";
			openDialog.Filter = "Rich Text Files (*.rtf)|*.rtf|Text Files (*.txt)|*.txt|CSV Files (*.csv)|*.csv|All Files (*.*)|*.*";
			string openFile = null;

			if (openDialog.ShowDialog() == DialogResult.OK)
			{
				return openFile = openDialog.FileName;
			}
			return openFile;
		}

		private void OpenFile(string fileToOpen)
		{
			try
			{
				if (Path.GetExtension(fileToOpen) == ".rtf")
				{
					richBox.LoadFile(fileToOpen, RichTextBoxStreamType.RichText);
				}
				else
				{
					richBox.LoadFile(fileToOpen, RichTextBoxStreamType.PlainText);
				}
			}
			catch (Exception)
			{
				MessageBox.Show("File can't be loaded.","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void fileSave_Click(object sender, EventArgs e)
		{
			//check if the file is currently open in the editor. If yes its the last item of the historyFilePathList. 
			if (historyFilePathList.Count > 0 && this.Text != "new - Editor")
			{
				string fileToSave = historyFilePathList.ElementAt(historyFilePathList.Count - 1);  

				if (Path.GetExtension(fileToSave) == ".rtf")
				{
					richBox.SaveFile(fileToSave, RichTextBoxStreamType.RichText);
				}
				else
				{
					richBox.SaveFile(fileToSave, RichTextBoxStreamType.PlainText);
				}
				fileSave.Enabled = false;
				iconSaveFileBtn.Enabled = false;
			}
			else if (this.Text == "new - Editor")
			{
				SaveAsFile();
			}
		}

		private void fileSaveAs_Click(object sender, EventArgs e)
		{
			SaveAsFile();
		}

		private void SaveAsFile()
		{
			string saveAsFile = SaveAsDialog();
			if (!string.IsNullOrEmpty(saveAsFile))
			{
				if (Path.GetExtension(saveAsFile) == ".rtf" || Path.GetExtension(saveAsFile) == ".odt")
				{
					richBox.SaveFile(saveAsFile, RichTextBoxStreamType.RichText);
				}
				else
				{
					richBox.SaveFile(saveAsFile, RichTextBoxStreamType.PlainText);
				}
				this.Text = Path.GetFileNameWithoutExtension(saveAsFile) + " - Editor";
			}
			AddFilesToHistory(saveAsFile);
		}

		private string SaveAsDialog()
		{
			SaveFileDialog saveDialog = new SaveFileDialog();
			saveDialog.Title = "Save As";
			saveDialog.InitialDirectory = "C:\\";
			saveDialog.Filter = "Rich Text (*.rtf)|*.rtf|Text File (*.txt)|*.txt|CSV Files (*.csv)|*.csv|Open Document (*.odt)|*.odt|All Files (*.*)|*.*";
			string saveAsFile = null;

			if (saveDialog.ShowDialog() == DialogResult.OK)
			{
				return saveAsFile = saveDialog.FileName;
			}
			return saveAsFile;
		}

		private void menuExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		//
		// RIGHT CLICK MENU 
		//
		private void copyMenuItem_Click(object sender, EventArgs e)
		{
			richBox.Copy();
		}

		private void cutMenuItem_Click(object sender, EventArgs e)
		{
			richBox.Cut();
		}

		private void pasteMenuItem_Click(object sender, EventArgs e)
		{
			richBox.Paste();
		}

		private void selectAllMenuItem_Click(object sender, EventArgs e)
		{
			richBox.SelectAll();
		}

		private void upperCaseMenuItem_Click(object sender, EventArgs e)
		{
			richBox.SelectedText = richBox.SelectedText.ToUpper();
		}

		private void lowerCaseMenuItem_Click(object sender, EventArgs e)
		{
			richBox.SelectedText = richBox.SelectedText.ToLower();
		}

		private void openLinkMenuItem_Click(object sender, EventArgs e)
		{
			ProcessStartInfo openLink = new ProcessStartInfo(richBox.SelectedText);
			try
			{
				Process.Start(openLink);
			}
			catch (Exception)
			{
				MessageBox.Show("Invalid link. Make sure you select the link first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		//
		// EDIT MENU SECTION
		//
		private void editClear_Click(object sender, EventArgs e)
		{
			richBox.Clear();
		}

		private void iconRedoBtn_Click(object sender, EventArgs e)
		{
			richBox.Redo();
		}

		private void iconUndoBtn_Click(object sender, EventArgs e)
		{
			richBox.Undo();
		}

		private void leftMenuItem_Click(object sender, EventArgs e)
		{
			richBox.SelectionAlignment = HorizontalAlignment.Left;
		}

		private void rightMenuItem_Click(object sender, EventArgs e)
		{
			richBox.SelectionAlignment = HorizontalAlignment.Right;
		}

		private void centerMenuItem_Click(object sender, EventArgs e)
		{
			richBox.SelectionAlignment = HorizontalAlignment.Center;
		}

		private void editDateTime_Click(object sender, EventArgs e)
		{
			DateTime date_time = DateTime.Now;
			richBox.AppendText(date_time.ToString());
		}

		//
		// TOOLBAR MENU SECTION
		//
		private void blackColorSelection_Click(object sender, EventArgs e)
		{
			richBox.SelectionColor = Color.Black;
		}

		private void blueColorSelection_Click(object sender, EventArgs e)
		{
			richBox.SelectionColor = Color.Blue;
		}

		private void redColorSelection_Click(object sender, EventArgs e)
		{
			richBox.SelectionColor = Color.Red;
		}

		private void orangeColorSelection_Click(object sender, EventArgs e)
		{
			richBox.SelectionColor = Color.Orange;
		}

		private void yellowColorSelection_Click(object sender, EventArgs e)
		{
			richBox.SelectionColor = Color.Yellow;
		}

		private void greenColorSelection_Click(object sender, EventArgs e)
		{
			richBox.SelectionColor = Color.Green;
		}

		private void fontTextBtn_Click(object sender, EventArgs e)
		{
			FontDialog fontDialog = new FontDialog();
			if (fontDialog.ShowDialog() == DialogResult.OK)
			{
				richBox.SelectionFont = new Font(fontDialog.Font.FontFamily.Name, fontDialog.Font.Size, fontDialog.Font.Style, GraphicsUnit.Point);
			}
		}

		private void boldBtn_Click(object sender, EventArgs e)
		{
			if (richBox.SelectionFont.Bold)
			{
				richBox.SelectionFont = new Font(richBox.SelectionFont, richBox.SelectionFont.Style & ~FontStyle.Bold);
			}
			else
			{
				richBox.SelectionFont = new Font(richBox.SelectionFont, richBox.SelectionFont.Style | FontStyle.Bold);
			}
		}

		private void italicBtn_Click(object sender, EventArgs e)
		{
			if (richBox.SelectionFont.Italic)
			{
				richBox.SelectionFont = new Font(richBox.SelectionFont, richBox.SelectionFont.Style & ~FontStyle.Italic);
			}
			else
			{
				richBox.SelectionFont = new Font(richBox.SelectionFont, richBox.SelectionFont.Style | FontStyle.Italic);
			}
		}

		private void underlineBtn_Click(object sender, EventArgs e)
		{
			if (richBox.SelectionFont.Underline)
			{
				richBox.SelectionFont = new System.Drawing.Font(richBox.SelectionFont, richBox.SelectionFont.Style & ~FontStyle.Underline);
			}
			else
			{
				richBox.SelectionFont = new System.Drawing.Font(richBox.SelectionFont, richBox.SelectionFont.Style | FontStyle.Underline);
			}
		}

		private void strikeoutBtn_Click(object sender, EventArgs e)
		{
			if (richBox.SelectionFont.Strikeout)
			{
				richBox.SelectionFont = new Font(richBox.SelectionFont, richBox.SelectionFont.Style & ~FontStyle.Strikeout);
			}
			else
			{
				richBox.SelectionFont = new Font(richBox.SelectionFont, richBox.SelectionFont.Style | FontStyle.Strikeout);
			}
		}

		private void highlightBtn_Click(object sender, EventArgs e)
		{
			//check if selected text is already highlated.  
			if (richBox.SelectionBackColor.Equals(Color.Gold))
			{
				richBox.SelectionBackColor = Color.White;
			}
			else
			{
				richBox.SelectionBackColor = Color.Gold;				
			}			
		}

		private void iconBulletBtn_Click(object sender, EventArgs e)
		{
			if (richBox.TextLength > 0)
			{
				if (!richBox.SelectionBullet)
				{
					richBox.SelectionBullet = true;
				}
				else
				{
					richBox.SelectionBullet = false;
				}
			}
		}

		private void replaceBtn_Click(object sender, EventArgs e)
		{
			if (richBox.SelectedText.Length > 0)
			{
				ReplaceForm replace_form = new ReplaceForm(richBox.SelectedText, richBox.Text);
				replace_form.ShowDialog();

				if (ReplaceForm.selectionMode == true)
				{
					richBox.SelectedText = replace_form.ReplaceSelectedText();
				}
				else 
				{
					richBox.Text = replace_form.ReplaceAllText();
				}
			}
			else
			{
				MessageBox.Show("First select the text to replace.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}		
		}

		private void searchBtn_Click(object sender, EventArgs e)
		{
			searchTextList.Add(searchTextBox.Text);
			DiselectPreviousMultipleText();
			SelectMultipleText();
		}

		private void DiselectPreviousMultipleText()
		{
			if (searchTextList.Count > 1)
			{
				string[] prevWords = searchTextList.ElementAt(searchTextList.Count - 2).Split(',');
				foreach (string word in prevWords)
				{
					int index = 0;
					string temp = richBox.Rtf;
					richBox.Rtf = "";
					richBox.Rtf = temp;
					while (index < richBox.Text.LastIndexOf(word))
					{
						richBox.Find(word, index, richBox.TextLength, RichTextBoxFinds.None);
						richBox.SelectionBackColor = Color.White;
						index = richBox.Text.IndexOf(word, index) + 1;
					}
				}
			}
		}

		private void SelectMultipleText()
		{
			string[] words = searchTextBox.Text.Split(',');
			foreach (string word in words)
			{
				int index = 0;
				string temp = richBox.Rtf;
				richBox.Rtf = "";
				richBox.Rtf = temp;
				while (index < richBox.Text.LastIndexOf(word))
				{
					richBox.Find(word, index, richBox.TextLength, RichTextBoxFinds.None);
					richBox.SelectionBackColor = Color.Tomato;
					index = richBox.Text.IndexOf(word, index) + 1;
				}
			}
		}

		//
		// RICHBOX
		//
		private void richBox_TextChanged(object sender, EventArgs e)
		{
			countLinesWordsLbl.Text = "Lines: " + CountLines().ToString() + " Words: " + CountWords().ToString();
			countLinesWordsLbl.Visible = true;			
			fileSave.Enabled = true;
			iconSaveFileBtn.Enabled = true;
		}

		private int CountWords()
		{
			MatchCollection wordCount = Regex.Matches(richBox.Text, @"[\s]+");
			int numberOfWords = 0;
			if (!string.IsNullOrEmpty(richBox.Text))
			{
				numberOfWords = wordCount.Count + 1;
			}
			return numberOfWords;
		}

		private int CountLines()
		{
			string[] lines = richBox.Lines;
			int numberOfLines = 0;
			foreach (string line in lines)
			{
				numberOfLines += 1;
			}
			return numberOfLines;
		}

		private void richBox_MouseLeave(object sender, EventArgs e)
		{
			countLinesWordsLbl.Visible = false;
		}

		//
		// VIEW MENU SECTION
		//
		private void AddFilesToHistory(string fullFilePath)
		{
			if (historyFilePathList.Contains(fullFilePath)) 
			{
				//reorder the items in the list.
				historyFilePathList.Remove(fullFilePath);
				historyFilePathList.Add(fullFilePath);		
			}
			else
			{
				historyFilePathList.Add(fullFilePath);
			}
			FillHistoryMenu();
		}

		private void FillHistoryMenu()
		{
			int limit = historyFilePathList.Count - 1;
			//loop through the list form the bottom to top item in order to get the five most recent items.
			for (int i = limit; i >= limit; i--)
			{
				if (i == limit)
				{
					slot1.Text = Path.GetFileNameWithoutExtension(historyFilePathList.ElementAt(i));
					slot1.Visible = true;
				}
				else if (i == limit - 1)
				{
					slot2.Text = Path.GetFileNameWithoutExtension(historyFilePathList.ElementAt(i));
					slot2.Visible = true;
				}
				else if (i == limit - 2)
				{
					slot3.Text = Path.GetFileNameWithoutExtension(historyFilePathList.ElementAt(i));
					slot3.Visible = true;
				}
				else if (i == limit - 3)
				{
					slot4.Text = Path.GetFileNameWithoutExtension(historyFilePathList.ElementAt(i));
					slot4.Visible = true;
				}
				else if (i == limit - 4)
				{
					slot5.Text = Path.GetFileNameWithoutExtension(historyFilePathList.ElementAt(i));
					slot5.Visible = true;
				}
				else 
				{
					break;
				}
			}
		}

		private void historySlot1_Click(object sender, EventArgs e)
		{
			if (Path.GetExtension(historyFilePathList.ElementAt(historyFilePathList.Count - 1)) == ".rtf")
			{
				richBox.LoadFile(historyFilePathList.ElementAt(historyFilePathList.Count - 1), RichTextBoxStreamType.RichText);
			}
			else
			{
				richBox.LoadFile(historyFilePathList.ElementAt(historyFilePathList.Count - 1), RichTextBoxStreamType.PlainText);
			}
			this.Text = Path.GetFileNameWithoutExtension(historyFilePathList.ElementAt(historyFilePathList.Count - 1)) + " - Editor";
		}

		private void historySlot2_Click(object sender, EventArgs e)
		{
			if (Path.GetExtension(historyFilePathList.ElementAt(historyFilePathList.Count - 2)) == ".rtf")
			{
				richBox.LoadFile(historyFilePathList.ElementAt(historyFilePathList.Count - 2), RichTextBoxStreamType.RichText);
			}
			else
			{
				richBox.LoadFile(historyFilePathList.ElementAt(historyFilePathList.Count - 2), RichTextBoxStreamType.PlainText);
			}
			this.Text = Path.GetFileNameWithoutExtension(historyFilePathList.ElementAt(historyFilePathList.Count - 2)) + " - Editor";
		}

		private void historySlot3_Click(object sender, EventArgs e)
		{
			if (Path.GetExtension(historyFilePathList.ElementAt(historyFilePathList.Count - 3)) == ".rtf")
			{
				richBox.LoadFile(historyFilePathList.ElementAt(historyFilePathList.Count - 3), RichTextBoxStreamType.RichText);
			}
			else
			{
				richBox.LoadFile(historyFilePathList.ElementAt(historyFilePathList.Count - 3), RichTextBoxStreamType.PlainText);
			}
			this.Text = Path.GetFileNameWithoutExtension(historyFilePathList.ElementAt(historyFilePathList.Count - 3)) + " - Editor";
		}

		private void historySlot4_Click(object sender, EventArgs e)
		{
			if (Path.GetExtension(historyFilePathList.ElementAt(historyFilePathList.Count - 4)) == ".rtf")
			{
				richBox.LoadFile(historyFilePathList.ElementAt(historyFilePathList.Count - 4), RichTextBoxStreamType.RichText);
			}
			else
			{
				richBox.LoadFile(historyFilePathList.ElementAt(historyFilePathList.Count - 4), RichTextBoxStreamType.PlainText);
			}
			this.Text = Path.GetFileNameWithoutExtension(historyFilePathList.ElementAt(historyFilePathList.Count - 4)) + " - Editor";
		}

		private void historySlot5_Click(object sender, EventArgs e)
		{
			if (Path.GetExtension(historyFilePathList.ElementAt(historyFilePathList.Count - 5)) == ".rtf")
			{
				richBox.LoadFile(historyFilePathList.ElementAt(historyFilePathList.Count - 5), RichTextBoxStreamType.RichText);
			}
			else
			{
				richBox.LoadFile(historyFilePathList.ElementAt(historyFilePathList.Count - 5), RichTextBoxStreamType.PlainText);
			}
			this.Text = Path.GetFileNameWithoutExtension(historyFilePathList.ElementAt(historyFilePathList.Count - 5)) + " - Editor";
		}

		//
		// OPTIONS MENU SECCTION
		//
		private void recogniseUrl_Click(object sender, EventArgs e)
		{
			if (richBox.DetectUrls == false)
			{
				richBox.DetectUrls = true;
			}
			else
			{
				richBox.DetectUrls = false;
			}
		}

		private void zoomInOut_Click(object sender, EventArgs e)
		{
			if (richBox.ZoomFactor == 1)
			{
				richBox.ZoomFactor = 2;
			}
			else
			{
				richBox.ZoomFactor = 1;
			}
		}

		private void encryptData_Click(object sender, EventArgs e)
		{
			if (richBox.TextLength > 0)
			{
				string saveFileToEncrypt = SaveAsDialog();

				if (!string.IsNullOrEmpty(saveFileToEncrypt))
				{				
					using (AesManaged myAes = new AesManaged())
					{
						try
						{
							EncryptFile(saveFileToEncrypt, myAes.Key, myAes.IV);

							decryptionFileKeyPairs.Add(saveFileToEncrypt, myAes.Key);
							decryptionFileIVPairs.Add(saveFileToEncrypt, myAes.IV);

							MessageBox.Show("File encrypted successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

							EncryptForm encryption = new EncryptForm(myAes.Key, myAes.IV);
							encryption.ShowDialog();
						}
						catch(Exception ex)
						{
							MessageBox.Show("File encryption failed." + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}
				}
			}
			else
			{
				MessageBox.Show("There are no data to encrypt.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void EncryptFile(string fileToBeEncrypted, byte[] Key, byte[] IV)
		{
			using (AesManaged aesAlg = new AesManaged())
			{
				aesAlg.Key = Key;
				aesAlg.IV = IV;

				ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);
				using (FileStream encrypt_file = new FileStream(fileToBeEncrypted, FileMode.Create, FileAccess.Write))
				{
					using (CryptoStream cryptoStream = new CryptoStream(encrypt_file, encryptor, CryptoStreamMode.Write))
					{
						if (Path.GetExtension(fileToBeEncrypted) == ".rtf")
						{
							richBox.SaveFile(cryptoStream, RichTextBoxStreamType.RichText);
						}
						else
						{
							richBox.SaveFile(cryptoStream, RichTextBoxStreamType.PlainText);
						}
					}
				}
			}
		}

		private void decryptFileMenuItem_Click(object sender, EventArgs e)
		{
			string openFileToDecrypt = OpenDialog();

			if (!string.IsNullOrEmpty(openFileToDecrypt))
			{
				try
				{
					DecryptFile(openFileToDecrypt, decryptionFileKeyPairs, decryptionFileIVPairs);
				}
				catch (Exception)
				{
					MessageBox.Show("File dencryption failed. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void DecryptFile(string decryptFile, Dictionary<string, byte[]> holdDecryptionFileKeyPairs, Dictionary<string, byte[]> holdDecryptionFileIVPairs)
		{
			using (AesManaged aesAlg = new AesManaged())
			{
				//check if the keys are stored in the dictionaries
				if (holdDecryptionFileKeyPairs.Keys.Contains(decryptFile))
				{
					aesAlg.Key = GetKey(decryptFile, holdDecryptionFileKeyPairs);
					aesAlg.IV = GetIV(decryptFile, holdDecryptionFileIVPairs);
				}
				else
				{
					//if not e.g when the application closes and opens again later the data in the dictionaries are lost.
					DecryptForm decrypt_form = new DecryptForm();
					decrypt_form.ShowDialog();

					aesAlg.Key = DecryptForm.decryptionKey;
					aesAlg.IV = DecryptForm.decryptionIV;
				}

				ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);
				using (FileStream openFile = new FileStream(decryptFile, FileMode.Open, FileAccess.Read))
				{
					using (CryptoStream csDecrypt = new CryptoStream(openFile, decryptor, CryptoStreamMode.Read))
					{
						using (StreamReader srDecrypt = new StreamReader(csDecrypt))
						{
							richBox.Text = srDecrypt.ReadToEnd();
						}
					}
				}
			}
		}

		private Byte[] GetKey(string decryptFile, Dictionary<string, byte[]> holdDecryptionFileKeyPairs)
		{
			byte[] key = null;
			foreach (KeyValuePair<string, byte[]> cryptoKey in holdDecryptionFileKeyPairs)
			{
				if (cryptoKey.Key == decryptFile)
				{
					key = cryptoKey.Value;
					break;
				}
			}
			return key;
		}

		private Byte[] GetIV(string decryptFile, Dictionary<string, byte[]> holdDecryptionFileIVPairs)
		{
			byte[] iv = null;
			foreach (KeyValuePair<string, byte[]> cryptoIV in holdDecryptionFileIVPairs)
			{
				if (cryptoIV.Key == decryptFile)
				{
					iv = cryptoIV.Value;
					break;
				}
			}
			return iv;
		}

		private void clearHistory_Click(object sender, EventArgs e)
		{
			historyFilePathList.Clear();
			SetHistorySlotsNonVisible();
		}

		private void SetHistorySlotsNonVisible()
		{
			slot1.Visible = false;
			slot2.Visible = false;
			slot3.Visible = false;
			slot4.Visible = false;
			slot5.Visible = false;
		}

		private void richBox_DragDrop(object sender, DragEventArgs e)
		{
			string[] list = (string[]) e.Data.GetData("FileDrop");
			try
			{
				richBox.Clear();
				richBox.LoadFile(list[0], RichTextBoxStreamType.PlainText);
				this.Text = Path.GetFileNameWithoutExtension(list[0]) + " - Editor";
				AddFilesToHistory(list[0]);
			}
			catch (Exception)
			{
				MessageBox.Show("File can not be loaded.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}




	}

}
