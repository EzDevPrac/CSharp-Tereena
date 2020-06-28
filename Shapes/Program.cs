using System;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle ci = new Circle(5);
            Console.WriteLine(ci.Area());

            Square sq = new Square(10, 5, 7);
            sq.Move(5, 10);
            sq.Scale(2);
            Console.WriteLine(sq.ToString());
        }
    }
}
