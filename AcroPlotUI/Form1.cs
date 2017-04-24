using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcroPlotUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.lblStatus.Text = "Drag and drop files to begin.";
            this.ddDitherType.DataSource = DitherType.Types;
            this.ddOutputDevice.DataSource = OutputDevice.Devices;
            this.LoadJobSettings();
            this.LoadProgramSettings();
            this.SetupJobUI();
            this.SetupQueueUI();
            this.fitToToolStripMenuItem.DropDownItems.AddRange(ZoomFitPageSize.Menu);
            this.Text = string.Format("AcroPlotUI {0}", System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString());
        }

        private void SetupJobUI()
        {
            this.gridJobSetup.RowsAdded += (object sender, DataGridViewRowsAddedEventArgs e) =>
            {
                this.lblStatus.Text = string.Format("Total Pages: {0}", this.gridJobSetup.Rows.Count);
            };

            this.gridJobSetup.RowsRemoved += (object sender, DataGridViewRowsRemovedEventArgs e) =>
            {
                if (this.gridJobSetup.Rows.Count == 0)
                {
                    this.lblStatus.Text = string.Empty;
                }
                else
                {
                    this.lblStatus.Text = string.Format("Total Pages: {0}", this.gridJobSetup.Rows.Count);
                }
            };
        }

        private void SetupQueueUI()
        {
            this.lblQueue.Text = "Queue: Idle";

            this.gridQueue.SelectionChanged += (object sender, EventArgs e) =>
            {
                this.gridQueue.ClearSelection();
            };

            this.gridQueue.MouseDown += (object sender, MouseEventArgs e) =>
            {
                this.cbAutoScroll.Checked = false;
            };

            ProcessQueue.QueueStatusChanged += (QueueStatus status, int queued) =>
            {
                Debug.Print("QueueStatusChanged");
                this.statusStrip1.InvokeIfRequired(delegate
                {
                    if (status == QueueStatus.Processing)
                    {
                        this.lblQueue.Text = string.Format("Queue: Processing ({0})", queued);
                    }
                    else if (status == QueueStatus.Paused)
                    {
                        this.lblQueue.Text = "Queue: Paused";
                    }
                    else if (status == QueueStatus.Idle)
                    {
                        this.lblQueue.Text = string.Format("Queue: Idle");
                        int count = this.gridQueue.Rows.Cast<DataGridViewRow>().Sum(x => (x.Tag as Job).EventInvocationCount);
                        Debug.Print("Queue Idle. Job Event Invocation Count = {0}", count);
                    }
                });
            };

            ProcessQueue.JobStatusChanged += (Job job) =>
            {
                Debug.Print("JobStatusChanged");
                this.gridQueue.InvokeIfRequired(delegate
                {
                    if (job.Status == JobStatus.Queued)
                    {
                        string path = Path.GetDirectoryName(job.OutputFileName);
                        string filename = Path.GetFileName(job.OutputFileName);
                        string pageNum = job.FirstPage.ToString();
                        string status = job.Status.DisplayName;
                        int rowIndex = this.gridQueue.Rows.Add(path, filename, pageNum, status);
                        this.gridQueue.Rows[rowIndex].Tag = job;
                        this.gridQueue.Rows[rowIndex].DefaultCellStyle.BackColor = Color.LightYellow;
                    }
                    else
                    {
                        DataGridViewRow row = this.gridQueue.Rows.Cast<DataGridViewRow>().First(x => job.Equals(x.Tag as Job));
                        row.Cells["QueueJobStatus"].Value = job.Status.DisplayName;
                        row.DefaultCellStyle.BackColor = job.Status.DisplayColorBG;
                        row.DefaultCellStyle.ForeColor = job.Status.DisplayColorFG;
                        if (job.Status == JobStatus.Finished)
                        {
                            string time = Math.Round((job.ExitTime - job.StartTime).TotalSeconds, 2).ToString();
                            if (job.RetryCount > 0)
                            {
                                time = string.Format("{0} ({1})", time, job.RetryCount.ToString());
                            }
                            row.Cells["QueueJobTime"].Value = time;
                        }
                        if (job.Status == JobStatus.Error)
                        {
                            this.QueueSetErrorFlags(true);
                        }

                        if (this.cbAutoScroll.Checked)
                        {
                            this.ScrollGridQueueToActiveRow();
                        }
                    }
                });
            };
        }

        private void QueueSetErrorFlags(bool error)
        {
            if (error)
            {
                this.lblQueue.ForeColor = Color.Red;
            }
            else
            {
                this.lblQueue.ForeColor = Color.Black;
            }
        }

        private void ScrollGridQueueToActiveRow()
        {
            if (this.gridQueue.Rows.Count == 0)
            {
                return;
            }

            DataGridViewRow activeRow = this.gridQueue.Rows.Cast<DataGridViewRow>().DefaultIfEmpty(null).FirstOrDefault(x =>
            {
                Job job = x.Tag as Job;
                if (job.Status == JobStatus.Processing)
                {
                    return true;
                }
                if (job.Status == JobStatus.Reprocessing)
                {
                    return true;
                }

                return false;
            });
            int activeRowIndex;
            if (activeRow == null)
            {
                activeRowIndex = this.gridQueue.Rows.Count - 1;
            }
            else
            {
                activeRowIndex = activeRow.Index - (this.gridQueue.DisplayedRowCount(false) / 2);
                activeRowIndex = Math.Max(activeRowIndex, 0);
            }

            this.gridQueue.FirstDisplayedScrollingRowIndex = activeRowIndex;
        }

        private void LoadJobSettings()
        {
            this.ddDitherType.SelectedItem = this.ddDitherType.Items.Cast<DitherType>().First(x => x.CliName.Equals(Properties.Settings.Default.DefaultPattern.ToString()));
            this.ddOutputDevice.SelectedItem = this.ddOutputDevice.Items.Cast<OutputDevice>().First(x => x.CliName.Equals(Properties.Settings.Default.DefaultOutputDevice));
            this.ddDPI.SelectedItem = this.ddDPI.Items.Cast<string>().First(x => x.Equals(Properties.Settings.Default.DefaultResolution.ToString()));
            this.nudBrightness.Value = Properties.Settings.Default.DefaultBrightness;
            this.nudMinLineWidth.Value = Properties.Settings.Default.DefaultLineWidth;
            this.cbCrop.Checked = Properties.Settings.Default.DefaultCrop;
            this.ddOutputFolder.SelectedItem = this.ddOutputFolder.Items.Cast<string>().First(x => x.Equals(Properties.Settings.Default.DefaultOutputFolder));
        }

        private void SaveJobSettings()
        {
            Properties.Settings.Default.DefaultPattern = (this.ddDitherType.SelectedItem as DitherType).CliName;
            Properties.Settings.Default.DefaultOutputDevice = (this.ddOutputDevice.SelectedItem as OutputDevice).CliName;
            Properties.Settings.Default.DefaultResolution = int.Parse(this.ddDPI.SelectedItem as string);
            Properties.Settings.Default.DefaultBrightness = (int)this.nudBrightness.Value;
            Properties.Settings.Default.DefaultLineWidth = (int)this.nudMinLineWidth.Value;
            Properties.Settings.Default.DefaultCrop = this.cbCrop.Checked;
            Properties.Settings.Default.Save();
        }

        private void LoadProgramSettings()
        {
            this.nudMaxConcurrentProcesses.Value = Properties.Settings.Default.MaxConcurrentProcesses;
            this.nudMaxAutoRetryCount.Value = Properties.Settings.Default.MaxJobRetryCount;
            this.nudProcessStartDelay.Value = Properties.Settings.Default.ProcessStartDelay;

            this.cbErrorDialog.Checked = Properties.Settings.Default.ShowAcroplotErrorDialog;
            this.cbFontWarningDialog.Checked = Properties.Settings.Default.ShowAcroplotFontDialog;
            this.cbProgressDialog.Checked = Properties.Settings.Default.ShowAcroplotProgressDialog;

            this.txtAcroPlotPath.Text = Properties.Settings.Default.AcroPlotPath;
        }

        private void SaveProgramSettings()
        {
            Properties.Settings.Default.ShowAcroplotErrorDialog = this.cbErrorDialog.Checked;
            Properties.Settings.Default.ShowAcroplotFontDialog = this.cbFontWarningDialog.Checked;
            Properties.Settings.Default.ShowAcroplotProgressDialog = this.cbProgressDialog.Checked;

            Properties.Settings.Default.MaxConcurrentProcesses = (int)this.nudMaxConcurrentProcesses.Value;
            Properties.Settings.Default.MaxJobRetryCount = (int)this.nudMaxAutoRetryCount.Value;
            Properties.Settings.Default.ProcessStartDelay = (int)this.nudProcessStartDelay.Value;

            if (!File.Exists(this.txtAcroPlotPath.Text))
            {
                throw new Exception("Invalid file path: " + this.txtAcroPlotPath.Text);
            }

            Properties.Settings.Default.AcroPlotPath = this.txtAcroPlotPath.Text;
            Properties.Settings.Default.Save();
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            List<string> droppedFiles = new List<string>();
            string[] items = e.Data.GetData(DataFormats.FileDrop) as string[];
            foreach (string item in items)
            {
                var attr = File.GetAttributes(item);
                if ((attr & FileAttributes.Directory) == FileAttributes.Directory)
                {
                    droppedFiles.AddRange(Directory.EnumerateFiles(item, "*.*", SearchOption.AllDirectories));
                }
                else
                {
                    droppedFiles.Add(item);
                }
            }

            List<PdfFile> pdfFiles = this.CheckFiles(droppedFiles);
            this.UpdateUIFileList(pdfFiles);
        }

        private List<PdfFile> CheckFiles(List<string> files)
        {
            List<PdfFile> pdfFiles = new List<PdfFile>();
            for (int i = 0; i < files.Count; i++)
            {
                this.lblStatus.Text = string.Format("Checking files ({0}/{1})", i + 1, files.Count);
                this.statusStrip1.Refresh();
                try
                {
                    var pdf = new PdfFile(files[i], string.Empty);
                    pdfFiles.Add(pdf);
                }
                catch (Exception ex)
                {
                    var dr = MessageBox.Show(this, ex.Message + "\n\n" + files[i], "Could not open the file", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    if (dr == DialogResult.Cancel)
                    {
                        break;
                    }
                }
            }

            this.lblStatus.Text = string.Empty;
            return pdfFiles;
        }

        private void UpdateUIFileList(List<PdfFile> pdfFiles)
        {
            foreach (PdfFile pdf in pdfFiles)
            {
                string path = Path.GetDirectoryName(pdf.Filename);
                string filename = Path.GetFileName(pdf.Filename);
                foreach (PdfPage page in pdf.Pages)
                {
                    string pageNum = page.PageNum.ToString();
                    string pageSize = string.Format("{0:0.00} \u00d7 {1:0.00}", page.Width, page.Height);
                    string zoom = "100.00";
                    int rowIndex = this.gridJobSetup.Rows.Add(path, filename, pageNum, pageSize, zoom, pageSize);
                    this.gridJobSetup.Rows[rowIndex].Tag = page;
                }
            }

            this.UpdateUIOuputFiles();
        }

        private void UpdateUIOuputFiles()
        {
            string outputExt = (this.ddOutputDevice.SelectedItem as OutputDevice).Extension;

            foreach (DataGridViewRow row in this.gridJobSetup.Rows)
            {
                PdfPage page = row.Tag as PdfPage;
                string outputDir;
                switch ((string)this.ddOutputFolder.SelectedItem)
                {
                    case "<Same as file>":
                        outputDir = Path.GetDirectoryName(page.Parent.Filename);
                        break;
                    case @"<Same as file>\HALF":
                        outputDir = Path.Combine(Path.GetDirectoryName(page.Parent.Filename), "HALF");
                        break;
                    case @"<Same as file>\FULL":
                        outputDir = Path.Combine(Path.GetDirectoryName(page.Parent.Filename), "FULL");
                        break;
                    default:
                        outputDir = Path.GetDirectoryName(page.Parent.Filename);
                        break;
                }

                string baseFilename = Path.GetFileNameWithoutExtension(page.Parent.Filename);
                string outputFilename;
                if (page.Parent.PageCount == 1)
                {
                    outputFilename = string.Format("{0}.{1}", baseFilename, outputExt);
                }
                else
                {
                    outputFilename = string.Format("{0}_{1:D4}.{2}", baseFilename, page.PageNum, outputExt);
                }

                row.Cells["OutputFolder"].Value = outputDir;
                row.Cells["OutputFile"].Value = outputFilename;

                if (File.Exists(Path.Combine(outputDir, outputFilename)))
                {
                    row.DefaultCellStyle.BackColor = Color.IndianRed;
                    row.DefaultCellStyle.ForeColor = Color.White;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = this.gridJobSetup.DefaultCellStyle.BackColor;
                    row.DefaultCellStyle.ForeColor = this.gridJobSetup.DefaultCellStyle.ForeColor;
                }
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            this.gridJobSetup.Rows.Clear();
        }

        private void JobGrid_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var ht = this.gridJobSetup.HitTest(e.X, e.Y);
                if (ht.RowIndex >= 0 && ht.ColumnIndex >= 0)
                {
                    if (!this.gridJobSetup.Rows[ht.RowIndex].Selected)
                    {
                        this.gridJobSetup.ClearSelection();
                        this.gridJobSetup.Rows[ht.RowIndex].Selected = true;
                    }

                    var colClicked = this.gridJobSetup.Columns[ht.ColumnIndex];
                    switch (colClicked.Name)
                    {
                        case "FilePath":
                        case "FileName":
                            this.ctxFile.Show(this.gridJobSetup, e.Location);
                            break;
                        case "Zoom":
                        case "OutputSize":
                            this.ctxZoom.Show(this.gridJobSetup, e.Location);
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.gridJobSetup.SelectedRows)
            {
                this.gridJobSetup.Rows.Remove(row);
            }
        }

        private void RemoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.gridJobSetup.SelectedRows)
            {
                this.gridJobSetup.Rows.Remove(row);
            }
        }

        private void SetZoom(DataGridViewRow row, double zoom)
        {
            row.Cells["Zoom"].Value = zoom.ToString("0.00");
            PdfPage page = row.Tag as PdfPage;
            double width = zoom / 100 * page.Width;
            double height = zoom / 100 * page.Height;
            row.Cells["OutputSize"].Value = string.Format("{0:0.00} \u00d7 {1:0.00}", width, height);
        }

        private double CalcZoomFit(double oWidth, double oHeight, double tWidth, double tHeight)
        {
            double oW = Math.Min(oWidth, oHeight);
            double oH = Math.Max(oWidth, oHeight);
            double tW = Math.Min(tWidth, tHeight);
            double tH = Math.Max(tWidth, tHeight);
            double zoomW = 100 * tW / oW;
            double zoomH = 100 * tH / oH;
            return Math.Min(zoomW, zoomH);
        }

        private void FitToToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            var targetSize = e.ClickedItem.Tag as ZoomFitPageSize;
            foreach (DataGridViewRow row in this.gridJobSetup.SelectedRows)
            {
                var pdfPage = row.Tag as PdfPage;
                double zoom = this.CalcZoomFit(pdfPage.Width, pdfPage.Height, targetSize.Width, targetSize.Height);
                this.SetZoom(row, zoom);
            }
        }

        private void CtxZoom_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            double zoom;
            if (double.TryParse(e.ClickedItem.Text, out zoom))
            {
                foreach (DataGridViewRow row in this.gridJobSetup.SelectedRows)
                {
                    this.SetZoom(row, zoom);
                }
            }
        }

        private void CustomToolStripMenuItem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                double zoom;
                if (double.TryParse(this.customToolStripMenuItem.Text, out zoom))
                {
                    foreach (DataGridViewRow row in this.gridJobSetup.SelectedRows)
                    {
                        this.SetZoom(row, zoom);
                    }
                }
                else
                {
                    MessageBox.Show("Enter a valid zoom percentage.");
                }

                this.ctxZoom.Close();
            }
        }

        private void CtxZoom_Closed(object sender, ToolStripDropDownClosedEventArgs e)
        {
            this.customToolStripMenuItem.Text = string.Empty;
        }

        private void BtnProcess_Click(object sender, EventArgs e)
        {
            this.SendJobsToQueue();
        }

        private void SendJobsToQueue()
        {
            List<Job> jobs = new List<Job>(this.gridJobSetup.Rows.Count);

            int brightness = (int)this.nudBrightness.Value;
            int minLineWidth = (int)this.nudMinLineWidth.Value;
            int resolution = int.Parse(this.ddDPI.SelectedItem as string);
            DitherType ditherType = this.ddDitherType.SelectedItem as DitherType;
            OutputDevice outputDevice = this.ddOutputDevice.SelectedItem as OutputDevice;
            bool crop = this.cbCrop.Checked;

            foreach (DataGridViewRow row in this.gridJobSetup.Rows)
            {
                PdfPage page = row.Tag as PdfPage;
                string outputFilename = Path.Combine((string)row.Cells["OutputFolder"].Value, (string)row.Cells["OutputFile"].Value);
                double zoom = double.Parse(row.Cells["Zoom"].Value as string);
                Job job = new Job
                {
                    Brightness = brightness,
                    MinLineWidth = minLineWidth,
                    Resolution = resolution,
                    RemoveWhiteSpace = crop,
                    DitherType = ditherType,
                    OutputDevice = outputDevice,
                    Zoom = zoom,
                    FirstPage = page.PageNum,
                    LastPage = page.PageNum,
                    PdfFile = page.Parent,
                    InputFileName = page.Parent.Filename,
                    OutputFileName = outputFilename,
                    DisplayErrorDialog = true,
                    DisplayMissingFontDialog = true,
                    DisplayProgressDialog = false
                };
                page.Parent.AddRef(job);
                job.InputFileName = page.Parent.FilenameCached;
                jobs.Add(job);
            }

            Task.Run(() => ProcessQueue.Enqueue(jobs));
            this.gridJobSetup.Rows.Clear();
            this.ddOutputFolder.SelectedIndex = 0;
        }

        private void BtnSaveProgramSettings_Click(object sender, EventArgs e)
        {
            try
            {
                this.SaveProgramSettings();
                MessageBox.Show(this, "You may need to restart the program for some settings to take effect.", "Settings Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnClearFinishedQueue_Click(object sender, EventArgs e)
        {
            List<DataGridViewRow> rowsToRemove = new List<DataGridViewRow>();
            foreach (DataGridViewRow row in this.gridQueue.Rows)
            {
                Job job = row.Tag as Job;
                if (job.Status == JobStatus.Finished || job.Status == JobStatus.Cancelled)
                {
                    rowsToRemove.Add(row);
                }
            }

            foreach (DataGridViewRow row in rowsToRemove)
            {
                this.gridQueue.Rows.Remove(row);
            }
        }

        private void BtnCancelQueue_Click(object sender, EventArgs e)
        {
            ProcessQueue.CancelAll();
        }

        private void BtnClearErrorQueue_Click(object sender, EventArgs e)
        {
            List<DataGridViewRow> rowsToRemove = new List<DataGridViewRow>();
            foreach (DataGridViewRow row in this.gridQueue.Rows)
            {
                Job job = row.Tag as Job;
                if (job.Status == JobStatus.Error)
                {
                    rowsToRemove.Add(row);
                }
            }

            foreach (DataGridViewRow row in rowsToRemove)
            {
                this.gridQueue.Rows.Remove(row);
            }

            this.QueueSetErrorFlags(false);
        }

        private void CbAutoScroll_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cbAutoScroll.Checked)
            {
                this.ScrollGridQueueToActiveRow();
            }
        }

        private void DdOutputFolder_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.UpdateUIOuputFiles();
        }

        private void DdOutputDevice_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.UpdateUIOuputFiles();
        }

        private void BtnAcroPlotPathBrowse_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                try
                {
                    var startingPath = Path.GetDirectoryName(this.txtAcroPlotPath.Text);
                    if (Directory.Exists(startingPath))
                    {
                        ofd.InitialDirectory = startingPath;
                    }
                }
                catch (Exception)
                {
                    // No worries
                }

                ofd.Multiselect = false;
                if (ofd.ShowDialog(this) == DialogResult.OK)
                {
                    this.txtAcroPlotPath.Text = ofd.FileName;
                }
            }
        }
    }
}
