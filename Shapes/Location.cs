using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    class Location
    {
        public double x, y, side;


        public double GetX()
        {
            return x;
        }

        public double GetY()
        {
            return y;
        }

        public double GetSide()
        {
            return side;
        }
        public void SetX(double x)
        {
            this.x = x;
        }

        public void SetY(double y)
        {
            this.y = y;
        }

        public void SetSide(double side)
        {
            this.side = side;
        }
    }
}
