using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeEditor.Actions.Tabs
{
    internal class openNewFile
    {
        public static void NewFile(string fileDir, string fileName, TabControl editorTab, String LanguageEnding)
        {
            //Open Directory text
            string fileData = string.Empty;

            fileData = File.ReadAllText(fileDir);

            //New Tab
            newTabPage.createTabPage(fileName, editorTab, false, fileData, LanguageEnding);
        }
    }
}
