using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Windows.Forms;

namespace Canvas
{
    public class JSONFiles : IWorkWithFiles
    {
        public List<Control> Load(string FilePath)
        {
            List<Control> balls = new List<Control>();
            DataContractJsonSerializer reader = new DataContractJsonSerializer(typeof(List<Control>));
            FileStream file = File.Open(FilePath, FileMode.Open);
            balls = (List<Control>)reader.ReadObject(file);
            return balls;
        }

        public void Save(List<Control> balls, string FilePath)
        {
            DataContractJsonSerializer writer = new DataContractJsonSerializer(typeof(List<Control>));
            FileStream file = File.Create(FilePath);
            writer.WriteObject(file, balls);
            file.Close();
        }
    }
}
