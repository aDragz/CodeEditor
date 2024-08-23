using CodeEditor.Actions;
using CodeEditor.Actions.Editor;
using CodeEditor.Actions.FileHandler;
using CodeEditor.Actions.FileHandler.Settings;
using CodeEditor.Actions.Tabs;
using CodeEditor.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YamlDotNet.Core;
using YamlDotNet.Serialization;

namespace CodeEditor.Windows.Dialogs
{
    public partial class StartUp : Form
    {
        public StartUp()
        {
            InitializeComponent();
            InitializeDynamicPanels();
        }

        private async void label1_Click(object sender, EventArgs e)
        {
            NewProject newProject = new NewProject();

            newProject.Visible = true;
            //Wait so it doesn't disappear at the same time, as it looks weird
            await Task.Delay(500);
            this.Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //Grab Recent Project

            String recentProject = Properties.Settings.Default.PreviousWindow;

            //Grab Data
        }

        private void InitializeDynamicPanels()
        {
            // Example collection of strings
            List<string> items = new List<string>();

            items.AddRange(ProjectSettings.GetListFromSettings());

            int yOffset = 10; // Initial vertical offset

            foreach (var item in items)
            {
                if (Directory.Exists(item.ToString()))
                {
                    #region Context Strip
                    //Context Strip
                    ContextMenuStrip recentStrip = new ContextMenuStrip();
                    ToolStripMenuItem openMenuItem = new ToolStripMenuItem();
                    ToolStripMenuItem removeFromRecentToolStripMenuItem = new ToolStripMenuItem();

                    recentStrip.Items.Add(openMenuItem);
                    //Add divider
                    recentStrip.Items.Add(new ToolStripSeparator());
                    recentStrip.Items.Add(removeFromRecentToolStripMenuItem);
                    
                    openMenuItem.Text = "Open Project";
                    removeFromRecentToolStripMenuItem.Text = "Remove from Recent";
                    #endregion

                    #region generate panels

                    // Create a new panel
                    Panel itemPanel = new Panel
                    {
                        Name = item.ToString(),
                        Size = new Size(1000, 100),
                        Location = new Point(10, yOffset),
                        BorderStyle = BorderStyle.FixedSingle,
                        ContextMenuStrip = recentStrip
                    };

                    // Create a button
                    Button itemButton = new Button
                    {
                        Name = item.ToString(),
                        Text = "Open Project",
                        Size = new Size(150, 50),
                        Location = new Point(825, 25), // Positioned at the bottom of the panel
                        ContextMenuStrip = recentStrip
                    };

                    // Create a label for the text
                    Label itemLabel = new Label
                    {
                        MaximumSize = new Size(800, 80),

                        Name = item.ToString(),
                        Text = item,
                        Location = new Point(10, 10), // Positioned at the top of the panel
                        AutoSize = true,
                        ContextMenuStrip = recentStrip
                    };

                    // Add the button and label to the panel
                    itemPanel.Controls.Add(itemButton);
                    itemPanel.Controls.Add(itemLabel);

                    // Add the panel to the form
                    panel1.Controls.Add(itemPanel);

                    // Adjust the vertical offset for the next panel
                    yOffset += itemPanel.Height + 10;
                    #endregion

                    #region Click Event
                    itemLabel.DoubleClick += (sender, e) =>
                    {
                        //Read generateNewProject yaml read
                        openProject(item);
                    };

                    itemButton.Click += (sender, e) =>
                    {
                        //Read generateNewProject yaml read
                        openProject(item);
                    };

                    itemPanel.DoubleClick += (sender, e) =>
                    {
                        //Read generateNewProject yaml read
                        openProject(item);
                    };
                    #endregion

                    #region ContextStripClick Event
                    //Check if clicked removeFromRecentToolStripMenuItem
                    removeFromRecentToolStripMenuItem.Click += (sender, e) =>
                    {
                        //Grab name, and remove from settings
                        List<string> items = new List<string>();

                        //Get all items from settings, and add to items
                        items.AddRange(ProjectSettings.GetListFromSettings());

                        //Remove item from items 
                        items.Remove(item.ToString());

                        //Remove from settings, as items is now updated
                        ProjectSettings.AddListToSettings(items);

                        //Make panel invisible
                        itemPanel.Visible = false;

                        //Move all other panels up
                        foreach (Control control in panel1.Controls)
                        {
                            //Grab Location, and check if it's below the current panel
                            if (control.Location.Y > itemPanel.Location.Y)
                            {
                                //Move up 110 pixels (height of panel)
                                control.Location = new Point(control.Location.X, control.Location.Y - 110);
                            }
                        }

                        return;
                    };

                    openMenuItem.Click += (sender, e) =>
                    {
                        //Read generateNewProject yaml read
                        openProject(item);
                    };
                    #endregion
                }
            }
        }

        public async void openProject(String projectRawLocation)
        {

            //Get Location of Project
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            try
            {
                String projectLocationYaml = generateNewProject.GetMainFile(projectRawLocation);

                String projectNameYaml = generateNewProject.GetMainFile(projectRawLocation);

                String mainProjectLocation = projectLocationYaml;
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
                if (projectLocationYaml == null || projectNameYaml == null)
                {
                    MessageBox.Show("Error: Project Location or Name is null");
                    return;
                }

                CodeEditor editor = new CodeEditor();

                //Open Project
                openExistingProject.createTabPage(projectNameYaml, projectRawLocation, editor.editorTab, "java");

                //Set name as ProjectName
                editor.Name = Text;

                //Make editor start at middle of screen
                editor.StartPosition = FormStartPosition.CenterScreen;
                editor.Text = "Code Editor - " + projectRawLocation;

                editor.DisplayDirectoryTree(projectRawLocation);


                //Display editor on top
                this.TopMost = false;
                //Make editor visible
                editor.Visible = true;
                //Wait so it doesn't disappear at the same time, as it looks weird
                await Task.Delay(500);
                this.Visible = false;
            }
            catch (YamlException e)
            {
                MessageBox.Show("Error: " + "Cannot read " + projectRawLocation + "\\editor.yml");
            } catch (FileNotFoundException e)
            {
                MessageBox.Show("Error: " + "Cannot find " + projectRawLocation + "\\editor.yml");
            }
        }

        private void removeFromRecentToolStripMenuItem_Click(object sender, EventArgs e)
        {          
            //Grab name, and remove from settings
            List<string> items = new List<string>();

            items.AddRange(ProjectSettings.GetListFromSettings());

            //Remove from settings
#pragma warning disable CS8604 // Converting null literal or possible null value to non-nullable type.
            items.Remove(e.ToString());
#pragma warning restore CS8604 // Converting null literal or possible null value to non-nullable type.
            MessageBox.Show("Removed from recent projects" + " / " + e.GetType().Name.ToString());
        }
    }
}
