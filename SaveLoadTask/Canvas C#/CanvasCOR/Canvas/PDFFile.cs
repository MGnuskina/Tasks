using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PQScan.ImageToPDF;
using System.Drawing.Imaging;
using System.IO;
using PQScan.PDFToImage;

namespace Canvas
{
    public class PDFFile : APictureSL
    {
        public override string[] ListOfExtentions { get; set; }

        public PDFFile()
        {
            ListOfExtentions = new string[] { "pdf" };
        }

        public override APictureSL GetHandler(string extention)
        {
            if (IsYours(extention))
            {
                return new PDFFile();
            }
            else
            {
                if (successor != null)
                {
                    return successor;
                }
                else
                {
                    throw new ArgumentNullException("Such type can't be handled");
                }
            }
        }

        public override Bitmap Load(string FileName)
        {
            PDFDocument converte = new PDFDocument();
            converte.LoadPDF(FileName);
            Bitmap bit= converte.ToImage(0);
            Bitmap nBit = new Bitmap(bit,550,400);
            return nBit;
        }

        public override void Save(string FileName, Bitmap picture)
        {
            PDFConverter converter = new PDFConverter();
            converter.PageSizeType = PageSizeMode.A4;

            string extention = (FileName.Substring(FileName.LastIndexOf('.') + 1)).ToString().ToLower();
            string JpegFileName=FileName.Substring(0, (FileName.LastIndexOf('.') + 1)).ToString()+".jpg";
            picture.Save(JpegFileName, ImageFormat.Jpeg);
            converter.CreatePDF(new string[] { JpegFileName }, FileName);
            picture.Dispose();
            //File.Delete(JpegFileName);
        }
    }
}
