using System.Drawing;

namespace AcroPlotUI
{
    public class JobStatus
    {
        public static readonly JobStatus Queued = new JobStatus
        {
            DisplayName = "Queued",
            DisplayColorBG = Color.LightYellow,
            DisplayColorFG = Color.Black
        };

        public static readonly JobStatus Processing = new JobStatus
        {
            DisplayName = "Processing",
            DisplayColorBG = Color.LightGreen,
            DisplayColorFG = Color.Black
        };

        public static readonly JobStatus Finished = new JobStatus
        {
            DisplayName = "Finished",
            DisplayColorBG = Color.FromArgb(0xEC, 0xEC, 0xEC),
            DisplayColorFG = Color.Black
        };

        public static readonly JobStatus Cancelled = new JobStatus
        {
            DisplayName = "Cancelled",
            DisplayColorBG = Color.White,
            DisplayColorFG = Color.Gray
        };

        public static readonly JobStatus Reprocessing = new JobStatus
        {
            DisplayName = "Reprocessing",
            DisplayColorBG = Color.IndianRed,
            DisplayColorFG = Color.White
        };

        public static readonly JobStatus Error = new JobStatus
        {
            DisplayName = "Error",
            DisplayColorBG = Color.Red,
            DisplayColorFG = Color.White
        };

        public string DisplayName { get; private set; }

        public Color DisplayColorFG { get; private set; }

        public Color DisplayColorBG { get; private set; }
    }
}
