using FastColoredTextBoxNS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KEYS = System.Windows.Forms.Keys;

namespace CodeEditor.Actions.Editor
{
    internal class createEditor
    {
        public static FastColoredTextBox create(String language)
        {
            //Text Editor for the new tab
            FastColoredTextBox textBoxNS = new FastColoredTextBox();

            //Checks the language of the file and sets the language of the text editor
            if (language.Equals("java"))
            {
                textBoxNS.Language = FastColoredTextBoxNS.Text.Language.JS;
            } else if (language.Equals("yml") || (language.Equals("xml")))
            {
                //XML is the closest language to YAML, It should still work fine.
                textBoxNS.Language = FastColoredTextBoxNS.Text.Language.XML;
            }

            //Remove due to ArgumentOutOfRangeException bug in FastColoredTextBox
            textBoxNS.HotkeysMapping.Remove(KEYS.Alt | KEYS.Up);
            textBoxNS.HotkeysMapping.Remove(KEYS.Alt | KEYS.Down);

            //Dock text editor inside tab page
            textBoxNS.Dock = DockStyle.Fill;

            return textBoxNS;
        }
    }
}
