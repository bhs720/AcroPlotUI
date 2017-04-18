using System.Drawing;

namespace AcroPlotUI
{
    public class QueueStatus
    {
        public static readonly QueueStatus Idle = new QueueStatus
        {
            DisplayName = "Idle",
            DisplayColor = Color.Yellow
        };

        public static readonly QueueStatus Processing = new QueueStatus
        {
            DisplayName = "Processing",
            DisplayColor = Color.Green
        };

        public static readonly QueueStatus Paused = new QueueStatus
        {
            DisplayName = "Paused",
            DisplayColor = Color.Black
        };

        public string DisplayName { get; private set; }

        public Color DisplayColor { get; private set; }
    }
}
