using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    class Square : Shape
    {
        Location c = new Location();
        public Square(double x, double y, double side)
        {
            c.SetX(x);
            c.SetY(y);
            c.SetSide(side);
        }

        public string ToString()
        {
            return "Corner (" + c.GetX() + " ," + c.GetY() + "), " + "side " + c.GetSide();
        }
        public void Move(double x, double y)
        {
            c.SetX(x);
            c.SetY(y);
        }

        public void Scale(int factor)
        {
            c.SetSide(c.GetSide() * factor);
        }

    }
}
