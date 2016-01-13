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
        public List<Control> Load(string FilePath)
        {
            List<Control> balls = new List<Control>();
            CsvReader csv = new CsvReader(File.OpenText(FilePath));
            balls = csv.GetRecords<Control>().ToList();
            csv.Dispose();
            return balls;
        }

        public void Save(List<Control> balls, string FilePath)
        {
            CsvWriter csv = new CsvWriter(new StreamWriter(FilePath));
            csv.WriteRecords(balls);
            csv.Dispose();
        }

    }
}
