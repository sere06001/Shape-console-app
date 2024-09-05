using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_console_app
{
    internal class Triangle : Shape
    {
        public Triangle(double w, double h) : base(w, h)
        {
            width = w;
            height = h;
        }

        public override double Area(double width, double height)
        {
            return (width * height) / 2;
        }

        public override double Circumference(double width, double height)
        {
            double hypotenuse = Math.Sqrt(width * width + height * height);
            double sum = hypotenuse + width + height;
            return sum;
        }
    }
}
