using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canvas
{
    public static class LSFactory
    {
        public static IWorkWithFiles findExtention(string path)
        {
            IWorkWithFiles fileOperation;
            string extention = (path.Substring(path.LastIndexOf('.') + 1)).ToString();
            switch (extention)
            {
                case "csv":
                    fileOperation = new CSVFiles();
                    break;
                case "yaml":
                    fileOperation = new YAMLFiles();
                    break;
                case "json": 
                    fileOperation = new JSONFiles();
                    break;
                default:
                    fileOperation = new XMLFiles();
                    break;
            }
            return fileOperation;
        }
    }
}
