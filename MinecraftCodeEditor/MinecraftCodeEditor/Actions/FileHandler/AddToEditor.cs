using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YamlDotNet.Serialization.NamingConventions;
using YamlDotNet.Serialization;

namespace CodeEditor.Actions.FileHandler
{

    internal class AddToEditor
    {
        public static void addLocationToFile(String fileName, String projectDirectory)
        {
            //Grab editor.yml in directory
            String editorYml = projectDirectory.ToString() + "/Editor.yml";
            
            // Deserialize the YAML string back into a list of storage locations
            var deserializer = new DeserializerBuilder()
                .WithNamingConvention(CamelCaseNamingConvention.Instance) // Use camelCase for YAML keys
                .Build();
            var yamlFromFile = File.ReadAllText(projectDirectory.ToString() + "\\Editor.yml");

            readEditor readEditor = new readEditor();

            readEditor.Files = new List<Files>();
            readEditor.Locations = new List<Location>();

            var deserializedLocations = deserializer.Deserialize<readEditor>(yamlFromFile);


            deserializedLocations.Files.Add(new Files { Name = fileName, Directory = "." + "\\" +fileName });

            var serializer = new SerializerBuilder()
                .WithNamingConvention(CamelCaseNamingConvention.Instance)
                .Build();

            var combined = new { deserializedLocations.Locations, deserializedLocations.Files };

            var yaml = serializer.Serialize(combined);
            File.WriteAllText(projectDirectory.ToString() + "\\Editor.yml", yaml);

            return;
        }
    }
}
