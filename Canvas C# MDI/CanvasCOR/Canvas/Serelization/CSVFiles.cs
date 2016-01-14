using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using CsvHelper;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace Canvas
{
    public class CSVFiles : IWorkWithFiles
    {
        public List<ShapeData> Load(string FilePath)
        {
            List<ShapeData> balls = new List<ShapeData>();
            CsvReader csv = new CsvReader(File.OpenText(FilePath));
            balls = csv.GetRecords<ShapeData>().ToList();
            csv.Dispose();
            return balls;
        }

        public void Save(List<ShapeData> balls, string FilePath)
        {
            CsvWriter csv = new CsvWriter(new StreamWriter(FilePath));
            csv.WriteRecords(balls);
            csv.Dispose();
        }

    }
}
