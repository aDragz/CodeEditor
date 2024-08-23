using FastColoredTextBoxNS.Input;
using CodeEditor.Actions.Editor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeEditor.Actions
{
    public partial class newTabPage
    {

        public static Panel createTabPage(String name, TabControl tab, Boolean firstStartUp, String firstText, String language)
        {
            // Create a new TabPage
            TabPage tabPage = new TabPage();

            //Text Editor
            FastColoredTextBoxNS.FastColoredTextBox textBoxNS = createEditor.create(language);

            //Document Map
            FastColoredTextBoxNS.DocumentMap documentMap = createDocumentMap.generateDocumentMap(textBoxNS);

            //Add Text Editor
            tabPage.Controls.Add(textBoxNS);
            tabPage.Controls.Add(documentMap);

            //Add tab page
            if (firstStartUp)
            {
                tabPage.Text = "main.java";
                textBoxNS.Text = CreateStartText("main");

            }
            else
            {
                tabPage.Text = name;

                if (firstText.Length == 0)
                {
                    textBoxNS.Text = CreateStartText(name);
                }
                else
                {
                    textBoxNS.Text = firstText;
                }
            }

            //Add tab page
            tab.TabPages.Add(tabPage);
            return new Panel();
        }

        public static String CreateStartText(String name)
        {

            //SECOND MAIN
            return ("public class " + "main" + " {" + Environment.NewLine +
            "  public static void main(String[] args) {" + Environment.NewLine +
            "    System.out.println(\"Main Class!\");" + Environment.NewLine +
            "  }" + Environment.NewLine +
            "}" + Environment.NewLine);
        }
    }
}
