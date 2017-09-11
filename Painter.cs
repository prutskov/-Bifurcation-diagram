using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Painter
{
    public class Parametrs
    {
        public double xmin, xmax, ymin, ymax, stepx, stepy;
        public int N;
        public Color backgroundcolor, graphcolor, osicolor, setkacolor;

        public double X(System.Windows.Forms.PictureBox pic, double x)
        {
            return pic.Width / (xmax - xmin) * (x - xmin);
        }

        public double Y(System.Windows.Forms.PictureBox pic, double y)
        {
            return -pic.Height / (ymax - ymin) * (y - ymax);
        }
    }
}
