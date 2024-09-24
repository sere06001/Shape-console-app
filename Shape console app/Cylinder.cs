using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_console_app
{
    internal class Cylinder : IShape
    {
        double radius;
        double height;
        public Cylinder(double radius, double height)
        {
            this.radius = radius;
            this.height = height;
        }

        public double Area()
        {
            return Math.Round((2 * Math.PI * radius * height) + (2 * Math.PI * radius * radius), 2);
        }

        public double Circumference()
        {
            return Math.Round(2 * radius * Math.PI, 2);
        }
    }
}
