using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using CsvHelper;
using System.IO;
using System.Reflection;

namespace Ball
{
    public class CSVFiles : IWorkWithFiles
    {
        public List<BouncingBallClass> Load(string FilePath)
        {
            List<BouncingBallClass> balls = new List<BouncingBallClass>();
            CsvReader csv = new CsvReader(File.OpenText(FilePath));
            balls = csv.GetRecords<BouncingBallClass>().ToList();
            csv.Dispose();
            return balls;
        }

        public void Save(List<BouncingBallClass> balls, string FilePath)
        {
            CsvWriter csv = new CsvWriter(new StreamWriter(FilePath));
            csv.WriteRecords(balls);
            csv.Dispose();
        }

    }
}
