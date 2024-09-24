using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_console_app
{
    internal class Triangle : IShape
    {
        double width;
        double height;
        public Triangle(double w, double h)
        {
            width = w;
            height = h;
        }

        public double Area()
        {
            return Math.Round((width * height) / 2, 2);
        }

        public double Circumference()
        {
            double hypotenuse = Math.Sqrt(width * width + height * height);
            double sum = hypotenuse + width + height;
            return Math.Round(sum, 2);
        }
    }
}
