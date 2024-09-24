using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_console_app
{
    internal class Circle : IShape
    {
        double radius;
        public Circle(double r)
        {
            radius = r;
        }

        public double Area()
        {
            return Math.Round(radius * radius * Math.PI, 2);
        }

        public double Circumference()
        {
            return Math.Round(2 * radius * Math.PI, 2);
        }
    }
}
