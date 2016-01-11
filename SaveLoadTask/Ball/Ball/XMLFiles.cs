using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Ball
{
    public class XMLFiles : IWorkWithFiles
    {
        public List<MBall> Load(string FilePath)
        {
            List<MBall> balls = new List<MBall>();
            XmlSerializer reader = new XmlSerializer(typeof(List<MBall>));
            StreamReader file = new StreamReader(FilePath);
            balls = (List<MBall>)reader.Deserialize(file);
            return balls;
        }

        public void Save(List<MBall> balls, string FilePath)
        {
            XmlSerializer writer = new XmlSerializer(typeof(List<MBall>));
            FileStream file = File.Create(FilePath);
            writer.Serialize(file, balls);
            file.Close();
        }
    }
}
