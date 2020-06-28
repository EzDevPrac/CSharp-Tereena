using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShopping
{
    class MarketingStaff
    {
        public List<Product> products = new List<Product>()
        {
            { new Product(1,"Mi",100)},
            { new Product(2,"Samsung",1000) },
            { new Product(3,"Dell",10000) }
        };

        public void ViewProducts()
        {
            foreach(var items in products)
            {
                Console.WriteLine("ProductId-{0}",items.GetId());
                Console.WriteLine("ProductName-{0}", items.GetName());
                Console.WriteLine("ProductCost-{0}",items.GetCost());
                Console.WriteLine("-----------------------");
            }
        }
        public int GetProductID(int id)
        {
            foreach (Product c in products)
            {
                if ((id == c.GetId()))
                {
                    return id;
                }
            }
            return 0;
        }
        public string GetName(int id)
        {
            foreach (Product c in products)
            {
                if ((id == c.GetId()))
                {

                    return c.GetName();
                }
            }
            return "";
        }
        public int GetProductCost(int id)
        {
            foreach (Product c in products)
            {
                if ((id == c.GetId()))
                {
                    return c.GetCost();
                }
            }
            return 0;
        }
        
    }
}
