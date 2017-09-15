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
        public Color backgroundcolor, graphcolor, osicolor, setkacolor, pointcolor;

        public double X(double width, double x)
        {
            return width / (xmax - xmin) * (x - xmin);
        }

        public double Y(double height, double y)
        {
            return -height / (ymax - ymin) * (y - ymax);
        }
    }
}
