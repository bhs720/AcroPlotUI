using System.Collections.Generic;

namespace AcroPlotUI
{
    public class OutputDevice
    {
        public static readonly List<OutputDevice> Devices = new List<OutputDevice>
        {
            new OutputDevice { CliName = "png16m", DisplayName = "PNG Color", Extension = "PNG" },
            new OutputDevice { CliName = "pnggray", DisplayName = "PNG Grayscale", Extension = "PNG" },
            new OutputDevice { CliName = "pngmono", DisplayName = "PNG Monochrome", Extension = "PNG" },
            new OutputDevice { CliName = "jpeg", DisplayName = "JPG Color", Extension = "JPG" },
            new OutputDevice { CliName = "jpeggray", DisplayName = "JPG Grayscale", Extension = "JPG" },
            new OutputDevice { CliName = "jpegmono", DisplayName = "JPG Monochrome", Extension = "JPG" },
            new OutputDevice { CliName = "tiffgray", DisplayName = "TIF Grayscale", Extension = "TIF" },
            new OutputDevice { CliName = "tiffgraylzw", DisplayName = "TIF Grayscale (LZW Compression)", Extension = "TIF" },
            new OutputDevice { CliName = "tiffgraypack", DisplayName = "TIF Grayscale (Packbits Compression)", Extension = "TIF" },
            new OutputDevice { CliName = "tiff24nc", DisplayName = "TIF Color (No Compression)", Extension = "TIF" },
            new OutputDevice { CliName = "tiff24lzw", DisplayName = "TIF Color (LZW Compression)", Extension = "TIF" },
            new OutputDevice { CliName = "tiff24pack", DisplayName = "TIF Color (Packbits Compression)", Extension = "TIF" },
            new OutputDevice { CliName = "tiffg4", DisplayName = "TIF Monochrome (Group4 Compression)", Extension = "TIF" },
            new OutputDevice { CliName = "tifflzw", DisplayName = "TIF Monochrome (LZW Compression)", Extension = "TIF" },
            new OutputDevice { CliName = "tiffpack", DisplayName = "TIF Monochrome (Packbits Compression)", Extension = "TIF" },
            new OutputDevice { CliName = "bmp16m", DisplayName = "BMP Color", Extension = "BMP" },
            new OutputDevice { CliName = "bmpgray", DisplayName = "BMP Grayscale", Extension = "BMP" },
            new OutputDevice { CliName = "bmpmono", DisplayName = "BMP Monochrome", Extension = "BMP" }
        };

        public string CliName { get; private set; }

        public string DisplayName { get; private set; }

        public string Extension { get; private set; }
    }
}
