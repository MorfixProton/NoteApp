using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NoteApp
{
    public static class ProjectManager
    {
        private static readonly string SavePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "NoteApp.notes");

        public static void SaveToFile(Project project)
        {
            var serializer = new JsonSerializer();

            using (var writer = File.CreateText(SavePath))
            {
                serializer.Serialize(writer, project);
            }
        }

        public static Project LoadFromFile()
        {
            if (File.Exists(SavePath))
            {
                var serializer = new JsonSerializer();

                using (var reader = File.OpenText(SavePath))
                {
                    return (Project)serializer.Deserialize(reader, typeof(Project));
                }
            }
            else
            {
                return new Project();
            }
        }
    }
}