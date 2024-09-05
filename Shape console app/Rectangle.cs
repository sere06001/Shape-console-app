using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_console_app
{
    internal class Rectangle : Shape
    {
        public Rectangle(double w, double h) : base(w, h)
        {
            width = w;
            height = h;
        }

        public override double Area(double width, double height)
        {
            return width * height;
        }

        public override double Circumference(double width, double height)
        {
            double sum = (width * 2) + (height * 2);
            return sum;
        }
    }
}
