using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Rectangle : Point
    {
        public double Length;
        public double Height;

        public Rectangle(double length, double height)
        {
            Length = length;
            Height = height;
        }

        public override double GetSquare()
        {
            return Length * Height;
        }
    }
}
