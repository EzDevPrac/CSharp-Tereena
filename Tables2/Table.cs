using System;
using System.Collections.Generic;
using System.Text;

namespace Tables2
{
    class Table
    {
        protected double width;
        protected double height;
        public Table()
        {

        }
        public Table(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
        public double GetWidth()
        {
            return width;
        }
        public void SetWidth(double width)
        {
            this.width = width;
        }
        public double GetHeight()
        {
            return height;
        }
        public void SetHeight(double height)
        {
            this.height = height;
        }
        public virtual void ShowData()
        {
            Console.WriteLine("Width of table: {0}, Heigth of table: {1}", width, height);
        }
    }
}
