using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace AcroPlotUI
{
    public static class ProcessQueue
    {
        private static readonly int MaxConcurrentJobs = Properties.Settings.Default.MaxConcurrentProcesses;
        private static readonly int MaxJobRetryCount = Properties.Settings.Default.MaxJobRetryCount;
        private static readonly int ProcessStartDelay = Properties.Settings.Default.ProcessStartDelay;
        private static Queue<Job> waiting = new Queue<Job>();
        private static List<Job> processing = new List<Job>();
        private static object locker = new object();

        static ProcessQueue()
        {
            Status = QueueStatus.Idle;
        }

        public delegate void JobStatusChangedEventHandler(Job job);

        public delegate void QueueStatusChangedEventHandler(QueueStatus status, int queued);

        public static event JobStatusChangedEventHandler JobStatusChanged = (Job job) => { };

        public static event QueueStatusChangedEventHandler QueueStatusChanged = (QueueStatus status, int queued) => { };

        public static QueueStatus Status { get; private set; }

        public static bool Busy
        {
            get
            {
                lock (locker)
                {
                    return waiting.Count > 0 && processing.Count > 0;
                }
            }
        }

        public static void Enqueue(List<Job> jobs)
        {
            lock (locker)
            {
                foreach (var job in jobs)
                {
                    waiting.Enqueue(job);
                    job.Status = JobStatus.Queued;
                    JobStatusChanged.Invoke(job);
                }
            }

            Next();
        }

        public static void CancelAll()
        {
            lock (locker)
            {
                while (waiting.Count > 0)
                {
                    Job job = waiting.Dequeue();
                    job.Status = JobStatus.Cancelled;
                    JobStatusChanged.Invoke(job);
                }

                QueueStatusChanged(Status, processing.Count);
            }
        }

        public static void Next()
        {
            lock (locker)
            {
                while (waiting.Count > 0 && processing.Count < MaxConcurrentJobs)
                {
                    Job job = waiting.Dequeue();
                    processing.Add(job);
                    job.ProcessExited += Job_ProcessExited;
                    job.Status = JobStatus.Processing;
                    JobStatusChanged.Invoke(job);
                    job.Start();
                    System.Threading.Thread.Sleep(ProcessStartDelay);
                }

                Status = processing.Count == 0 ? QueueStatus.Idle : QueueStatus.Processing;
                QueueStatusChanged.Invoke(Status, waiting.Count + processing.Count);
            }
        }

        private static void Job_ProcessExited(Job job)
        {
            lock (locker)
            {
                if (job.ProcessingSucceeded)
                {
                    processing.Remove(job);
                    job.ProcessExited -= Job_ProcessExited;
                    job.Status = JobStatus.Finished;
                    JobStatusChanged.Invoke(job);
                    job.PdfFile.DelRef(job);
                }
                else
                {
                    TimeSpan time = job.ExitTime - job.StartTime;
                    Debug.WriteLine("Job failed: {0}; Retry: {1}; Time: {2}", job.OutputFileName, job.RetryCount, time.TotalSeconds);
                    if (job.RetryCount < MaxJobRetryCount)
                    {
                        job.RetryCount++;
                        job.Status = JobStatus.Reprocessing;
                        job.Start();
                        JobStatusChanged.Invoke(job);
                    }
                    else
                    {
                        processing.Remove(job);
                        job.ProcessExited -= Job_ProcessExited;
                        job.Status = JobStatus.Error;
                        JobStatusChanged.Invoke(job);
                        job.PdfFile.DelRef(job);
                    }
                }
            }

            Next();
        }
    }
}
