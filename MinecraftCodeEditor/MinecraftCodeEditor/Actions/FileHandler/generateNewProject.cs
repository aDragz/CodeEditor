using Microsoft.VisualBasic;
using CodeEditor.Actions.FileHandler;
using CodeEditor.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace CodeEditor.Actions.FileHandler
{

    public class AppConfig
    {
        public AppSettings? Settings { get; set; }
        public AppInformation? Information { get; set; }
    }

    public class AppSettings
    {
        public string? Main { get; set; }
        public string? Location { get; set; }

    }

    public class AppInformation
    {
        public string? Name { get; set; }
        public string? Description { get; set; }

    }

    public class Location
    {
        public string? Name { get; set; } //Name of the project
        public string? Directory { get; set; } //Directory of the project
        public string? Main { get; set; } //Main File
        public string? Files { get; set; } //Files inside the project
    }

    public class Files
    {
        public string? Name { get; set; } //Name of the file
        public string? Directory { get; set; } //Directory of the file
    }

    public class readEditor
    {
        public List<Location> Locations { get; set; }
        public List<Files> Files { get; set; }
    }
}

internal class generateNewProject
{

    //static String defaultFolder = Settings.Default.ToString().Replace("DOCUMENTS", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));;
    public static void newFolder(String projectName, String projectLocation)
    {

        String projectLocationStr = (projectLocation.ToString());

        generateFolder(projectName, projectLocationStr);
        createMainDefaultFiles(projectName, projectLocationStr);
    }

    private static void generateFolder(String projectName, String projectLocation)
    {
        if (!File.Exists(projectLocation))
        {
            Directory.CreateDirectory(projectLocation.ToString());
        }
    }

    public static void generateEditorFiles(String projectName, String projectLocation)
    {
        try
        {
            var locations = new List<Location>
                {
                    new Location { Name = projectName, Directory = projectLocation, Main = ".\\main.java", Files = ""},
                };

            var files = new List<Files>
                {
                    new Files{ Name = "main.java", Directory = "." + "\\main.java"}
                };

            var serializer = new SerializerBuilder()
                .WithNamingConvention(CamelCaseNamingConvention.Instance)
                .Build();

            var combined = new { Locations = locations, Files = files };

            var yaml = serializer.Serialize(combined);
            File.WriteAllText(projectLocation.ToString() + "\\Editor.yml", yaml);
        }
        catch (Exception e)
        {
            MessageBox.Show(e.Message);
        }
    }

    public static String? GetMainFile(String projectLocation)
    {
        // Deserialize the YAML string back into a list of storage locations
        var deserializer = new DeserializerBuilder()
            .WithNamingConvention(CamelCaseNamingConvention.Instance) // Use camelCase for YAML keys
            .Build();
        var yamlFromFile = File.ReadAllText(projectLocation.ToString() + "\\Editor.yml");

        readEditor readEditor = new readEditor();

        readEditor.Files = new List<Files>();
        readEditor.Locations = new List<Location>();

        var deserializedLocations = deserializer.Deserialize<readEditor>(yamlFromFile);

        foreach (var location in deserializedLocations.Locations)
        {
            if (location.Directory == projectLocation)
            {

                return location.Main;
            }
        }

        return null;
    }

    public static String? GetNameFile(String projectLocation)
    {
        // Deserialize the YAML string back into a list of storage locations
        var deserializer = new DeserializerBuilder()
            .WithNamingConvention(CamelCaseNamingConvention.Instance) // Use camelCase for YAML keys
            .Build();
        var yamlFromFile = File.ReadAllText(projectLocation.ToString() + "\\Editor.yml");
        var deserializedLocations = deserializer.Deserialize<List<Location>>(yamlFromFile);

        foreach (var location in deserializedLocations)
        {
            if (location.Directory == projectLocation)
            {
                return location.Name;
            }
        }

        return null;
    }

    private static void createMainDefaultFiles(String projectName, String projectLocation)
    {
        //Main
        //FIRST MAIN
        String main = ("public class " + "main" + " {" + Environment.NewLine +
        "  public static void main(String[] args) {" + Environment.NewLine +
        "    System.out.println(\"Main Class!\");" + Environment.NewLine +
        "  }" + Environment.NewLine +
        "}" + Environment.NewLine);

        File.WriteAllTextAsync(projectLocation.ToString() + "\\main.java", main);
    }
}