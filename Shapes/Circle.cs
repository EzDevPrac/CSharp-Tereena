using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    class Circle : Shape
    {
        public double radius;
        public Circle(double r)
        {
            radius = r;
        }
        public override double Area()
        {
            double area = 3.14 * radius * radius;
            return area;
        }
        public override double Perimeter()
        {
            return 2 * 3.14 * radius;
        }
    }
}
