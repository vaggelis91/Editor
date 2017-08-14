namespace WindowsFormsEditor
{
    partial class ReplaceForm
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
			this.label2 = new System.Windows.Forms.Label();
			this.selectedTextBox = new System.Windows.Forms.TextBox();
			this.replaceBtn = new System.Windows.Forms.Button();
			this.newTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.replaceAll_radioBtn = new System.Windows.Forms.RadioButton();
			this.replaceSelectedText_radioBtn = new System.Windows.Forms.RadioButton();
			this.CancelBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(15, 29);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(73, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Selected Text";
			// 
			// selectedTextBox
			// 
			this.selectedTextBox.Location = new System.Drawing.Point(92, 26);
			this.selectedTextBox.Name = "selectedTextBox";
			this.selectedTextBox.ReadOnly = true;
			this.selectedTextBox.Size = new System.Drawing.Size(166, 20);
			this.selectedTextBox.TabIndex = 3;
			// 
			// replaceBtn
			// 
			this.replaceBtn.Location = new System.Drawing.Point(202, 148);
			this.replaceBtn.Name = "replaceBtn";
			this.replaceBtn.Size = new System.Drawing.Size(56, 23);
			this.replaceBtn.TabIndex = 4;
			this.replaceBtn.Text = "OK";
			this.replaceBtn.UseVisualStyleBackColor = true;
			this.replaceBtn.Click += new System.EventHandler(this.replaceBtn_Click);
			// 
			// newTextBox
			// 
			this.newTextBox.Location = new System.Drawing.Point(92, 55);
			this.newTextBox.Name = "newTextBox";
			this.newTextBox.Size = new System.Drawing.Size(166, 20);
			this.newTextBox.TabIndex = 10;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(33, 58);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 13);
			this.label1.TabIndex = 9;
			this.label1.Text = "New Text";
			// 
			// replaceAll_radioBtn
			// 
			this.replaceAll_radioBtn.AutoSize = true;
			this.replaceAll_radioBtn.Location = new System.Drawing.Point(92, 109);
			this.replaceAll_radioBtn.Name = "replaceAll_radioBtn";
			this.replaceAll_radioBtn.Size = new System.Drawing.Size(137, 17);
			this.replaceAll_radioBtn.TabIndex = 11;
			this.replaceAll_radioBtn.Text = "Replace all occurences";
			this.replaceAll_radioBtn.UseVisualStyleBackColor = true;
			// 
			// replaceSelectedText_radioBtn
			// 
			this.replaceSelectedText_radioBtn.AutoSize = true;
			this.replaceSelectedText_radioBtn.Checked = true;
			this.replaceSelectedText_radioBtn.Location = new System.Drawing.Point(92, 89);
			this.replaceSelectedText_radioBtn.Name = "replaceSelectedText_radioBtn";
			this.replaceSelectedText_radioBtn.Size = new System.Drawing.Size(128, 17);
			this.replaceSelectedText_radioBtn.TabIndex = 12;
			this.replaceSelectedText_radioBtn.TabStop = true;
			this.replaceSelectedText_radioBtn.Text = "Replace selected text";
			this.replaceSelectedText_radioBtn.UseVisualStyleBackColor = true;
			// 
			// ReplaceForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 184);
			this.Controls.Add(this.CancelBtn);
			this.Controls.Add(this.replaceSelectedText_radioBtn);
			this.Controls.Add(this.replaceAll_radioBtn);
			this.Controls.Add(this.newTextBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.replaceBtn);
			this.Controls.Add(this.selectedTextBox);
			this.Controls.Add(this.label2);
			this.Name = "ReplaceForm";
			this.Text = "Replace Text";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox selectedTextBox;
        private System.Windows.Forms.Button replaceBtn;
		private System.Windows.Forms.TextBox newTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RadioButton replaceAll_radioBtn;
		private System.Windows.Forms.RadioButton replaceSelectedText_radioBtn;
		private System.Windows.Forms.Button CancelBtn;
	}
}