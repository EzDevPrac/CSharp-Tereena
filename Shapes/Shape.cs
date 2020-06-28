using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    class Shape
    {
        Location l = new Location();

        public string ToString()
        {
            return "";
        }
        public virtual double Area()
        {
            return 0.0;
        }

        public virtual double Perimeter()
        {
            return 0.0;
        }
    }
}
