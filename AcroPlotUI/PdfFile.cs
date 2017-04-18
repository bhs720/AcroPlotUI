using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using MuPDFLib;

namespace AcroPlotUI
{
    public class PdfFile
    {
        public PdfFile(string filename, string password)
        {
            this.Filename = filename;
            this.Password = password;
            this.Refs = new List<Job>();
            this.Pages = new List<PdfPage>();
            MuPDF pdf = new MuPDF(filename, password);
            this.PageCount = pdf.PageCount;
            for (int i = 0; i < this.PageCount; i++)
            {
                pdf.Page = i + 1;
                double width = pdf.Width / 72.0D;
                double height = pdf.Height / 72.0D;
                PdfPage page = new PdfPage(this, i + 1, width, height);
                this.Pages.Add(page);
            }
        }

        public string Filename { get; private set; }

        public string FilenameCached { get; private set; }

        public string Password { get; private set; }

        public int PageCount { get; private set; }

        public List<PdfPage> Pages { get; private set; }

        public List<Job> Refs { get; private set; }

        public void AddRef(Job job)
        {
            this.Refs.Add(job);
            if (string.IsNullOrEmpty(this.FilenameCached))
            {
                this.FilenameCached = Path.GetTempFileName() + ".pdf";
                Debug.Print("Copy cache file {0} -> {1}", this.Filename, this.FilenameCached);
                File.Copy(this.Filename, this.FilenameCached, true);
            }
        }

        public void DelRef(Job job)
        {
            this.Refs.Remove(job);
            Debug.Print("RefCount={0}", this.Refs.Count);
            if (this.Refs.Count == 0)
            {
                Debug.Print("Del cache file {0}", this.FilenameCached);
                File.Delete(this.FilenameCached);
                this.FilenameCached = null;
            }
        }
    }
}
