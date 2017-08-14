namespace WindowsFormsEditor
{
    partial class Editor
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editor));
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
			this.newMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fileOpen = new System.Windows.Forms.ToolStripMenuItem();
			this.fileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
			this.fileSave = new System.Windows.Forms.ToolStripMenuItem();
			this.menuEdit = new System.Windows.Forms.ToolStripMenuItem();
			this.editClear = new System.Windows.Forms.ToolStripMenuItem();
			this.editUndo = new System.Windows.Forms.ToolStripMenuItem();
			this.editRedo = new System.Windows.Forms.ToolStripMenuItem();
			this.editText = new System.Windows.Forms.ToolStripMenuItem();
			this.leftMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.rightMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.centerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editDateTime = new System.Windows.Forms.ToolStripMenuItem();
			this.menuView = new System.Windows.Forms.ToolStripMenuItem();
			this.historyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.slot1 = new System.Windows.Forms.ToolStripMenuItem();
			this.slot2 = new System.Windows.Forms.ToolStripMenuItem();
			this.slot3 = new System.Windows.Forms.ToolStripMenuItem();
			this.slot4 = new System.Windows.Forms.ToolStripMenuItem();
			this.slot5 = new System.Windows.Forms.ToolStripMenuItem();
			this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.recogniseUrl = new System.Windows.Forms.ToolStripMenuItem();
			this.zoomInOut = new System.Windows.Forms.ToolStripMenuItem();
			this.encryptData = new System.Windows.Forms.ToolStripMenuItem();
			this.decryptFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.clearHistory = new System.Windows.Forms.ToolStripMenuItem();
			this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStrip = new System.Windows.Forms.ToolStrip();
			this.iconOpenFileBtn = new System.Windows.Forms.ToolStripButton();
			this.iconSaveFileBtn = new System.Windows.Forms.ToolStripButton();
			this.iconSaveAsFileBtn = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.iconRedoBtn = new System.Windows.Forms.ToolStripButton();
			this.iconUndoBtn = new System.Windows.Forms.ToolStripButton();
			this.iconFontTextBtn = new System.Windows.Forms.ToolStripButton();
			this.iconBoldBtn = new System.Windows.Forms.ToolStripButton();
			this.iconItalicBtn = new System.Windows.Forms.ToolStripButton();
			this.iconUnderlineBtn = new System.Windows.Forms.ToolStripButton();
			this.iconStrikeoutBtn = new System.Windows.Forms.ToolStripButton();
			this.iconBulletBtn = new System.Windows.Forms.ToolStripButton();
			this.iconReplaceBtn = new System.Windows.Forms.ToolStripButton();
			this.iconHighlightBtn = new System.Windows.Forms.ToolStripButton();
			this.iconSetColorBtn = new System.Windows.Forms.ToolStripDropDownButton();
			this.blackColorSelection = new System.Windows.Forms.ToolStripMenuItem();
			this.blueColorSelection = new System.Windows.Forms.ToolStripMenuItem();
			this.redColorSelection = new System.Windows.Forms.ToolStripMenuItem();
			this.orangeColorSelection = new System.Windows.Forms.ToolStripMenuItem();
			this.yellowColorSelection = new System.Windows.Forms.ToolStripMenuItem();
			this.greenColorSelection = new System.Windows.Forms.ToolStripMenuItem();
			this.searchTextBox = new System.Windows.Forms.TextBox();
			this.btnSearch = new System.Windows.Forms.Button();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.copyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pasteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.selectAllMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.upperMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.lowerCaseMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openLinkMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.countLinesWordsLbl = new System.Windows.Forms.Label();
			this.richBox = new System.Windows.Forms.RichTextBox();
			this.menuStrip.SuspendLayout();
			this.toolStrip.SuspendLayout();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip
			// 
			this.menuStrip.BackColor = System.Drawing.SystemColors.MenuBar;
			this.menuStrip.GripMargin = new System.Windows.Forms.Padding(0, 2, 0, 0);
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuEdit,
            this.menuView,
            this.optionsToolStripMenuItem,
            this.menuExit});
			this.menuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
			this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.menuStrip.Size = new System.Drawing.Size(802, 24);
			this.menuStrip.TabIndex = 5;
			this.menuStrip.Text = "menuStrip1";
			// 
			// menuFile
			// 
			this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newMenuItem,
            this.fileOpen,
            this.fileSaveAs,
            this.fileSave});
			this.menuFile.Name = "menuFile";
			this.menuFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
			this.menuFile.Size = new System.Drawing.Size(37, 22);
			this.menuFile.Text = "File";
			// 
			// newMenuItem
			// 
			this.newMenuItem.Name = "newMenuItem";
			this.newMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
			this.newMenuItem.Size = new System.Drawing.Size(146, 22);
			this.newMenuItem.Text = "New";
			this.newMenuItem.Click += new System.EventHandler(this.newMenuItem_Click);
			// 
			// fileOpen
			// 
			this.fileOpen.Name = "fileOpen";
			this.fileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.fileOpen.Size = new System.Drawing.Size(146, 22);
			this.fileOpen.Text = "Open";
			this.fileOpen.Click += new System.EventHandler(this.fileOpen_Click);
			// 
			// fileSaveAs
			// 
			this.fileSaveAs.Name = "fileSaveAs";
			this.fileSaveAs.Size = new System.Drawing.Size(146, 22);
			this.fileSaveAs.Text = "Save As";
			this.fileSaveAs.Click += new System.EventHandler(this.fileSaveAs_Click);
			// 
			// fileSave
			// 
			this.fileSave.Name = "fileSave";
			this.fileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.fileSave.Size = new System.Drawing.Size(146, 22);
			this.fileSave.Text = "Save";
			this.fileSave.Click += new System.EventHandler(this.fileSave_Click);
			// 
			// menuEdit
			// 
			this.menuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editClear,
            this.editUndo,
            this.editRedo,
            this.editText,
            this.editDateTime});
			this.menuEdit.Name = "menuEdit";
			this.menuEdit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
			this.menuEdit.Size = new System.Drawing.Size(39, 22);
			this.menuEdit.Text = "Edit";
			// 
			// editClear
			// 
			this.editClear.Name = "editClear";
			this.editClear.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.A)));
			this.editClear.Size = new System.Drawing.Size(171, 22);
			this.editClear.Text = "Clear";
			this.editClear.Click += new System.EventHandler(this.editClear_Click);
			// 
			// editUndo
			// 
			this.editUndo.Name = "editUndo";
			this.editUndo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
			this.editUndo.Size = new System.Drawing.Size(171, 22);
			this.editUndo.Text = "Undo";
			this.editUndo.Click += new System.EventHandler(this.iconUndoBtn_Click);
			// 
			// editRedo
			// 
			this.editRedo.Name = "editRedo";
			this.editRedo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
			this.editRedo.Size = new System.Drawing.Size(171, 22);
			this.editRedo.Text = "Redo";
			this.editRedo.Click += new System.EventHandler(this.iconRedoBtn_Click);
			// 
			// editText
			// 
			this.editText.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.leftMenuItem,
            this.rightMenuItem,
            this.centerMenuItem});
			this.editText.Name = "editText";
			this.editText.Size = new System.Drawing.Size(171, 22);
			this.editText.Text = "Text/Image Align";
			// 
			// leftMenuItem
			// 
			this.leftMenuItem.Name = "leftMenuItem";
			this.leftMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.L)));
			this.leftMenuItem.Size = new System.Drawing.Size(183, 22);
			this.leftMenuItem.Text = "Left";
			this.leftMenuItem.Click += new System.EventHandler(this.leftMenuItem_Click);
			// 
			// rightMenuItem
			// 
			this.rightMenuItem.Name = "rightMenuItem";
			this.rightMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.R)));
			this.rightMenuItem.Size = new System.Drawing.Size(183, 22);
			this.rightMenuItem.Text = "Right";
			this.rightMenuItem.Click += new System.EventHandler(this.rightMenuItem_Click);
			// 
			// centerMenuItem
			// 
			this.centerMenuItem.Name = "centerMenuItem";
			this.centerMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
			this.centerMenuItem.Size = new System.Drawing.Size(183, 22);
			this.centerMenuItem.Text = "Center";
			this.centerMenuItem.Click += new System.EventHandler(this.centerMenuItem_Click);
			// 
			// editDateTime
			// 
			this.editDateTime.Name = "editDateTime";
			this.editDateTime.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
			this.editDateTime.Size = new System.Drawing.Size(171, 22);
			this.editDateTime.Text = "Date/Time";
			this.editDateTime.Click += new System.EventHandler(this.editDateTime_Click);
			// 
			// menuView
			// 
			this.menuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.historyMenuItem});
			this.menuView.Name = "menuView";
			this.menuView.Size = new System.Drawing.Size(44, 22);
			this.menuView.Text = "View";
			// 
			// historyMenuItem
			// 
			this.historyMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slot1,
            this.slot2,
            this.slot3,
            this.slot4,
            this.slot5});
			this.historyMenuItem.Name = "historyMenuItem";
			this.historyMenuItem.Size = new System.Drawing.Size(112, 22);
			this.historyMenuItem.Text = "History";
			// 
			// slot1
			// 
			this.slot1.Name = "slot1";
			this.slot1.Size = new System.Drawing.Size(77, 22);
			this.slot1.Text = " ";
			this.slot1.Visible = false;
			this.slot1.Click += new System.EventHandler(this.historySlot1_Click);
			// 
			// slot2
			// 
			this.slot2.Name = "slot2";
			this.slot2.Size = new System.Drawing.Size(77, 22);
			this.slot2.Text = " ";
			this.slot2.Visible = false;
			this.slot2.Click += new System.EventHandler(this.historySlot2_Click);
			// 
			// slot3
			// 
			this.slot3.Name = "slot3";
			this.slot3.Size = new System.Drawing.Size(77, 22);
			this.slot3.Text = " ";
			this.slot3.Visible = false;
			this.slot3.Click += new System.EventHandler(this.historySlot3_Click);
			// 
			// slot4
			// 
			this.slot4.Name = "slot4";
			this.slot4.Size = new System.Drawing.Size(77, 22);
			this.slot4.Text = " ";
			this.slot4.Visible = false;
			this.slot4.Click += new System.EventHandler(this.historySlot4_Click);
			// 
			// slot5
			// 
			this.slot5.Name = "slot5";
			this.slot5.Size = new System.Drawing.Size(77, 22);
			this.slot5.Text = " ";
			this.slot5.Visible = false;
			this.slot5.Click += new System.EventHandler(this.historySlot5_Click);
			// 
			// optionsToolStripMenuItem
			// 
			this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recogniseUrl,
            this.zoomInOut,
            this.encryptData,
            this.decryptFileMenuItem,
            this.clearHistory});
			this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
			this.optionsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.R)));
			this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 22);
			this.optionsToolStripMenuItem.Text = "Options";
			// 
			// recogniseUrl
			// 
			this.recogniseUrl.Name = "recogniseUrl";
			this.recogniseUrl.Size = new System.Drawing.Size(208, 22);
			this.recogniseUrl.Text = "Recognise Urls";
			this.recogniseUrl.Click += new System.EventHandler(this.recogniseUrl_Click);
			// 
			// zoomInOut
			// 
			this.zoomInOut.Name = "zoomInOut";
			this.zoomInOut.Size = new System.Drawing.Size(208, 22);
			this.zoomInOut.Text = "Zoom In/Out";
			this.zoomInOut.Click += new System.EventHandler(this.zoomInOut_Click);
			// 
			// encryptData
			// 
			this.encryptData.Name = "encryptData";
			this.encryptData.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
			this.encryptData.Size = new System.Drawing.Size(208, 22);
			this.encryptData.Text = "Encrypt Data";
			this.encryptData.Click += new System.EventHandler(this.encryptData_Click);
			// 
			// decryptFileMenuItem
			// 
			this.decryptFileMenuItem.Name = "decryptFileMenuItem";
			this.decryptFileMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
			this.decryptFileMenuItem.Size = new System.Drawing.Size(208, 22);
			this.decryptFileMenuItem.Text = "Decrypt File";
			this.decryptFileMenuItem.Click += new System.EventHandler(this.decryptFileMenuItem_Click);
			// 
			// clearHistory
			// 
			this.clearHistory.Name = "clearHistory";
			this.clearHistory.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.H)));
			this.clearHistory.Size = new System.Drawing.Size(208, 22);
			this.clearHistory.Text = "Clear History";
			this.clearHistory.Click += new System.EventHandler(this.clearHistory_Click);
			// 
			// menuExit
			// 
			this.menuExit.Name = "menuExit";
			this.menuExit.Size = new System.Drawing.Size(37, 22);
			this.menuExit.Text = "Exit";
			this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
			// 
			// toolStrip
			// 
			this.toolStrip.BackColor = System.Drawing.SystemColors.MenuBar;
			this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iconOpenFileBtn,
            this.iconSaveFileBtn,
            this.iconSaveAsFileBtn,
            this.toolStripSeparator2,
            this.iconRedoBtn,
            this.iconUndoBtn,
            this.iconFontTextBtn,
            this.iconBoldBtn,
            this.iconItalicBtn,
            this.iconUnderlineBtn,
            this.iconStrikeoutBtn,
            this.iconBulletBtn,
            this.iconReplaceBtn,
            this.iconHighlightBtn,
            this.iconSetColorBtn});
			this.toolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
			this.toolStrip.Location = new System.Drawing.Point(0, 24);
			this.toolStrip.Name = "toolStrip";
			this.toolStrip.Size = new System.Drawing.Size(802, 25);
			this.toolStrip.TabIndex = 6;
			this.toolStrip.Text = "toolStrip1";
			// 
			// iconOpenFileBtn
			// 
			this.iconOpenFileBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.iconOpenFileBtn.Image = ((System.Drawing.Image)(resources.GetObject("iconOpenFileBtn.Image")));
			this.iconOpenFileBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.iconOpenFileBtn.Name = "iconOpenFileBtn";
			this.iconOpenFileBtn.Size = new System.Drawing.Size(23, 22);
			this.iconOpenFileBtn.Text = "Open Folder";
			this.iconOpenFileBtn.Click += new System.EventHandler(this.fileOpen_Click);
			// 
			// iconSaveFileBtn
			// 
			this.iconSaveFileBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.iconSaveFileBtn.Image = ((System.Drawing.Image)(resources.GetObject("iconSaveFileBtn.Image")));
			this.iconSaveFileBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.iconSaveFileBtn.Name = "iconSaveFileBtn";
			this.iconSaveFileBtn.Size = new System.Drawing.Size(23, 22);
			this.iconSaveFileBtn.Text = "Save";
			this.iconSaveFileBtn.Click += new System.EventHandler(this.fileSave_Click);
			// 
			// iconSaveAsFileBtn
			// 
			this.iconSaveAsFileBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.iconSaveAsFileBtn.Image = ((System.Drawing.Image)(resources.GetObject("iconSaveAsFileBtn.Image")));
			this.iconSaveAsFileBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.iconSaveAsFileBtn.Name = "iconSaveAsFileBtn";
			this.iconSaveAsFileBtn.Size = new System.Drawing.Size(23, 22);
			this.iconSaveAsFileBtn.Text = "Save As";
			this.iconSaveAsFileBtn.Click += new System.EventHandler(this.fileSaveAs_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// iconRedoBtn
			// 
			this.iconRedoBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.iconRedoBtn.Image = ((System.Drawing.Image)(resources.GetObject("iconRedoBtn.Image")));
			this.iconRedoBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.iconRedoBtn.Name = "iconRedoBtn";
			this.iconRedoBtn.Size = new System.Drawing.Size(23, 22);
			this.iconRedoBtn.Text = "Redo";
			this.iconRedoBtn.Click += new System.EventHandler(this.iconRedoBtn_Click);
			// 
			// iconUndoBtn
			// 
			this.iconUndoBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.iconUndoBtn.Image = ((System.Drawing.Image)(resources.GetObject("iconUndoBtn.Image")));
			this.iconUndoBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.iconUndoBtn.Name = "iconUndoBtn";
			this.iconUndoBtn.Size = new System.Drawing.Size(23, 22);
			this.iconUndoBtn.Text = "Undo";
			this.iconUndoBtn.Click += new System.EventHandler(this.iconUndoBtn_Click);
			// 
			// iconFontTextBtn
			// 
			this.iconFontTextBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.iconFontTextBtn.Image = ((System.Drawing.Image)(resources.GetObject("iconFontTextBtn.Image")));
			this.iconFontTextBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.iconFontTextBtn.Name = "iconFontTextBtn";
			this.iconFontTextBtn.Size = new System.Drawing.Size(23, 22);
			this.iconFontTextBtn.Text = "Text Style";
			this.iconFontTextBtn.Click += new System.EventHandler(this.fontTextBtn_Click);
			// 
			// iconBoldBtn
			// 
			this.iconBoldBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.iconBoldBtn.Image = ((System.Drawing.Image)(resources.GetObject("iconBoldBtn.Image")));
			this.iconBoldBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.iconBoldBtn.Name = "iconBoldBtn";
			this.iconBoldBtn.Size = new System.Drawing.Size(23, 22);
			this.iconBoldBtn.Text = "Bold";
			this.iconBoldBtn.Click += new System.EventHandler(this.boldBtn_Click);
			// 
			// iconItalicBtn
			// 
			this.iconItalicBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.iconItalicBtn.Image = ((System.Drawing.Image)(resources.GetObject("iconItalicBtn.Image")));
			this.iconItalicBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.iconItalicBtn.Name = "iconItalicBtn";
			this.iconItalicBtn.Size = new System.Drawing.Size(23, 22);
			this.iconItalicBtn.Text = "Italic";
			this.iconItalicBtn.Click += new System.EventHandler(this.italicBtn_Click);
			// 
			// iconUnderlineBtn
			// 
			this.iconUnderlineBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.iconUnderlineBtn.Image = ((System.Drawing.Image)(resources.GetObject("iconUnderlineBtn.Image")));
			this.iconUnderlineBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.iconUnderlineBtn.Name = "iconUnderlineBtn";
			this.iconUnderlineBtn.Size = new System.Drawing.Size(23, 22);
			this.iconUnderlineBtn.Text = "Underline";
			this.iconUnderlineBtn.Click += new System.EventHandler(this.underlineBtn_Click);
			// 
			// iconStrikeoutBtn
			// 
			this.iconStrikeoutBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.iconStrikeoutBtn.Image = ((System.Drawing.Image)(resources.GetObject("iconStrikeoutBtn.Image")));
			this.iconStrikeoutBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.iconStrikeoutBtn.Name = "iconStrikeoutBtn";
			this.iconStrikeoutBtn.Size = new System.Drawing.Size(23, 22);
			this.iconStrikeoutBtn.Text = "Strike Out";
			this.iconStrikeoutBtn.Click += new System.EventHandler(this.strikeoutBtn_Click);
			// 
			// iconBulletBtn
			// 
			this.iconBulletBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.iconBulletBtn.Image = ((System.Drawing.Image)(resources.GetObject("iconBulletBtn.Image")));
			this.iconBulletBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.iconBulletBtn.Name = "iconBulletBtn";
			this.iconBulletBtn.Size = new System.Drawing.Size(23, 22);
			this.iconBulletBtn.Text = "toolStripButton1";
			this.iconBulletBtn.ToolTipText = "Bullet List";
			this.iconBulletBtn.Click += new System.EventHandler(this.iconBulletBtn_Click);
			// 
			// iconReplaceBtn
			// 
			this.iconReplaceBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.iconReplaceBtn.Image = ((System.Drawing.Image)(resources.GetObject("iconReplaceBtn.Image")));
			this.iconReplaceBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.iconReplaceBtn.Name = "iconReplaceBtn";
			this.iconReplaceBtn.Size = new System.Drawing.Size(23, 22);
			this.iconReplaceBtn.Text = "Replace";
			this.iconReplaceBtn.Click += new System.EventHandler(this.replaceBtn_Click);
			// 
			// iconHighlightBtn
			// 
			this.iconHighlightBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.iconHighlightBtn.Image = ((System.Drawing.Image)(resources.GetObject("iconHighlightBtn.Image")));
			this.iconHighlightBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.iconHighlightBtn.Name = "iconHighlightBtn";
			this.iconHighlightBtn.Size = new System.Drawing.Size(23, 22);
			this.iconHighlightBtn.Text = "Highlight Text";
			this.iconHighlightBtn.Click += new System.EventHandler(this.highlightBtn_Click);
			// 
			// iconSetColorBtn
			// 
			this.iconSetColorBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.iconSetColorBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blackColorSelection,
            this.blueColorSelection,
            this.redColorSelection,
            this.orangeColorSelection,
            this.yellowColorSelection,
            this.greenColorSelection});
			this.iconSetColorBtn.Image = ((System.Drawing.Image)(resources.GetObject("iconSetColorBtn.Image")));
			this.iconSetColorBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.iconSetColorBtn.Name = "iconSetColorBtn";
			this.iconSetColorBtn.Size = new System.Drawing.Size(29, 22);
			this.iconSetColorBtn.Text = "Color";
			// 
			// blackColorSelection
			// 
			this.blackColorSelection.Image = ((System.Drawing.Image)(resources.GetObject("blackColorSelection.Image")));
			this.blackColorSelection.Name = "blackColorSelection";
			this.blackColorSelection.Size = new System.Drawing.Size(113, 22);
			this.blackColorSelection.Text = "Black";
			this.blackColorSelection.Click += new System.EventHandler(this.blackColorSelection_Click);
			// 
			// blueColorSelection
			// 
			this.blueColorSelection.Image = ((System.Drawing.Image)(resources.GetObject("blueColorSelection.Image")));
			this.blueColorSelection.Name = "blueColorSelection";
			this.blueColorSelection.Size = new System.Drawing.Size(113, 22);
			this.blueColorSelection.Text = "Blue";
			this.blueColorSelection.Click += new System.EventHandler(this.blueColorSelection_Click);
			// 
			// redColorSelection
			// 
			this.redColorSelection.Image = ((System.Drawing.Image)(resources.GetObject("redColorSelection.Image")));
			this.redColorSelection.Name = "redColorSelection";
			this.redColorSelection.Size = new System.Drawing.Size(113, 22);
			this.redColorSelection.Text = "Red";
			this.redColorSelection.Click += new System.EventHandler(this.redColorSelection_Click);
			// 
			// orangeColorSelection
			// 
			this.orangeColorSelection.Image = ((System.Drawing.Image)(resources.GetObject("orangeColorSelection.Image")));
			this.orangeColorSelection.Name = "orangeColorSelection";
			this.orangeColorSelection.Size = new System.Drawing.Size(113, 22);
			this.orangeColorSelection.Text = "Orange";
			this.orangeColorSelection.Click += new System.EventHandler(this.orangeColorSelection_Click);
			// 
			// yellowColorSelection
			// 
			this.yellowColorSelection.Image = ((System.Drawing.Image)(resources.GetObject("yellowColorSelection.Image")));
			this.yellowColorSelection.Name = "yellowColorSelection";
			this.yellowColorSelection.Size = new System.Drawing.Size(113, 22);
			this.yellowColorSelection.Text = "Yellow";
			this.yellowColorSelection.Click += new System.EventHandler(this.yellowColorSelection_Click);
			// 
			// greenColorSelection
			// 
			this.greenColorSelection.Image = ((System.Drawing.Image)(resources.GetObject("greenColorSelection.Image")));
			this.greenColorSelection.Name = "greenColorSelection";
			this.greenColorSelection.Size = new System.Drawing.Size(113, 22);
			this.greenColorSelection.Text = "Green";
			this.greenColorSelection.Click += new System.EventHandler(this.greenColorSelection_Click);
			// 
			// searchTextBox
			// 
			this.searchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.searchTextBox.Location = new System.Drawing.Point(620, 23);
			this.searchTextBox.Name = "searchTextBox";
			this.searchTextBox.Size = new System.Drawing.Size(170, 20);
			this.searchTextBox.TabIndex = 7;
			// 
			// btnSearch
			// 
			this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSearch.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
			this.btnSearch.Location = new System.Drawing.Point(591, 22);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(23, 22);
			this.btnSearch.TabIndex = 8;
			this.btnSearch.UseVisualStyleBackColor = false;
			this.btnSearch.Click += new System.EventHandler(this.searchBtn_Click);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyMenuItem,
            this.cutMenuItem,
            this.pasteMenuItem,
            this.selectAllMenuItem,
            this.upperMenuItem,
            this.lowerCaseMenuItem,
            this.openLinkMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(177, 158);
			// 
			// copyMenuItem
			// 
			this.copyMenuItem.Name = "copyMenuItem";
			this.copyMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
			this.copyMenuItem.Size = new System.Drawing.Size(176, 22);
			this.copyMenuItem.Text = "Copy";
			this.copyMenuItem.Click += new System.EventHandler(this.copyMenuItem_Click);
			// 
			// cutMenuItem
			// 
			this.cutMenuItem.Name = "cutMenuItem";
			this.cutMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
			this.cutMenuItem.Size = new System.Drawing.Size(176, 22);
			this.cutMenuItem.Text = "Cut";
			this.cutMenuItem.Click += new System.EventHandler(this.cutMenuItem_Click);
			// 
			// pasteMenuItem
			// 
			this.pasteMenuItem.Name = "pasteMenuItem";
			this.pasteMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
			this.pasteMenuItem.Size = new System.Drawing.Size(176, 22);
			this.pasteMenuItem.Text = "Paste";
			this.pasteMenuItem.Click += new System.EventHandler(this.pasteMenuItem_Click);
			// 
			// selectAllMenuItem
			// 
			this.selectAllMenuItem.Name = "selectAllMenuItem";
			this.selectAllMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
			this.selectAllMenuItem.Size = new System.Drawing.Size(176, 22);
			this.selectAllMenuItem.Text = "Select All";
			this.selectAllMenuItem.Click += new System.EventHandler(this.selectAllMenuItem_Click);
			// 
			// upperMenuItem
			// 
			this.upperMenuItem.Name = "upperMenuItem";
			this.upperMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
			this.upperMenuItem.Size = new System.Drawing.Size(176, 22);
			this.upperMenuItem.Text = "Upper Case";
			this.upperMenuItem.Click += new System.EventHandler(this.upperCaseMenuItem_Click);
			// 
			// lowerCaseMenuItem
			// 
			this.lowerCaseMenuItem.Name = "lowerCaseMenuItem";
			this.lowerCaseMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
			this.lowerCaseMenuItem.Size = new System.Drawing.Size(176, 22);
			this.lowerCaseMenuItem.Text = "Lower Case";
			this.lowerCaseMenuItem.Click += new System.EventHandler(this.lowerCaseMenuItem_Click);
			// 
			// openLinkMenuItem
			// 
			this.openLinkMenuItem.Name = "openLinkMenuItem";
			this.openLinkMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
			this.openLinkMenuItem.Size = new System.Drawing.Size(176, 22);
			this.openLinkMenuItem.Text = "Open Link";
			this.openLinkMenuItem.Click += new System.EventHandler(this.openLinkMenuItem_Click);
			// 
			// countLinesWordsLbl
			// 
			this.countLinesWordsLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.countLinesWordsLbl.AutoSize = true;
			this.countLinesWordsLbl.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.countLinesWordsLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.countLinesWordsLbl.Location = new System.Drawing.Point(0, 368);
			this.countLinesWordsLbl.Name = "countLinesWordsLbl";
			this.countLinesWordsLbl.Size = new System.Drawing.Size(2, 15);
			this.countLinesWordsLbl.TabIndex = 11;
			this.countLinesWordsLbl.Visible = false;
			// 
			// richBox
			// 
			this.richBox.AcceptsTab = true;
			this.richBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.richBox.BackColor = System.Drawing.SystemColors.Menu;
			this.richBox.BulletIndent = 10;
			this.richBox.ContextMenuStrip = this.contextMenuStrip1;
			this.richBox.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.richBox.DetectUrls = false;
			this.richBox.Location = new System.Drawing.Point(0, 50);
			this.richBox.Name = "richBox";
			this.richBox.Size = new System.Drawing.Size(802, 333);
			this.richBox.TabIndex = 9;
			this.richBox.Text = "";
			this.richBox.TextChanged += new System.EventHandler(this.richBox_TextChanged);
			this.richBox.MouseLeave += new System.EventHandler(this.richBox_MouseLeave);
			// 
			// Editor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.ClientSize = new System.Drawing.Size(802, 383);
			this.Controls.Add(this.countLinesWordsLbl);
			this.Controls.Add(this.richBox);
			this.Controls.Add(this.searchTextBox);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.toolStrip);
			this.Controls.Add(this.menuStrip);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Editor";
			this.Text = "Editor";
			this.Load += new System.EventHandler(this.Editor_Load);
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.toolStrip.ResumeLayout(false);
			this.toolStrip.PerformLayout();
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem fileOpen;
        private System.Windows.Forms.ToolStripMenuItem fileSave;
        private System.Windows.Forms.ToolStripMenuItem fileSaveAs;
        private System.Windows.Forms.ToolStripMenuItem menuEdit;
        private System.Windows.Forms.ToolStripMenuItem editUndo;
        private System.Windows.Forms.ToolStripMenuItem editRedo;
        private System.Windows.Forms.ToolStripMenuItem editText;
        private System.Windows.Forms.ToolStripMenuItem menuView;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton iconSaveFileBtn;
        private System.Windows.Forms.ToolStripButton iconSaveAsFileBtn;
        private System.Windows.Forms.ToolStripButton iconOpenFileBtn;
        private System.Windows.Forms.ToolStripButton iconRedoBtn;
        private System.Windows.Forms.ToolStripButton iconUndoBtn;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ToolStripButton iconFontTextBtn;
        private System.Windows.Forms.ToolStripButton iconBoldBtn;
        private System.Windows.Forms.ToolStripButton iconItalicBtn;
        private System.Windows.Forms.ToolStripButton iconUnderlineBtn;
        private System.Windows.Forms.ToolStripButton iconStrikeoutBtn;
        private System.Windows.Forms.ToolStripButton iconHighlightBtn;
        private System.Windows.Forms.ToolStripMenuItem editClear;
        private System.Windows.Forms.ToolStripMenuItem editDateTime;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyMenuItem;
        private System.Windows.Forms.ToolStripMenuItem slot1;
        private System.Windows.Forms.ToolStripMenuItem slot2;
        private System.Windows.Forms.ToolStripMenuItem slot3;
        private System.Windows.Forms.ToolStripMenuItem slot4;
        private System.Windows.Forms.ToolStripMenuItem slot5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripDropDownButton iconSetColorBtn;
        private System.Windows.Forms.ToolStripMenuItem blueColorSelection;
        private System.Windows.Forms.ToolStripMenuItem redColorSelection;
        private System.Windows.Forms.ToolStripMenuItem orangeColorSelection;
        private System.Windows.Forms.ToolStripMenuItem yellowColorSelection;
        private System.Windows.Forms.ToolStripMenuItem greenColorSelection;
        private System.Windows.Forms.ToolStripMenuItem blackColorSelection;
        private System.Windows.Forms.ToolStripButton iconReplaceBtn;
		private System.Windows.Forms.ToolStripMenuItem newMenuItem;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem copyMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cutMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pasteMenuItem;
		private System.Windows.Forms.ToolStripMenuItem selectAllMenuItem;
		private System.Windows.Forms.ToolStripMenuItem upperMenuItem;
		private System.Windows.Forms.ToolStripMenuItem lowerCaseMenuItem;
		private System.Windows.Forms.ToolStripMenuItem leftMenuItem;
		private System.Windows.Forms.ToolStripMenuItem rightMenuItem;
		private System.Windows.Forms.ToolStripMenuItem centerMenuItem;
		private System.Windows.Forms.Label countLinesWordsLbl;
		private System.Windows.Forms.ToolStripMenuItem recogniseUrl;
		private System.Windows.Forms.ToolStripMenuItem zoomInOut;
		private System.Windows.Forms.ToolStripMenuItem encryptData;
		private System.Windows.Forms.ToolStripMenuItem decryptFileMenuItem;
		private System.Windows.Forms.ToolStripMenuItem clearHistory;
		private System.Windows.Forms.ToolStripMenuItem openLinkMenuItem;
		private System.Windows.Forms.ToolStripButton iconBulletBtn;
		private System.Windows.Forms.RichTextBox richBox;
	}
}

