using System.Collections.Generic;

namespace AcroPlotUI
{
    public class DitherType
    {
        public static readonly List<DitherType> Types = new List<DitherType>
        {
            new DitherType { CliName = "-1", DisplayName = "Ghostscript" },
            new DitherType { CliName = "0", DisplayName = "Error Diffusion Pattern 1" },
            new DitherType { CliName = "1", DisplayName = "Error Diffusion Pattern 2" },
            new DitherType { CliName = "2", DisplayName = "Error Diffusion Pattern 3" },

            // new DitherType { CliName = "3", DisplayName = "Not Used"},
            new DitherType { CliName = "4", DisplayName = "Clustered Dithering (36 Shades)" },
            new DitherType { CliName = "5", DisplayName = "Clustered Dithering (64 Shades)" },
            new DitherType { CliName = "6", DisplayName = "Clustered Dithering (100 Shades)" },
            new DitherType { CliName = "7", DisplayName = "Clustered Dithering (144 Shades)" },
            new DitherType { CliName = "8", DisplayName = "Clustered Dithering (196 Shades)" },
            new DitherType { CliName = "9", DisplayName = "Clustered Dithering (256 Shades)" },
            new DitherType { CliName = "10", DisplayName = "Acroplot Enhanced Dithering" },
            new DitherType { CliName = "11", DisplayName = "Acroplot Enhanced Dithering 2" },
            new DitherType { CliName = "12", DisplayName = "Force All to Black" }
        };

        public string CliName { get; private set; }

        public string DisplayName { get; private set; }
    }
}
