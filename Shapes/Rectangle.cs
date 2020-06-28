using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    class Rectangle : Shape
    {
        public double side1, side2;
        public Rectangle(double s1, double s2)
        {
            side1 = s1;
            side2 = s2;
        }
        public override double Area()
        {
            return side1 * side2;
        }
        public override double Perimeter()
        {
            double perimeter = 2 * (side1 + side2);
            return perimeter;
        }
    }
}
