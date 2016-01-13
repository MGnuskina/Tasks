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
        public List<Control> Load(string FilePath)
        {
            List<Control> balls = new List<Control>();
            XmlSerializer reader = new XmlSerializer(typeof(List<Control>));
            StreamReader file = new StreamReader(FilePath);
            balls = (List<Control>)reader.Deserialize(file);
            return balls;
        }

        public void Save(List<Control> balls, string FilePath)
        {
            XmlSerializer writer = new XmlSerializer(typeof(List<Control>));
            FileStream file = File.Create(FilePath);
            writer.Serialize(file, balls);
            file.Close();
        }
    }
}
