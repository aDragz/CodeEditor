using FastColoredTextBoxNS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeEditor.Actions.Editor
{
    internal class createDocumentMap
    {
        public static DocumentMap generateDocumentMap(FastColoredTextBox fastColoredTextBox)
        {
            DocumentMap documentMap = new DocumentMap();

            documentMap.Target = fastColoredTextBox;
            documentMap.Dock = DockStyle.Right;

            return documentMap;
        }
    }
}
