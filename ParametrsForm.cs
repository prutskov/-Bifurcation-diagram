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
using System.Globalization;

namespace Logistic
{
    public partial class ParametrsForm : Form
    {
        public ParametrsForm()
        {
            InitializeComponent();
        }

        public ParametrsForm(Parametrs parametrs)
        {
            InitializeComponent();
            Xmin.Text = parametrs.xmin.ToString();
            Xmax.Text = parametrs.xmax.ToString();
            Ymin.Text = parametrs.ymin.ToString();
            Ymax.Text = parametrs.ymax.ToString();
            param.N = parametrs.N;
            stepx.Text = parametrs.stepx.ToString();
            stepy.Text = parametrs.stepy.ToString();
            param.backgroundcolor = parametrs.backgroundcolor;
            param.setkacolor = parametrs.setkacolor;
            param.osicolor = parametrs.osicolor;
            param.graphcolor = parametrs.graphcolor;
        }

        private Parametrs param = new Parametrs();

        public Parametrs transfer()
        {

            param.xmin = double.Parse(Xmin.Text);
            param.xmax = double.Parse(Xmax.Text);
            param.ymin = double.Parse(Ymin.Text);
            param.ymax = double.Parse(Ymax.Text);
            
            param.stepx = double.Parse(stepx.Text);
            param.stepy = double.Parse(stepy.Text);


            return param;
        }

      

        private void colorBackground_Click(object sender, EventArgs e)
        {
            colorDialog.Color = param.backgroundcolor;
            colorDialog.ShowDialog();
            param.backgroundcolor = colorDialog.Color;
        }

        private void colorOsi_Click(object sender, EventArgs e)
        {
            colorDialog.Color = param.osicolor;
            colorDialog.ShowDialog();
            param.osicolor = colorDialog.Color;
        }

        private void colorSetka_Click(object sender, EventArgs e)
        {
            colorDialog.Color = param.setkacolor;
            colorDialog.ShowDialog();
            param.setkacolor = colorDialog.Color;
        }

        private void colorGraph_Click(object sender, EventArgs e)
        {
            colorDialog.Color = param.graphcolor;
            colorDialog.ShowDialog();
            param.graphcolor = colorDialog.Color;
        }

        private void Apply_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
      

    }
}
