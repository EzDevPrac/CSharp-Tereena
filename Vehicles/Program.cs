using System;

namespace Vehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            c.SetCost(300);
            Console.WriteLine(c.GetCost());
        }
    }
}
