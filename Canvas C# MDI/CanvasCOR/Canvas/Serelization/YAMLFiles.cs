using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Yaml.Serialization;
using System.IO;
using System.Windows.Forms;

namespace Canvas
{
    public class YAMLFiles : IWorkWithFiles
    {
        public List<Control> Load(string FilePath)
        {
            List<Control> balls = new List<Control>();
            YamlSerializer reader = new YamlSerializer();
            StreamReader file = new StreamReader(FilePath);
            balls = (List<Control>)reader.Deserialize(file, typeof(List<Control>))[0];
            return balls;
        }

        public void Save(List<Control> balls, string FilePath)
        {
            YamlSerializer save = new YamlSerializer();
            FileStream file = File.Create(FilePath);
            save.Serialize(file, balls);
            file.Close();
        }
    }
}
