using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainForm
{
    public static class ThemeColor
    {
        public static Color primary_color { get; set; }
        public static Color secondary_color { get; set; }
        public static List<string> ColorList = new List<string>() { "#2196F3",
                                                                    "#E41A4A",
                                                                    "#00B0AD",
                                                                    "#8BC240",
                                                                    "#8BC240",
                                                                    "#E4126B",
                                                                    "#B71C46",
                                                                    "#f22613",
                                                                    "#8c14fc",
                                                                    "#24252a" };
        /* http://www.flatuicolorpicker.com/purple-hex-color-model/ Colors website
         { "#3F51B5",
        "#009688",
        "#FF5722",
        "#FF9800",
        "#9C27B0",
        "#2196F3",
        "#E41A4A",
        "#018790",
        "#0E3441",
        "#00B0AD",
        "#721D47",
        "#EA4833",
        "#F37521",
        "#A12059",
        "#8BC240",
        "#364D5B", 
        "#0094BC",
        "#E4126B",
        "#43B76E",
        "#B71C46"};*/

        public static Color ChangeColorBrightness(Color color, double correctionFactor)
        {
            double red = color.R;
            double green = color.G;
            double blue = color.B;
            //If correction factor is less than 0, darken color.
            if (correctionFactor < 0)
            {
                correctionFactor = 1 + correctionFactor;
                red *= correctionFactor;
                green *= correctionFactor;
                blue *= correctionFactor;
            }
            //If correction factor is greater than zero, lighten color.
            else
            {
                red = (255 - red) * correctionFactor + red;
                green = (255 - green) * correctionFactor + green;
                blue = (255 - blue) * correctionFactor + blue;
            }
            return Color.FromArgb(color.A, (byte)red, (byte)green, (byte)blue);
        }
    }
}
