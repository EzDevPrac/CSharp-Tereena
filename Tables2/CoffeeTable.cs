using System;
using System.Collections.Generic;
using System.Text;

namespace Tables2
{
    class CoffeeTable : Table
    {
        public CoffeeTable(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
        public override void ShowData()
        {
            Console.WriteLine("Width of coffeetable: {0}, Heigth of coffeetable: {1}", width, height);
        }
    }
}
