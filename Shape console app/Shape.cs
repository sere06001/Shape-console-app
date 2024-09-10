using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_console_app
{
    internal class Shape
    {
        protected double width;
        protected double height;

        public Shape (double w, double h)
        {
            width = w;
            height = h;
        }
        public virtual double Area(double width, double height) { return 0; }
        public virtual double Circumference(double width, double height) { return 0; }
    }
}
