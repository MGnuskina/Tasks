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
        public List<BouncingBallClass> Load(string FilePath)
        {
            List<BouncingBallClass> balls = new List<BouncingBallClass>();
            XmlSerializer reader = new XmlSerializer(typeof(List<BouncingBallClass>));
            StreamReader file = new StreamReader(FilePath);
            balls=(List<BouncingBallClass>)reader.Deserialize(file);
            return balls;
        }

        public void Save(List<BouncingBallClass> balls, string FilePath)
        {
            XmlSerializer writer = new XmlSerializer(typeof(List<BouncingBallClass>));
            FileStream file = File.Create(FilePath);
            writer.Serialize(file, balls);
            file.Close();
        }
    }
}
