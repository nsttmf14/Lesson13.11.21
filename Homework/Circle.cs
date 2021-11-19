using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Circle : Point
    {
        public double Radius;

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double GetSquare()
        {
            return 2 * Math.PI * Radius * Radius;
        }
    }
}
