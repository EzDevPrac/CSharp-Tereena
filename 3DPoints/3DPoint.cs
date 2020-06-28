using System;
using System.Collections.Generic;
using System.Text;

namespace _3DPoints
{
    class _3DPoint
    {
        private double x, y, z;
        public _3DPoint(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public double GetX()
        {
            return x;
        }
        public void SetX(double x)
        {
            this.x = x;
        }
        public double GetY()
        {
            return y;
        }
        public void SetY(double y)
        {
            this.y = y;
        }
        public double GetZ()
        {
            return z;
        }
        public void SetZ(double z)
        {
            this.z = z;
        }
        public void MoveTo(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public override string ToString()
        {
            return "(" + x + "," + y + "," + z + ")";

        }
        public double DistanceTo(_3DPoint p2)
        {
            return Math.Sqrt((x - p2.GetX()) * (x - p2.GetX()) +
                (y - p2.GetY()) * (y - p2.GetY()) +
                (z - p2.GetZ()) * (z - p2.GetZ()));
            //return Math.Sqrt((x - p2.GetX()));
        }
    }
}
