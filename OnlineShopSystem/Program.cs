using System;

namespace OnlineShopSystem
{
    class Program
    {
        CustomerHandler customerHandler = new CustomerHandler();
        AuthenticationCustomerHandler authenticationcustomerHandler = new AuthenticationCustomerHandler();
        MarketingPersonHandler marketingPersonHandler = new MarketingPersonHandler();
        public void customer()
        {
            for (; ; )
            {
                Console.WriteLine("\n\t\tWelcome to Online Shop System Customet Login");
                Console.WriteLine("--------------------------------------------------------------");
                Console.WriteLine("1.Login\n2.Register\n3.View Products\n4.Add to Cart\n");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        int authorise = authenticationcustomerHandler.Login();
                        if (authorise == 2)
                        {
                            CustomerOptions();
                        }
                        break;
                    case 2:
                        customerHandler.Register();
                        break;
                    case 3:
                        marketingPersonHandler.ViewProduct();
                        break;
                    case 4:
                        break;
                    default: break;
                }
            }
        }
        public void CustomerOptions()
        {
            for (; ; )
            {
                Console.WriteLine("Welcome");
                Console.WriteLine("1.View Products\n2.Add to Cart\n3.Update Account\n");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        marketingPersonHandler.ViewProduct();
                        break;
                    case 2:
                        break;
                    case 3:
                        customerHandler.UpdateCustomer();
                        break;
                    default: break;
                }
            }
        }
        public void MarketStaffOptions()
        {
            for (; ; )
            {
                Console.WriteLine("\n1. Add Product\n2. View Products\n3. Update Products\n4. Delete Product\n");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                            marketingPersonHandler.AddProduct();
                        break;
                    case 2:
                        marketingPersonHandler.ViewProduct();
                        break;
                    case 3:
                        marketingPersonHandler.UpdateProduct();
                        break;
                    case 4:
                        marketingPersonHandler.DeleteProduct();
                        break;
                    default: break;
                }
            }
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            MarketingPersonHandler marketingPersonHandler = new MarketingPersonHandler();
            Console.WriteLine("\t\tWelcome to Online Shop System");
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("1. Marketer Login\n2. Customer Login\n");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    int authorise = marketingPersonHandler.MarketStaffLogin();
                    if (authorise == 1)
                    {
                        program.MarketStaffOptions();
                    }
                    break;
                case 2:
                    program.customer();
                    break;
                default: break;
            }
        }
    }
    
}
