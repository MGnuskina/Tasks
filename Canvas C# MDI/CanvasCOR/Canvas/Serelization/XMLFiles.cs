using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace Canvas
{
    public class XMLFiles : IWorkWithFiles
    {
        public List<ShapeData> Load(string FilePath)
        {
            List<ShapeData> balls = new List<ShapeData>();
            XmlSerializer reader = new XmlSerializer(typeof(List<ShapeData>));
            StreamReader file = new StreamReader(FilePath);
            balls = (List<ShapeData>)reader.Deserialize(file);
            return balls;
        }

        public void Save(List<ShapeData> balls, string FilePath)
        {
            XmlSerializer writer = new XmlSerializer(typeof(List<ShapeData>));
            FileStream file = File.Create(FilePath);
            writer.Serialize(file, balls);
            file.Close();
        }
    }
}
