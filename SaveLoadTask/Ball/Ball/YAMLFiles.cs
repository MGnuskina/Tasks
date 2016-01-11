using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Yaml.Serialization;
using System.IO;

namespace Ball
{
    public class YAMLFiles : IWorkWithFiles
    {
        public List<BouncingBallClass> Load(string FilePath)
        {
            List<BouncingBallClass> balls = new List<BouncingBallClass>();
            YamlSerializer reader = new YamlSerializer();
            StreamReader file = new StreamReader(FilePath);
            balls = (List<BouncingBallClass>)reader.Deserialize(file, typeof(List<BouncingBallClass>))[0];
            return balls;
        }

        public void Save(List<BouncingBallClass> balls, string FilePath)
        {
            YamlSerializer save = new YamlSerializer();
            FileStream file = File.Create(FilePath);
            save.Serialize(file, balls);
            file.Close();
        }
    }
}
