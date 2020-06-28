using System;

namespace Tables2
{
    class Program
    {
        static void Main(string[] args)
        {
            CoffeeTable ct = new CoffeeTable(10, 5);
            ct.ShowData();

            Table[] mytables = new Table[10];
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                mytables[i] = new Table(random.Next(50, 201), random.Next(50, 201));
                mytables[i].ShowData();
            }
            for (int i = 5; i < 10; i++)
            {
                mytables[i] = new CoffeeTable(random.Next(40, 121), random.Next(40, 121));
                mytables[i].ShowData();
            }
        }
    }
}
