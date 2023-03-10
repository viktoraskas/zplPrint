using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zplPrint.models
{

    public class labelTemplate
    {
        public labelParameters Parameters { get; set; }
        public List<labelData> Records { get; set; }
    }
    public class labelParameters
    {
        public string printerName { get; set; }
        public int Width { get; set; }
        public int? Height { get; set; }
        public int Dpi { get; set; }
        public Boolean Cut { get; set; }
    }

    public class labelData
    {
        public string Text { get; set; }
        public int Top { get; set; }
        public int Left { get; set; }
        public int Margin { get; set; }
        public int FontSize { get; set; }
        public int FontWeight { get; set; }
        public string FontFamily { get; set; }
        public string FontStyle { get; set; }
        public int Spacing { get; set; }
        public Aligment Alignment { get; set; }
        public Boolean ConvertToGraphic { get; set; }
    }

    public enum Aligment { Left, Rigth, Top, Bottom, Center, LeftCenter, RightCenter, TopCenter, BottomCenter,
                            LeftTop, LeftBottom, RightTop, RightBottom}

}
