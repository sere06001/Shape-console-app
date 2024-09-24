using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_console_app
{
    internal class Sphere : IShape
    {
        double radius;
        public Sphere(double radius)
        {
            this.radius = radius;
        }

        public double Area()
        {
            return Math.Round(4 * radius * radius * Math.PI, 2);
        }

        public double Circumference()
        {
            return Math.Round(2 * radius * Math.PI, 2);
        }
    }
}
