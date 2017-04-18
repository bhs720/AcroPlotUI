using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AcroPlotUI
{
    public class ZoomFitPageSize
    {
        public static readonly List<ZoomFitPageSize> Default = new List<ZoomFitPageSize>
        {
            new ZoomFitPageSize { DisplayName = "ANSI-B [11 × 17]", Width = 11, Height = 17 },
            new ZoomFitPageSize { DisplayName = "ANSI-C [17 × 22]", Width = 17, Height = 22 },
            new ZoomFitPageSize { DisplayName = "ANSI-D [22 × 34]", Width = 22, Height = 34 },
            new ZoomFitPageSize { DisplayName = "ANSI-E [34 × 44]", Width = 34, Height = 44 },
            new ZoomFitPageSize { DisplayName = "ARCH-B [12 × 18]", Width = 12, Height = 18 },
            new ZoomFitPageSize { DisplayName = "ARCH-C [18 × 24]", Width = 18, Height = 24 },
            new ZoomFitPageSize { DisplayName = "ARCH-D [24 × 36]", Width = 24, Height = 36 },
            new ZoomFitPageSize { DisplayName = "ARCH-E1 [30 × 42]", Width = 30, Height = 42 },
            new ZoomFitPageSize { DisplayName = "ARCH-E [36 × 48]", Width = 36, Height = 48 },
        };

        public static readonly ToolStripMenuItem[] Menu = Default.Select(x =>
        {
            var item = new ToolStripMenuItem(x.DisplayName);
            item.Tag = x;
            return item;
        }).Cast<ToolStripMenuItem>().ToArray();

        public string DisplayName { get; set; }

        public double Width { get; set; }

        public double Height { get; set; }

        public double Margin { get; set; }
    }
}
