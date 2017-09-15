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
using System.Threading;
using System.Drawing.Text;

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
            param.stepx = (double)param.xmax / 5;
            param.stepy = (double)param.ymax / 5;
            param.osicolor = Color.White;
            param.setkacolor = Color.White;
            param.backgroundcolor = Color.Black;
            param.graphcolor = Color.White;
            Ndot.Text = Convert.ToString(50);
            firstx.Text = Convert.ToString(0.5);
            R.Text = Convert.ToString(1.2);
            MaxR.Text = Convert.ToString(4);
            minR.Text = Convert.ToString(2);
            Ndot2.Text = Convert.ToString(500);
            NumberX.Text = Convert.ToString(1000);
            K.Text = Convert.ToString(100);
            Accuracy.Text = Convert.ToString(2);
           bmp = new Bitmap(Graph.Width, Graph.Height);
           painting();
        }

        Parametrs param = new Parametrs();
        List <List<Dots>> dots_bifur = new List <List<Dots>>();
        Bitmap bmp;
        
        bool bifurcation;
        double[] dots;


        private void painting()
        {
            bmp = new Bitmap(Graph.Width, Graph.Height);
            Graphics g = Graphics.FromImage(bmp); ;

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

            //ручка для сетки
            Pen bifur_pen = new Pen(param.graphcolor, 1);
            setka.DashStyle = DashStyle.Solid;

            //ручка для сетки
            Pen solid_pen = new Pen(Color.Red, 1);
            solid_pen.DashStyle = DashStyle.Solid;

          g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.TextRenderingHint = TextRenderingHint.AntiAlias;

            double width = Graph.Width, height = Graph.Height;

            //рисую оси
            g.DrawLine(osi, (float)param.X(width, param.xmin), (float)param.Y(height, 0), (float)param.X(width, param.xmax), (float)param.Y(height, 0));
          //  g.DrawLine(osi, (float)param.X(width, 0), (float)param.Y(height, param.ymin), (float)param.X(width, 0), (float)param.Y(height, param.ymax));

            //рисую сетку

            //право вертикаль
            for (double i = param.stepx; i <= param.xmax; i += param.stepx)
            {
                g.DrawLine(setka, (float)param.X(width, i), (float)param.Y(height, param.ymin), (float)param.X(width, i), (float)param.Y(height, param.ymax));
            }
            //лево вертикаль
            for (double i = 0; i >= param.xmin; i -= param.stepx)
            {
                g.DrawLine(setka, (float)param.X(width, i), (float)param.Y(height, param.ymin), (float)param.X(width, i), (float)param.Y(height, param.ymax));
            }

            //верх горизонталь
            for (double i = param.stepy; i <= param.ymax; i += param.stepy)
            {
                g.DrawLine(setka, (float)param.X(width, param.xmin), (float)param.Y(height, i), (float)param.X(width, param.xmax), (float)param.Y(height, i));
            }

            //низ горизонталь
            for (double i = -param.stepy; i >= param.ymin; i -= param.stepy)
            {
                g.DrawLine(setka, (float)param.X(width, param.xmin), (float)param.Y(height, i), (float)param.X(width, param.xmax), (float)param.Y(height, i));
            }

            //подписываю оси
            String str;
            Font font = new Font("Arial", 8);
            
            SolidBrush brush = new SolidBrush(Color.White);
            //вправо
            for (double i = 0; i <= param.xmax; i += param.stepx)
            {
                str = i.ToString("F1");
                g.DrawString(str, font, brush, (float)param.X(width, i), (float)param.Y(height, 0) + 2);
            }
            //влево
            for (double i = -param.stepx; i >= param.xmin; i -= param.stepx)
            {
                str = i.ToString("F1");
                g.DrawString(str, font, brush, (float)param.X(width, i), (float)param.Y(height, 0) + 2);
            }
            //вверх
            for (double i = param.stepy; i <= param.ymax; i += param.stepy)
            {
                str = i.ToString("F1");
                g.DrawString(str, font, brush, (float)param.X(width, param.xmin), (float)param.Y(height, i) + 2);
            }
            //вниз
            for (double i = -param.stepy; i >= param.ymin; i -= param.stepy)
            {
                str = i.ToString("F1");
                g.DrawString(str, font, brush, (float)param.X(width, param.xmin), (float)param.Y(height, i) + 2);
            }

            if (!bifurcation)
            {
                if (dots != null)
                {
                    //рисую график
                    for (int i = 0; i < param.N - 1; i++)
                    {
                        g.DrawLine(graph_pen, (float)param.X(width, i), (float)param.Y(height, dots[i]), (float)param.X(width, i + 1), (float)param.Y(height, dots[i + 1]));
                    }
                }
            }
            else
            {
                
                for (int i = 0; i < dots_bifur.Count; i++)
                {
                    for (int j = 0; j < dots_bifur[i].Count; j++)
                    {
                        //g.DrawRectangle(bifur_pen, (float)param.X(Graph, dots_bifur[i].x), (float)param.Y(Graph, dots_bifur[i].y), 1, 1);
                        bmp.SetPixel((int)param.X(width, dots_bifur[i][j].x), (int)param.Y(height, dots_bifur[i][j].y), bifur_pen.Color);
                    }
                }

                if (SolidLine.Checked)
                {

                    for (int i = 0; i < dots_bifur.Count(); i++)
                    {
                        for (int j = 0; j < dots_bifur[i].Count(); j++)
                        {
                            for (int k = 0; k < dots_bifur[i][j].Next.Count(); k++)
                            {
                                g.DrawLine(solid_pen, (float)param.X(width, dots_bifur[i][j].x), (float)param.Y(height, dots_bifur[i][j].y),
                                    (float)param.X(width, dots_bifur[i][j].Next[k].x), (float)param.Y(height, dots_bifur[i][j].Next[k].y));
                            }
                        }
                    }
                }
            }

            Graph.Image = bmp;
        }
        private void Graph_Paint(object sender, PaintEventArgs e)
        {           

        }


        private void parametrsBtn_Click(object sender, EventArgs e)
        {
            ParametrsForm parametr_form = new ParametrsForm(param);
            parametr_form.ShowDialog();
            param = parametr_form.transfer();
            painting();
        }

        private void create_dots(double x0, double R)
        {

            dots[0] = x0;
            for (int i = 1; i < param.N; i++)
            {
                dots[i] = R *dots[i-1]* (1 - dots[i - 1]);
            }
        }

        public void create_dots_bifur()
        {
            dots_bifur.Clear();
            Dots dot;
            double stepR = (double.Parse(MaxR.Text)-double.Parse(minR.Text)) / double.Parse(Ndot2.Text);
            double min = double.Parse(minR.Text);
            double max = double.Parse(MaxR.Text);
            int n = int.Parse(NumberX.Text);
            int kk = int.Parse(K.Text);
            double acc = double.Parse(Accuracy.Text);
            Random rnd=new Random();
            List<Dots> dot_buffer;

           
            for (double i = min; i <= max; i += stepR)
            {
                dot_buffer= new List<Dots>();
                
               
                for (int k = 0; k < kk; k++)
                {
                    dot = new Dots();
                    bool sovpadenie = false;
                    double y = rnd.NextDouble(); 
                    for (int j = 1; j < n; j++)
                    {
                        y = y * i * (1 - y);
                    }

                    for (int m = 0; m < dot_buffer.Count(); m++)
                    {
                        if (Math.Abs(dot_buffer[m].y - y) < acc) sovpadenie=true;                       
                    }
                    if (!sovpadenie)
                    {
                        dot.x = i;
                        dot.y = y;
                        dot_buffer.Add(dot);
                    }
                }
                dots_bifur.Add(dot_buffer);
                
            }


        }

        private void scale(double[] data)
        {
            param.ymax = 0;
            param.ymin = 0;
            for (int i = 0; i < param.N; i++)
            {
                if (param.ymin > data[i]) param.ymin = data[i];
                if (param.ymax < data[i]) param.ymax = data[i];
            }
            if (param.ymin > -param.ymax / 14) param.ymin = -param.ymax / 14;
            param.xmin = -1;
            param.xmax = param.N;
            param.stepx = (double)param.xmax / 5;
            param.stepy = (double)param.ymax / 5;
        }

        private void scale(List<List<Dots>> dot)
        {
            param.ymax = 0;
            param.ymin = 0;
            for (int i = 0; i < dot.Count; i++)
            {
                for (int j = 0; j < dot[i].Count; j++)
                {
                    if (dot[i][j].y > param.ymax) param.ymax = dot[i][j].y;
                    if (dot[i][j].y< param.ymin) param.ymin = dot[i][j].y;
                }
            }
            if (param.ymin > -param.ymax / 14) param.ymin = -param.ymax / 14;
            param.xmin = double.Parse(minR.Text);
            param.xmax = double.Parse(MaxR.Text);
            param.stepx = (double)param.xmax / 5;
            param.stepy = (double)param.ymax / 5;
        }

        private void createdotsBtn_Click(object sender, EventArgs e)
        {
            if (!bifurcation)
            {
                param.N = int.Parse(Ndot.Text);
                dots = new double[param.N];
                create_dots(double.Parse(firstx.Text), double.Parse(R.Text));
                scale(dots);
            }
            else
            {
                create_dots_bifur();
                scale(dots_bifur);
                deep_search();
            }
            painting();
        }

        private void bifurcat_CheckedChanged(object sender, EventArgs e)
        {
            bifurcation = bifurcat.Checked;
        }

        private void deep_search()
        {
            for (int i = 0; i < dots_bifur.Count()-1; i++)
            {
                double dif = 0, dif_min;
                int number_min=0;
                for (int k = 0; k < dots_bifur[i+1].Count(); k++)
                {
                    dif_min = Math.Abs(dots_bifur[i + 1][k].y - dots_bifur[i][0].y);
                    number_min = 0;
                    for (int j = 1; j < dots_bifur[i].Count(); j++)
                    {
                        dif = Math.Abs(dots_bifur[i + 1][k].y - dots_bifur[i][j].y);
                        if (dif < dif_min) { number_min = j; dif_min = dif; }
                    }
                    dots_bifur[i][number_min].Next.Add(dots_bifur[i+1][k]);

                }
            }
        }

        private void SolidLine_CheckedChanged(object sender, EventArgs e)
        {
            painting();
        }
    }
}
