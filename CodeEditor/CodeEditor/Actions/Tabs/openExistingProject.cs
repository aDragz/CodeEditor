using CodeEditor.Actions.Editor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeEditor.Actions.Tabs
{
    internal class openExistingProject
    {
        public static Panel createTabPage(String projectRawname, String projectLocation, TabControl tab, String language)
        {
            // Create a new TabPage
            TabPage tabPage = new TabPage();

            //Text Editor
            FastColoredTextBoxNS.FastColoredTextBox textBoxNS = createEditor.create(language);

            //Document Map for textBoxNS
            FastColoredTextBoxNS.DocumentMap documentMap = createDocumentMap.generateDocumentMap(textBoxNS);

            //Add Text Editor
            tabPage.Controls.Add(textBoxNS);
            tabPage.Controls.Add(documentMap);

            //Read projectLocation to textBoxNS
            string fileData = string.Empty;

            //Location = Location of the project
            //Raw Name = Main.java
            fileData = File.ReadAllText(projectLocation + projectRawname);

            //Set fileData for textBoxNS text
            textBoxNS.Text = fileData;

            //Add tab page
            tabPage.Text = projectRawname.Replace(".\\", "");
            tab.TabPages.Add(tabPage);
            return new Panel();
        }
    }
}