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
        public List<ShapeData> Load(string FilePath)
        {
            List<ShapeData> balls = new List<ShapeData>();
            DataContractJsonSerializer reader = new DataContractJsonSerializer(typeof(List<ShapeData>));
            FileStream file = File.Open(FilePath, FileMode.Open);
            balls = (List<ShapeData>)reader.ReadObject(file);
            return balls;
        }

        public void Save(List<ShapeData> balls, string FilePath)
        {
            DataContractJsonSerializer writer = new DataContractJsonSerializer(typeof(List<ShapeData>));
            FileStream file = File.Create(FilePath);
            writer.WriteObject(file, balls);
            file.Close();
        }
    }
}
