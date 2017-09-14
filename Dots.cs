using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistic
{
    class Dots
    {
       //public double x;
       //public List<double> y=new List <double>();
       //public List<Dots> Next=new List<Dots>();
       //public Dots()
       //{
       //    x = 0;
          
       //    Next = null;
       //}

        public double x;
        public double y;
        public List<Dots> Next = new List<Dots>();
        public Dots()
        {
            x = 0;

        }
    }

   
}
