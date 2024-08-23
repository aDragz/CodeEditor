using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YamlDotNet.Serialization;

namespace CodeEditor.Actions.FileHandler.Settings
{
    internal class ProjectSettings
    {
        public static void AddStringToSettings(String toAdd)
        {
            List<string> list = new List<string>();

            
            list.AddRange(GetListFromSettings());

            //Add String into the list
            list.Add(toAdd);

            // Convert the List<string> to a StringCollection
            var stringCollection = new StringCollection();
            stringCollection.AddRange(list.ToArray());

            // Add the StringCollection to the settings
            Properties.Settings.Default.ProjectList = stringCollection;
            Properties.Settings.Default.Save();
        }

        public static void AddListToSettings(List<String> toAdd)
        {
            List<string> list = new List<string>();

            list.AddRange(toAdd);

            // Convert the List<string> to a StringCollection
            var stringCollection = new StringCollection();
            stringCollection.AddRange(list.ToArray());

            // Add the StringCollection to the settings
            Properties.Settings.Default.ProjectList = stringCollection;
            Properties.Settings.Default.Save();
        }


        public static List<string> GetListFromSettings()
        {
            // Get the StringCollection from the settings
            StringCollection stringCollection = Properties.Settings.Default.ProjectList;
            List<string> list = new List<string>();

            if ((stringCollection != null))
            {
                list.AddRange(stringCollection.Cast<string>().ToList());

                return list;
            }
            else
            {
                return list;
            }
        }
    }
}
