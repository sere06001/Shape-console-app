using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_console_app
{
    internal class Rectangle : IShape
    {
        double width;
        double height;
        public Rectangle(double w, double h)
        {
            width = w;
            height = h;
        }

        public double Area()
        {
            return Math.Round(width * height, 2);
        }

        public double Circumference()
        {
            double sum = (width * 2) + (height * 2);
            return Math.Round(sum, 2);
        }
    }
}
