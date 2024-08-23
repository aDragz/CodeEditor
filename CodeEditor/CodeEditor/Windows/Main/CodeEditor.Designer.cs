namespace CodeEditor
{
    partial class CodeEditor
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CodeEditor));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newProjectToolStripMenuItem = new ToolStripMenuItem();
            newProjectToolStripMenuItem1 = new ToolStripMenuItem();
            newFileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            openFileToolStripMenuItem = new ToolStripMenuItem();
            folderToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem1 = new ToolStripMenuItem();
            openProjectToolStripMenuItem1 = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveAllToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripMenuItem1 = new ToolStripMenuItem();
            exitAllToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            selectAllToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator5 = new ToolStripSeparator();
            copyToolStripMenuItem = new ToolStripMenuItem();
            pasteToolStripMenuItem = new ToolStripMenuItem();
            cutToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator6 = new ToolStripSeparator();
            findToolStripMenuItem = new ToolStripMenuItem();
            replaceToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            undoToolStripMenuItem = new ToolStripMenuItem();
            redoToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            buildToolStripMenuItem = new ToolStripMenuItem();
            icons = new ImageList(components);
            splitContainer1 = new SplitContainer();
            FileExplorer = new TreeView();
            editorTab = new TabControl();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, viewToolStripMenuItem, buildToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(2028, 33);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newProjectToolStripMenuItem, openToolStripMenuItem, openToolStripMenuItem1, toolStripSeparator3, saveToolStripMenuItem, saveAllToolStripMenuItem, toolStripSeparator1, toolStripMenuItem1, exitAllToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(54, 29);
            fileToolStripMenuItem.Text = "File";
            // 
            // newProjectToolStripMenuItem
            // 
            newProjectToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newProjectToolStripMenuItem1, newFileToolStripMenuItem });
            newProjectToolStripMenuItem.Name = "newProjectToolStripMenuItem";
            newProjectToolStripMenuItem.Size = new Size(271, 34);
            newProjectToolStripMenuItem.Text = "New";
            newProjectToolStripMenuItem.Click += newProjectToolStripMenuItem_Click;
            // 
            // newProjectToolStripMenuItem1
            // 
            newProjectToolStripMenuItem1.Name = "newProjectToolStripMenuItem1";
            newProjectToolStripMenuItem1.ShortcutKeys = Keys.Control | Keys.Alt | Keys.N;
            newProjectToolStripMenuItem1.Size = new Size(306, 34);
            newProjectToolStripMenuItem1.Text = "New Project";
            newProjectToolStripMenuItem1.Click += newProjectToolStripMenuItem1_Click;
            // 
            // newFileToolStripMenuItem
            // 
            newFileToolStripMenuItem.Name = "newFileToolStripMenuItem";
            newFileToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            newFileToolStripMenuItem.Size = new Size(306, 34);
            newFileToolStripMenuItem.Text = "New File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openFileToolStripMenuItem, folderToolStripMenuItem });
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(271, 34);
            openToolStripMenuItem.Text = "Import";
            // 
            // openFileToolStripMenuItem
            // 
            openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            openFileToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            openFileToolStripMenuItem.Size = new Size(270, 34);
            openFileToolStripMenuItem.Text = "Import File";
            openFileToolStripMenuItem.Click += openFileToolStripMenuItem_Click;
            // 
            // folderToolStripMenuItem
            // 
            folderToolStripMenuItem.Name = "folderToolStripMenuItem";
            folderToolStripMenuItem.Size = new Size(270, 34);
            folderToolStripMenuItem.Text = "Import Folder";
            // 
            // openToolStripMenuItem1
            // 
            openToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { openProjectToolStripMenuItem1 });
            openToolStripMenuItem1.Name = "openToolStripMenuItem1";
            openToolStripMenuItem1.Size = new Size(271, 34);
            openToolStripMenuItem1.Text = "Open";
            // 
            // openProjectToolStripMenuItem1
            // 
            openProjectToolStripMenuItem1.Name = "openProjectToolStripMenuItem1";
            openProjectToolStripMenuItem1.ShortcutKeys = Keys.Control | Keys.Alt | Keys.O;
            openProjectToolStripMenuItem1.Size = new Size(316, 34);
            openProjectToolStripMenuItem1.Text = "Open Project";
            openProjectToolStripMenuItem1.Click += openProjectToolStripMenuItem1_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(268, 6);
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveToolStripMenuItem.Size = new Size(271, 34);
            saveToolStripMenuItem.Text = "Save";
            // 
            // saveAllToolStripMenuItem
            // 
            saveAllToolStripMenuItem.Name = "saveAllToolStripMenuItem";
            saveAllToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Alt | Keys.S;
            saveAllToolStripMenuItem.Size = new Size(271, 34);
            saveAllToolStripMenuItem.Text = "Save All";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(268, 6);
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.ShortcutKeys = Keys.Alt | Keys.F4;
            toolStripMenuItem1.Size = new Size(271, 34);
            toolStripMenuItem1.Text = "Exit";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // exitAllToolStripMenuItem
            // 
            exitAllToolStripMenuItem.Name = "exitAllToolStripMenuItem";
            exitAllToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Alt | Keys.F4;
            exitAllToolStripMenuItem.Size = new Size(271, 34);
            exitAllToolStripMenuItem.Text = "Exit All";
            exitAllToolStripMenuItem.Click += exitAllToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { selectAllToolStripMenuItem, toolStripSeparator5, copyToolStripMenuItem, pasteToolStripMenuItem, cutToolStripMenuItem, toolStripSeparator6, findToolStripMenuItem, replaceToolStripMenuItem, toolStripSeparator4, undoToolStripMenuItem, redoToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(58, 29);
            editToolStripMenuItem.Text = "Edit";
            // 
            // selectAllToolStripMenuItem
            // 
            selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            selectAllToolStripMenuItem.Size = new Size(185, 34);
            selectAllToolStripMenuItem.Text = "Select All";
            selectAllToolStripMenuItem.Click += selectAllToolStripMenuItem_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(182, 6);
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.Size = new Size(185, 34);
            copyToolStripMenuItem.Text = "Copy";
            copyToolStripMenuItem.Click += copyToolStripMenuItem_Click;
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.Size = new Size(185, 34);
            pasteToolStripMenuItem.Text = "Paste";
            pasteToolStripMenuItem.Click += pasteToolStripMenuItem_Click;
            // 
            // cutToolStripMenuItem
            // 
            cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            cutToolStripMenuItem.Size = new Size(185, 34);
            cutToolStripMenuItem.Text = "Cut";
            cutToolStripMenuItem.Click += cutToolStripMenuItem_Click;
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(182, 6);
            // 
            // findToolStripMenuItem
            // 
            findToolStripMenuItem.Name = "findToolStripMenuItem";
            findToolStripMenuItem.Size = new Size(185, 34);
            findToolStripMenuItem.Text = "Find";
            findToolStripMenuItem.Click += findToolStripMenuItem_Click;
            // 
            // replaceToolStripMenuItem
            // 
            replaceToolStripMenuItem.Name = "replaceToolStripMenuItem";
            replaceToolStripMenuItem.Size = new Size(185, 34);
            replaceToolStripMenuItem.Text = "Replace";
            replaceToolStripMenuItem.Click += replaceToolStripMenuItem_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(182, 6);
            // 
            // undoToolStripMenuItem
            // 
            undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            undoToolStripMenuItem.Size = new Size(185, 34);
            undoToolStripMenuItem.Text = "Undo";
            undoToolStripMenuItem.Click += undoToolStripMenuItem_Click;
            // 
            // redoToolStripMenuItem
            // 
            redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            redoToolStripMenuItem.Size = new Size(185, 34);
            redoToolStripMenuItem.Text = "Redo";
            redoToolStripMenuItem.Click += redoToolStripMenuItem_Click;
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(65, 29);
            viewToolStripMenuItem.Text = "View";
            // 
            // buildToolStripMenuItem
            // 
            buildToolStripMenuItem.Name = "buildToolStripMenuItem";
            buildToolStripMenuItem.Size = new Size(67, 29);
            buildToolStripMenuItem.Text = "Build";
            // 
            // icons
            // 
            icons.ColorDepth = ColorDepth.Depth32Bit;
            icons.ImageStream = (ImageListStreamer)resources.GetObject("icons.ImageStream");
            icons.TransparentColor = Color.Transparent;
            icons.Images.SetKeyName(0, "java");
            icons.Images.SetKeyName(1, "folder");
            icons.Images.SetKeyName(2, "yaml");
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 33);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(FileExplorer);
            splitContainer1.Panel1MinSize = 300;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(editorTab);
            splitContainer1.Panel2MinSize = 640;
            splitContainer1.Size = new Size(2028, 991);
            splitContainer1.SplitterDistance = 300;
            splitContainer1.TabIndex = 5;
            // 
            // FileExplorer
            // 
            FileExplorer.Dock = DockStyle.Fill;
            FileExplorer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FileExplorer.FullRowSelect = true;
            FileExplorer.ImageKey = "folder";
            FileExplorer.ImageList = icons;
            FileExplorer.Indent = 35;
            FileExplorer.Location = new Point(0, 0);
            FileExplorer.Name = "FileExplorer";
            FileExplorer.SelectedImageKey = "folder";
            FileExplorer.ShowLines = false;
            FileExplorer.ShowNodeToolTips = true;
            FileExplorer.Size = new Size(300, 991);
            FileExplorer.TabIndex = 1;
            FileExplorer.TabStop = false;
            FileExplorer.NodeMouseDoubleClick += FileExplorer_DoubleClickEvent;
            // 
            // editorTab
            // 
            editorTab.AccessibleName = "tab";
            editorTab.Dock = DockStyle.Fill;
            editorTab.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            editorTab.Location = new Point(0, 0);
            editorTab.Name = "editorTab";
            editorTab.SelectedIndex = 0;
            editorTab.Size = new Size(1724, 991);
            editorTab.TabIndex = 1;
            editorTab.MouseClick += Editor_MiddleClick;
            // 
            // CodeEditor
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2028, 1024);
            Controls.Add(splitContainer1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(1280, 720);
            Name = "CodeEditor";
            Text = "CodeEditor";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newProjectToolStripMenuItem;
        private ToolStripMenuItem newProjectToolStripMenuItem1;
        private ToolStripMenuItem newFileToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem exitAllToolStripMenuItem;
        private ImageList icons;
        private SplitContainer splitContainer1;
        public TreeView FileExplorer;
        public TabControl editorTab;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem openFileToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem buildToolStripMenuItem;
        private ToolStripMenuItem folderToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAllToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem selectAllToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem undoToolStripMenuItem;
        private ToolStripMenuItem redoToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem cutToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripMenuItem findToolStripMenuItem;
        private ToolStripMenuItem replaceToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem1;
        private ToolStripMenuItem openProjectToolStripMenuItem1;
    }
}