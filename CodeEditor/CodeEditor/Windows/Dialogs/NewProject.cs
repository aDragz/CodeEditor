using CodeEditor.Actions;
using CodeEditor.Actions.FileHandler;
using CodeEditor.Actions.FileHandler.Settings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CodeEditor.Windows.Dialogs
{
    public partial class NewProject : Form

    {

        String defaultProjectDirectory = @Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/test";
        ToolStripLabel bottomLabel = new ToolStripLabel();

        public NewProject()
        {
            InitializeComponent();
        }

        private async void okBtn_Click(object sender, EventArgs e)
        {
            if (nameTxt.Text.Trim().Length > 0)
            {
                if (locationTxt.Text.Trim().Length > 0)
                {
                    CodeEditor editor = new CodeEditor();

                    //Set name as ProjectName
                    editor.Name = nameTxt.Text;

                    //TODO: Make language changable through new project dialog
                    newTabPage.createTabPage(nameTxt.Text, editor.editorTab, true, "", "java");

                    //Make editor start at middle of screen
                    editor.StartPosition = FormStartPosition.CenterScreen;
                    editor.Text = "Code Editor - " + locationTxt.Text;

                    try
                    {
                        //Create Default Project
                        generateNewProject.newFolder(nameTxt.Text, locationTxt.Text);
                        generateNewProject.generateEditorFiles(nameTxt.Text, locationTxt.Text);

                        ProjectSettings.AddStringToSettings(locationTxt.Text);
                    }
                    catch (Exception)
                    {
                        NoLocationFound();
                        return;
                    }

                    editor.DisplayDirectoryTree(locationTxt.Text);

                    //Display editor on top
                    this.TopMost = false;
                    //Make editor visible
                    editor.Visible = true;
                    //Wait so it doesn't disappear at the same time, as it looks weird
                    await Task.Delay(500);
                    this.Visible = false;
                }
                else
                {
                    NoLocationFound();
                }
            }
            else
            {
                NoFileFound();
            }
        }
        private void selectFolderBtn_Click(object sender, EventArgs e)
        {
            if (nameTxt.Text.Trim().Length > 0)
            {
                using (FolderBrowserDialog openFileDialog = new FolderBrowserDialog())
                {
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Get the path of the selected file
                        string filePath = openFileDialog.SelectedPath.ToString() + "\\" + nameTxt.Text.ToString();

                        // Put the file path into the TextBox
                        locationTxt.Text = filePath;
                    }
                }
            }
            else
            {
                NoFileFound();
            }
        }

        private void NoFileFound()
        {
            //Testing right now, will add a better feature later
            //Will probably be a strip at bottom
            bottomLabel.Text = "Please Enter File Name";

            statusStrip1.Items.Clear();
            statusStrip1.Items.Add(bottomLabel);
        }

        private void NoLocationFound()
        {
            //Testing right now, will add a better feature later
            //Will probably be a strip at bottom
            bottomLabel.Text = "Please Enter Location Name";

            statusStrip1.Items.Clear();
            statusStrip1.Items.Add(bottomLabel);
        }
    }
}
