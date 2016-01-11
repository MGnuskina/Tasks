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
        public List<MBall> Load(string FilePath)
        {
            List<MBall> balls = new List<MBall>();
            YamlSerializer reader = new YamlSerializer();
            StreamReader file = new StreamReader(FilePath);
            balls = (List<MBall>)reader.Deserialize(file, typeof(List<MBall>))[0];
            return balls;
        }

        public void Save(List<MBall> balls, string FilePath)
        {
            YamlSerializer save = new YamlSerializer();
            FileStream file = File.Create(FilePath);
            save.Serialize(file, balls);
            file.Close();
        }
    }
}
