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
        public List<ShapeData> Load(string FilePath)
        {
            List<ShapeData> balls = new List<ShapeData>();
            YamlSerializer reader = new YamlSerializer();
            StreamReader file = new StreamReader(FilePath);
            balls = (List<ShapeData>)reader.Deserialize(file, typeof(List<ShapeData>))[0];
            return balls;
        }

        public void Save(List<ShapeData> balls, string FilePath)
        {
            YamlSerializer save = new YamlSerializer();
            FileStream file = File.Create(FilePath);
            save.Serialize(file, balls);
            file.Close();
        }
    }
}
