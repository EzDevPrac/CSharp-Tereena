using System;

namespace Catalog
{
    class Program
    {
        static void Main(string[] args)
        {
            Film[] film = new Film[10];
            Music[] music = new Music[10];
            ComputerProgram[] computerprogram = new ComputerProgram[10];

            Item i = new Item("terna", "12n", "f", 1);
            Film f = new Film("q", "r", "s");
            f.SetName("hi");
            Console.WriteLine(f.GetName());
        }
    }
}
