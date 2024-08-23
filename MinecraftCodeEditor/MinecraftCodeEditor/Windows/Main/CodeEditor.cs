using CodeEditor.Actions;
using CodeEditor.Actions.FileHandler;
using CodeEditor.Actions.FileHandler.Settings;
using CodeEditor.Actions.Tabs;
using CodeEditor.Windows.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CodeEditor
{
    public partial class CodeEditor : Form
    {
        public CodeEditor()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (TabPage tabPage in editorTab.TabPages)
            {
                foreach (Control control in tabPage.Controls)
                {
                    if (control is FastColoredTextBoxNS.FastColoredTextBox)
                    {
                        FastColoredTextBoxNS.FastColoredTextBox editor = (FastColoredTextBoxNS.FastColoredTextBox)control;
                        // Save the text of the TextBox
                    }
                }
            }
        }

        private void newProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            return;
        }

        private void newProjectToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NewProject form = new NewProject();

            form.TopMost = true;
            form.Visible = true;
        }

        public void DisplayDirectoryTree(string root)
        {
            TreeNode rootNode;

            DirectoryInfo info = new DirectoryInfo(root);
            if (info.Exists)
            {
                rootNode = new TreeNode(info.Name);

                rootNode.Remove();

                rootNode.Name = root;
                rootNode.Tag = info;
                GetDirectories(info.GetDirectories(), rootNode);
                GetFiles(info.GetFiles(), rootNode);
                FileExplorer.Nodes.Add(rootNode);
            }
        }

        private void GetDirectories(DirectoryInfo[] subDirs, TreeNode nodeToAddTo)
        {
            TreeNode aNode;
            DirectoryInfo[] subSubDirs;
            foreach (DirectoryInfo subDir in subDirs)
            {
                aNode = new TreeNode(subDir.Name, 0, 0);
                aNode.Tag = subDir;
                aNode.ImageKey = "folder";
                subSubDirs = subDir.GetDirectories();
                if (subSubDirs.Length != 0)
                {
                    GetDirectories(subSubDirs, aNode);
                }
                GetFiles(subDir.GetFiles(), aNode);
                nodeToAddTo.Nodes.Add(aNode);
            }
        }

        private void GetFiles(FileInfo[] files, TreeNode nodeToAddTo)
        {
            TreeNode aNode;

            foreach (FileInfo file in files)
            {
                aNode = new TreeNode(file.Name);

                aNode.Tag = file;
                //Check if file is a java file
                if (file.Extension.Contains(".java"))
                {
                    aNode.ImageKey = aNode.SelectedImageKey = "java";
                }
                else if (file.Extension.Contains(".yml"))
                {
                    aNode.ImageKey = aNode.SelectedImageKey = "yaml";
                }
                else if (file.Extension.Contains(".xml"))
                {
                    aNode.ImageKey = aNode.SelectedImageKey = "yaml";
                }
                else
                {
                    aNode.ImageKey = aNode.SelectedImageKey = "folder";
                }
                nodeToAddTo.Nodes.Add(aNode);
            }
        }

        private void addFile(FileInfo file, TreeNode nodeToAddTo)
        {
            TreeNode aNode = new TreeNode(file.Name);
            aNode.Tag = file;

            //Check if file is a java file
            if (file.Extension.Contains(".java"))
            {
                aNode.ImageKey = aNode.SelectedImageKey = "java";
            }
            else if (file.Extension.Contains(".yml"))
            {
                aNode.ImageKey = aNode.SelectedImageKey = "yaml";
            }
            else if (file.Extension.Contains(".xml"))
            {
                aNode.ImageKey = aNode.SelectedImageKey = "yaml";
            }
            else
            {
                aNode.ImageKey = aNode.SelectedImageKey = "folder";
            }
            nodeToAddTo.Nodes.Add(aNode);
        }

        private void FileExplorer_DoubleClickEvent(object Object, TreeNodeMouseClickEventArgs e)
        {
            //Make sure it uses a mouse click
            //if (e.Action.HasFlag(flag: TreeViewAction.ByMouse))
            if (e.Button == MouseButtons.Left && e.Clicks == 2)
            {
                try
                {
                    TreeNode newSelected = e.Node;
                    FileInfo fileDir = (FileInfo)newSelected.Tag;

                    String fileName = fileDir.Name;

                    if (fileName.Contains(".java"))
                    {
                        //Check if it already exists in tabList


                        for (int i = 0; i < editorTab.TabCount; i++)
                        {
                            String tabNames = String.Empty;

                            tabNames = editorTab.TabPages[i].Text;

                            if (tabNames.Equals(fileName.ToString()))
                            {
                                editorTab.SelectTab(i);
                                return;
                            }
                        }

                        //Not Open
                        openNewFile.NewFile(fileDir.ToString(), fileName, editorTab, "java");

                        //Open tab that was opened in the editor

                        //Grab the tab that was opened
                        TabPage tab = editorTab.TabPages[editorTab.TabCount - 1];

                        //Open tab
                        editorTab.SelectTab(tab);
                    }
                    else if (fileName.Contains(".yml") || (fileName.Contains(".yaml")))
                    {
                        for (int i = 0; i < editorTab.TabCount; i++)
                        {
                            String tabNames = String.Empty;

                            tabNames = editorTab.TabPages[i].Text;

                            if (tabNames.Equals(fileName.ToString()))
                            {
                                editorTab.SelectTab(i);
                                return;
                            }
                        }

                        //Not Open
                        openNewFile.NewFile(fileDir.ToString(), fileName, editorTab, "yaml");

                        //Open tab that was opened in the editor

                        //Grab the tab that was opened
                        TabPage tab = editorTab.TabPages[editorTab.TabCount - 1];

                        //Open tab
                        editorTab.SelectTab(tab);
                    }
                    else if (fileName.Contains(".xml"))
                    {
                        for (int i = 0; i < editorTab.TabCount; i++)
                        {
                            String tabNames = String.Empty;

                            tabNames = editorTab.TabPages[i].Text;

                            if (tabNames.Equals(fileName.ToString()))
                            {
                                editorTab.SelectTab(i);
                                return;
                            }
                        }

                        //Not Open
                        openNewFile.NewFile(fileDir.ToString(), fileName, editorTab, "xml");

                        //Open tab that was opened in the editor

                        //Grab the tab that was opened
                        TabPage tab = editorTab.TabPages[editorTab.TabCount - 1];

                        //Open tab
                        editorTab.SelectTab(tab);
                    }
                }
                catch (InvalidCastException) { }
            }
        }

        private void Editor_MiddleClick(object sender, MouseEventArgs e)
        {

            //Get Middle click tabname and remove it from the tablist

            if (e.Button == MouseButtons.Middle)
            {
                //Get the tab that was clicked, and remove it from the tablist if the name is the same
                for (int i = 0; i < editorTab.TabCount; i++)
                {
                    //Get the tab name, and check if it is the same as the tab that was clicked
                    if (editorTab.GetTabRect(i).Contains(e.Location))
                    {
                        //If the tab is the same, remove it from the tablist, else do nothing
                        editorTab.TabPages.RemoveAt(i);
                    }
                }
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Close the current Window
            this.Close();
        }

        private void exitAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Close all windows
            Application.Exit();
        }

        //Create a FileDialog to open a file, and then open it in the editor
        public void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Java Files|*.java|YAML Files|*.yml|XML Files|*.xml";
            fileDialog.Title = "Open File";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                FileInfo file = new FileInfo(fileDialog.FileName);
                String fileName = file.Name;

                if (fileName.Contains(".java"))
                {
                    //Check if it already exists in tabList
                    for (int i = 0; i < editorTab.TabCount; i++)
                    {
                        //Lists current tab names in the editor already opened
                        String tabNames = String.Empty;

                        tabNames = editorTab.TabPages[i].Text;

                        //Check if the file is already open
                        if (tabNames.Equals(fileName.ToString()))
                        {
                            editorTab.SelectTab(i);
                            return;
                        }
                    }

                    //Add file name to ProjectSettings
                    AddToEditor.addLocationToFile(fileName, FileExplorer.TopNode.Name);


                    //Does not exist
                    openNewFile.NewFile(fileDialog.FileName, fileName, editorTab, "java");
                }
                else if (fileName.Contains(".yml"))
                {
                    for (int i = 0; i < editorTab.TabCount; i++)
                    {
                        //Lists current tab names in the editor already opened
                        String tabNames = String.Empty;

                        tabNames = editorTab.TabPages[i].Text;

                        //Check if the file is already open
                        if (tabNames.Equals(fileName.ToString()))
                        {
                            editorTab.SelectTab(i);
                            return;
                        }
                    }

                    //Does not exist
                    openNewFile.NewFile(fileDialog.FileName, fileName, editorTab, "yaml");
                }
                else if (fileName.Contains(".xml"))
                {
                    for (int i = 0; i < editorTab.TabCount; i++)
                    {
                        //Lists current tab names in the editor already opened
                        String tabNames = String.Empty;

                        tabNames = editorTab.TabPages[i].Text;

                        //Check if the file is already open
                        if (tabNames.Equals(fileName.ToString()))
                        {
                            editorTab.SelectTab(i);
                            return;
                        }
                    }

                    //Does not exist
                    openNewFile.NewFile(fileDialog.FileName, fileName, editorTab, "xml");
                }

                //Copy over the file to the project directory

                //Grab the project directory

                //Read ProjectSettings
                ProjectSettings projectSettings = new ProjectSettings();

                //Grab Directory from tree
                String projectDirectory = FileExplorer.TopNode.Name;

                //Copy file to project directory
                //Check if File already exists
                if (File.Exists(projectDirectory + "\\" + fileName))
                {
                    MessageBox.Show("File already exists in project directory");
                    return;
                }

                //Copy file to project directory, and add it to the tree

                //Copy file
                File.Copy(fileDialog.FileName, projectDirectory + "\\" + fileName);

                //Generate DirectoryInfo
                DirectoryInfo directoryInfo = new DirectoryInfo(projectDirectory);

                //Set file of directoryInfo
                FileInfo fileInfo = new FileInfo(projectDirectory + "\\" + fileName);

                //Add file to current tree
                addFile(fileInfo, FileExplorer.TopNode);
            }
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Grab current tab, and editor
            TabPage currentTab = editorTab.SelectedTab;
            FastColoredTextBoxNS.FastColoredTextBox editor = (FastColoredTextBoxNS.FastColoredTextBox)currentTab.Controls[0];

            editor.SelectAll();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Grab current tab, and editor
            TabPage currentTab = editorTab.SelectedTab;
            FastColoredTextBoxNS.FastColoredTextBox editor = (FastColoredTextBoxNS.FastColoredTextBox)currentTab.Controls[0];

            editor.Paste();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Grab current tab, and editor
            TabPage currentTab = editorTab.SelectedTab;
            FastColoredTextBoxNS.FastColoredTextBox editor = (FastColoredTextBoxNS.FastColoredTextBox)currentTab.Controls[0];

            editor.Copy();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Grab current tab, and editor
            TabPage currentTab = editorTab.SelectedTab;
            FastColoredTextBoxNS.FastColoredTextBox editor = (FastColoredTextBoxNS.FastColoredTextBox)currentTab.Controls[0];

            editor.Cut();
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Grab current tab, and editor
            TabPage currentTab = editorTab.SelectedTab;
            FastColoredTextBoxNS.FastColoredTextBox editor = (FastColoredTextBoxNS.FastColoredTextBox)currentTab.Controls[0];

            editor.ShowFindDialog();
        }

        private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Grab current tab, and editor
            TabPage currentTab = editorTab.SelectedTab;
            FastColoredTextBoxNS.FastColoredTextBox editor = (FastColoredTextBoxNS.FastColoredTextBox)currentTab.Controls[0];

            editor.ShowReplaceDialog();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Grab current tab, and editor
            TabPage currentTab = editorTab.SelectedTab;
            FastColoredTextBoxNS.FastColoredTextBox editor = (FastColoredTextBoxNS.FastColoredTextBox)currentTab.Controls[0];

            editor.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Grab current tab, and editor
            TabPage currentTab = editorTab.SelectedTab;
            FastColoredTextBoxNS.FastColoredTextBox editor = (FastColoredTextBoxNS.FastColoredTextBox)currentTab.Controls[0];

            editor.Redo();
        }

        private void openProjectToolStripMenuItem1_Click(object sender, EventArgs e)
        {
                //Set openProject.projectDirectory to the project directory

                //Adds \\ to the end of the project directory to make it a
                //valid directory path, so it doesn't change the directory,
                //and cause an error when trying to open a file.
                String projectDirectory = FileExplorer.TopNode.Name + "\\";

                //Generate OpenProject form and set the locationTxt.Text to the project directory
                OpenProject openProject = new OpenProject();
                //Set projectDirectory to the project directory
                openProject.locationTxt.Text = projectDirectory;
                //Set name of the form to the project directory,
                //to pass the project directory to the form when
                //the form is opened.
                openProject.Name = projectDirectory;

                //Show the form
                openProject.Visible = true;
        }
    }
}
