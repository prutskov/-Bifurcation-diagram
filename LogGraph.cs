using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Painter;
using System.Drawing.Drawing2D;

namespace Logistic
{
    public partial class LogGraph : Form
    {
        public LogGraph()
        {
            InitializeComponent();
            param.xmin = -1;
            param.xmax = 50;
            param.ymin = -1;
            param.ymax = 5;
            param.N = 50;
            param.stepx = (double) param.xmax/5;
            param.stepy = (double)param.ymax / 5;
            param.osicolor = Color.Black;
            param.setkacolor = Color.Blue;
            param.backgroundcolor = Color.Yellow;
            param.graphcolor = Color.Red;
            Ndot.Text = Convert.ToString(50);
            firstx.Text = Convert.ToString(0.5);
            R.Text = Convert.ToString(1.2);
            
           
        }

        Parametrs param = new Parametrs();
        bool bifurcation;
        double[] dots;
       


        private void Graph_Paint(object sender, PaintEventArgs e)
        {
            
            Graphics g = e.Graphics;

            Graph.BackColor = param.backgroundcolor;
            //ручка для осей
            Pen osi = new Pen(param.osicolor, 3);
            osi.DashStyle = DashStyle.Solid;

            //ручка для сетки
            Pen setka = new Pen(param.setkacolor, 1);
            setka.DashStyle = DashStyle.DashDotDot;

            //ручка для сетки
            Pen graph_pen = new Pen(param.graphcolor, 3);
            setka.DashStyle = DashStyle.Solid;

            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            //рисую оси
            g.DrawLine(osi, (float)param.X(Graph, param.xmin), (float)param.Y(Graph, 0), (float)param.X(Graph, param.xmax), (float)param.Y(Graph, 0));
            g.DrawLine(osi, (float)param.X(Graph, 0), (float)param.Y(Graph, param.ymin), (float)param.X(Graph, 0), (float)param.Y(Graph, param.ymax));

            //рисую сетку

            //право вертикаль
            for (int i = (int)param.stepx; i <= (int)param.xmax; i += (int)param.stepx)
            {
                g.DrawLine(setka, (float)param.X(Graph, i), (float)param.Y(Graph, param.ymin), (float)param.X(Graph, i), (float)param.Y(Graph, param.ymax));
            }
            //лево вертикаль
            for (int i = -(int)param.stepx; i >= (int)param.xmin; i -= (int)param.stepx)
            {
                g.DrawLine(setka, (float)param.X(Graph, i), (float)param.Y(Graph, param.ymin), (float)param.X(Graph, i), (float)param.Y(Graph, param.ymax));
            }

            //верх горизонталь
            for (double i = param.stepy; i <= param.ymax; i += param.stepy)
            {
                g.DrawLine(setka, (float)param.X(Graph, param.xmin), (float)param.Y(Graph, i), (float)param.X(Graph, param.xmax), (float)param.Y(Graph, i));
            }

            //низ горизонталь
            for (double i = -param.stepy; i >= param.ymin; i -= param.stepy)
            {
                g.DrawLine(setka, (float)param.X(Graph, param.xmin), (float)param.Y(Graph, i), (float)param.X(Graph, param.xmax), (float)param.Y(Graph, i));
            }

            //подписываю оси
            String str;
            Font font = new Font("Arial", 8);
            SolidBrush brush = new SolidBrush(Color.Black);
            //вправо
            for (double i = 0; i <= param.xmax; i += param.stepx)
            {
                str = i.ToString("F1");
                g.DrawString(str, font, brush, (float)param.X(Graph, i), (float)param.Y(Graph, 0)+2);
            }
            //влево
            for (double i = -param.stepx; i >= param.xmin; i -= param.stepx)
            {
                str = i.ToString("F1");
                g.DrawString(str, font, brush, (float)param.X(Graph, i), (float)param.Y(Graph, 0)+2);
            }
            //вверх
            for (double i = 0; i <= param.ymax; i += param.stepy)
            {
                str = i.ToString("F1");
                g.DrawString(str, font, brush, (float)param.X(Graph, 0), (float)param.Y(Graph, i)+2);
            }
            //вниз
            for (double i = -param.stepy; i >= param.ymin; i -= param.stepy)
            {
                str = i.ToString("F1");
                g.DrawString(str, font, brush, (float)param.X(Graph, 0), (float)param.Y(Graph, i)+2);
            }

            if (dots != null)
            {
                //рисую график
                for (int i = 0; i < param.N - 1; i++)
                {
                    g.DrawLine(graph_pen, (float)param.X(Graph, i), (float)param.Y(Graph, dots[i]), (float)param.X(Graph, i + 1), (float)param.Y(Graph, dots[i + 1]));
                }
            }
          
        }

  
        private void parametrsBtn_Click(object sender, EventArgs e)
        {
            ParametrsForm parametr_form = new ParametrsForm(param);
            parametr_form.ShowDialog();
            param = parametr_form.transfer();

            Graph.Invalidate();
        }

        private void create_dots(double x0, double R)
        {
             
             dots[0] = x0;
            for (int i=1; i<param.N; i++)
            {
                dots[i] = R * (1 - dots[i - 1]);
            }
        }

        private void create_dots_bifur(double x0, double R)
        {

            dots[0] = x0;
            for (int i = 1; i < param.N; i++)
            {
                dots[i] = R * (1 - dots[i - 1]);
            }
        }

        private void scale(double [] data)
        {
            param.ymax = 0;
            param.ymin = 0;
            for (int i=0;i<param.N; i++)
            {
                if (param.ymin > data[i]) param.ymin = data[i];
                if (param.ymax < data[i]) param.ymax = data[i];
            }
            param.stepx = (double)param.xmax / 5;
            param.stepy = (double)param.ymax / 5;
            param.xmax = param.N;
        }

        private void createdotsBtn_Click(object sender, EventArgs e)
        {
            
            param.N = int.Parse(Ndot.Text);
            dots = new double[param.N];
            create_dots(double.Parse(firstx.Text), double.Parse(R.Text));
            
            scale(dots);
            Graph.Invalidate();
        }

        private void bifurcat_CheckedChanged(object sender, EventArgs e)
        {
            bifurcation = bifurcat.Checked;
        }
    }
}
