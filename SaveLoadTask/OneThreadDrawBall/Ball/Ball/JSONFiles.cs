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
        public List<BouncingBallClass> Load(string FilePath)
        {
            List<BouncingBallClass> balls = new List<BouncingBallClass>();
            DataContractJsonSerializer reader = new DataContractJsonSerializer(typeof(List<BouncingBallClass>));
            FileStream file = File.Open(FilePath, FileMode.Open);
            balls = (List<BouncingBallClass>)reader.ReadObject(file);
            return balls;
        }

        public void Save(List<BouncingBallClass> balls, string FilePath)
        {
            DataContractJsonSerializer writer = new DataContractJsonSerializer (typeof(List<BouncingBallClass>));
            FileStream file = File.Create(FilePath);
            writer.WriteObject(file, balls);
            file.Close();
        }
    }
}
