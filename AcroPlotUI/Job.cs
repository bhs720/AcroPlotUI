using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace AcroPlotUI
{
    public class Job
    {
        public delegate void ProcessExitedEventHandler(Job job);

        public event ProcessExitedEventHandler ProcessExited;

        public int Resolution { get; set; }

        public int FirstPage { get; set; }

        public int LastPage { get; set; }

        public bool Quiet { get; set; }

        public DitherType DitherType { get; set; }

        public bool RemoveWhiteSpace { get; set; }

        public double Zoom { get; set; }

        public int Brightness { get; set; }

        public int MinLineWidth { get; set; }

        public string PDFPassword { get; set; }

        public bool DisplayProgressDialog { get; set; }

        public bool DisplayMissingFontDialog { get; set; }

        public bool DisplayErrorDialog { get; set; }

        public OutputDevice OutputDevice { get; set; }

        public string InputFileName { get; set; }

        public string OutputFileName { get; set; }

        public PdfFile PdfFile { get; set; }

        public Process Process { get; private set; }

        public DateTime StartTime { get; private set; }

        public DateTime ExitTime { get; private set; }

        public JobStatus Status { get; set; }

        public int RetryCount { get; set; }

        public int EventInvocationCount
        {
            get
            {
                if (this.ProcessExited == null)
                {
                    return 0;
                }

                return this.ProcessExited.GetInvocationList().Length;
            }
        }

        public bool ProcessingSucceeded
        {
            get
            {
                return File.Exists(this.OutputFileName) && (new FileInfo(this.OutputFileName).Length > 0);
            }
        }

        public string CliArgs
        {
            get
            {
                StringBuilder args = new StringBuilder();
                args.AppendFormat("-sOutputFile=\"{0}\" ", this.OutputFileName);
                args.AppendFormat("-r{0} ", this.Resolution);
                args.AppendFormat("-dFirstPage={0} ", this.FirstPage);
                args.AppendFormat("-dLastPage={0} ", this.LastPage);
                if (this.Quiet)
                {
                    args.Append("-dQUIET ");
                }

                args.AppendFormat("-p{0} ", this.DitherType.CliName);
                if (this.RemoveWhiteSpace)
                {
                    args.Append("-dRemoveWhiteSpace ");
                }

                args.AppendFormat("-dScale={0} ", this.Zoom);
                args.AppendFormat("-dBrightness={0} ", this.Brightness);
                args.AppendFormat("-dMinLineWidth={0} ", this.MinLineWidth);
                if (!string.IsNullOrEmpty(this.PDFPassword))
                {
                    args.AppendFormat("-sPDFPassword=\"{0}\" ", this.PDFPassword);
                }

                args.AppendFormat("-dDialogProgress={0} ", this.DisplayProgressDialog ? "1" : "0");
                args.AppendFormat("-dDialogFont={0} ", this.DisplayMissingFontDialog ? "1" : "0");
                args.AppendFormat("-dDialogErrors={0} ", this.DisplayErrorDialog ? "1" : "0");
                args.AppendFormat("-sDEVICE={0} ", this.OutputDevice.CliName);
                args.AppendFormat("\"{0}\"", this.InputFileName);
                return args.ToString();
            }
        }

        public Job Clone()
        {
            return new Job
            {
                Resolution = this.Resolution,
                FirstPage = this.FirstPage,
                LastPage = this.LastPage,
                Quiet = this.Quiet,
                DitherType = this.DitherType,
                RemoveWhiteSpace = this.RemoveWhiteSpace,
                Zoom = this.Zoom,
                Brightness = this.Brightness,
                MinLineWidth = this.MinLineWidth,
                PDFPassword = this.PDFPassword,
                DisplayProgressDialog = this.DisplayProgressDialog,
                DisplayMissingFontDialog = this.DisplayMissingFontDialog,
                DisplayErrorDialog = this.DisplayErrorDialog,
                OutputDevice = this.OutputDevice,
                InputFileName = this.InputFileName,
                OutputFileName = this.OutputFileName
            };
        }

        public void Start()
        {
            if (this.Process != null)
            {
                this.Process.Dispose();
            }

            this.Process = new Process();
            this.Process.EnableRaisingEvents = true;
            this.Process.StartInfo.FileName = Properties.Settings.Default.AcroPlotPath;
            this.Process.StartInfo.Arguments = this.CliArgs;
            this.Process.Exited += this.Proc_Exited;
            this.Process.StartInfo.RedirectStandardError = true;
            this.Process.StartInfo.RedirectStandardOutput = true;
            this.Process.StartInfo.UseShellExecute = false;
            this.Process.Start();
            this.Process.BeginErrorReadLine();
            this.Process.BeginOutputReadLine();
        }

        public void Proc_Exited(object sender, EventArgs e)
        {
            this.Process.WaitForExit();
            this.StartTime = this.Process.StartTime;
            this.ExitTime = this.Process.ExitTime;
            this.Process.Dispose();
            this.ProcessExited.Invoke(this);
        }
    }
}
