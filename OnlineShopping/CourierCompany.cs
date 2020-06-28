using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShopping
{
    class CourierCompany
    {
        public void OrderDelivery()
        {
            Console.WriteLine("We are getting your order ready to be shipped.");
        }
        public void Packing(string a)
        {
            Console.WriteLine("wrapping it as-{0}", a);
        }
        public void Delivery()
        {
            Console.WriteLine("Ready to be shipped");
        }
    }
}
