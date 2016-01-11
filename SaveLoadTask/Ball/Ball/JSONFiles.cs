using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace Ball
{
    public class JSONFiles : IWorkWithFiles
    {
        public List<MBall> Load(string FilePath)
        {
            List<MBall> balls = new List<MBall>();
            DataContractJsonSerializer reader = new DataContractJsonSerializer(typeof(List<MBall>));
            FileStream file = File.Open(FilePath, FileMode.Open);
            balls = (List<MBall>)reader.ReadObject(file);
            return balls;
        }

        public void Save(List<MBall> balls, string FilePath)
        {
            DataContractJsonSerializer writer = new DataContractJsonSerializer(typeof(List<MBall>));
            FileStream file = File.Create(FilePath);
            writer.WriteObject(file, balls);
            file.Close();
        }
    }
}
