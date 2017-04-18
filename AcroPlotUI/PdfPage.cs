namespace AcroPlotUI
{
    public class PdfPage
    {
        public PdfPage(PdfFile parent, int pageNum, double width, double height)
        {
            this.PageNum = pageNum;
            this.Parent = parent;
            this.Width = width;
            this.Height = height;
        }

        public double Width { get; private set; }

        public double Height { get; private set; }

        public int PageNum { get; private set; }

        public PdfFile Parent { get; private set; }
    }
}
