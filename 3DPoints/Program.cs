using System;

namespace _3DPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            _3DPoint point = new _3DPoint(5, 7, 2);
            Console.WriteLine(point.ToString());

            _3DPoint p2 = new _3DPoint(2, 3, 4);
            Console.WriteLine(point.DistanceTo(p2));
        }
    }
}
