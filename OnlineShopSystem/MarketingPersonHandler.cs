using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShopSystem
{
    class MarketingPersonHandler : IMarketingPersonHandler
    {
        public int loginn = 0;
        List<Marketing> products = new List<Marketing>()
         {
            { new Marketing(1,"Mi",100)},
            { new Marketing(2,"Samsung",1000) },
            { new Marketing(3,"Dell",10000) }
        };

        public int MarketStaffLogin()
        {
            string Username = "123";
            string PassWord = "123";
            Console.WriteLine("Enter the Username and Password");
            string username = Console.ReadLine();
            string password = Console.ReadLine();
            if ((username == Username) && (password == PassWord))
            {
                loginn = 1;
                Console.WriteLine("Login Successful\n Welcome -{0}", Username);

            }
            else
            {
                Console.WriteLine("Invalid Credentials");
            }
            return loginn;
        }
        public void AddProduct()
        {
            //if (loginn != 0)
            //{
                Console.WriteLine("Number of Products to be added ?");
                int pnumber = Convert.ToInt32(Console.ReadLine());
                for (int i = 1; i <= pnumber; i++)
                {
                    Console.WriteLine("Enter Product {0} details:", i);
                    Console.WriteLine("Enter the ProductId:\n");
                    int productid = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("ProductName: \n");
                    string productname = Console.ReadLine();
                    Console.WriteLine("ProductCost:\n");
                    int productcost = Convert.ToInt32(Console.ReadLine());
                    Marketing product1 = new Marketing(productid, productname, productcost);
                    products.Add(product1);
                }
           // }
            //else
            //{
            //    Console.WriteLine("Please Login");
            //}
        }
        public void ViewProduct()
        {
            Console.WriteLine("\tProductId\tProductName\tProductCost");
            Console.WriteLine("---------------------------------------------------------------");
            foreach (Marketing c in products)
            {
                Console.Write("\t\t" + c._ProductId + "\t\t");
                Console.Write(c._ProductName + "\t\t");
                Console.Write(c._ProductCost);
                Console.WriteLine();
            }
            Console.WriteLine("---------------------------------------------------------------");
        }

        public void DeleteProduct()
        {
            //if (loginn != 0)
            //{
                Console.WriteLine("Enter the Product ID for Deletion:\n");
                int productid = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < products.Count; i++)
                {
                    if (productid == products[i]._ProductId)
                    {
                        products.Remove(products[i]);
                    }
                }
            //}
        }

        public void UpdateProduct()
        {
            //if (loginn != 0)
            //{
                int count = 0;
                Console.WriteLine("Enter the Product ID for Update:\n");
                int productid = Convert.ToInt32(Console.ReadLine());
                foreach (Marketing c in products)
                {
                    if (productid == c._ProductId)
                    {
                        count++;
                        Console.WriteLine("Enter the Product Name & Cost for Updation");
                        string name = Console.ReadLine();
                        int cost = Convert.ToInt32(Console.ReadLine());
                        c._ProductName = name;
                        c._ProductCost = cost;
                    }
                }
                if (count == 0)
                {
                    Console.WriteLine("Invalid Product Id");
                }
            //}
        }
    }
}
