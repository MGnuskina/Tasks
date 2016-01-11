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
        public List<MBall> Load(string FilePath)
        {
            List<MBall> balls = new List<MBall>();
            CsvReader csv = new CsvReader(File.OpenText(FilePath));
            balls = csv.GetRecords<MBall>().ToList();
            csv.Dispose();
            return balls;
        }

        public void Save(List<MBall> balls, string FilePath)
        {
            CsvWriter csv = new CsvWriter(new StreamWriter(FilePath));
            csv.WriteRecords(balls);
            csv.Dispose();
        }

    }
}
