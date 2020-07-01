using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShopSystem
{
    class AuthenticationCustomerHandler : IAuthenticationCustomerHandler
    {
        CustomerHandler customerhandler = new CustomerHandler();
        public int Login()
        {
            List<Customer> calledlist = customerhandler.GetList();
            //Console.WriteLine(calledlist[0]);
            Program program = new Program();
            Console.WriteLine("Enter the Username and Password");
            string username = Console.ReadLine();
            string password = Console.ReadLine();
            int count = 0;
            //foreach (Customer c in calledlist)
            //{
            //    Console.WriteLine("Login Succesfull\n");
            //    count = 1;
            if ((username == "mail") && (password == "1329"))
            {
                count = 2;
                Console.WriteLine("Login Succesfull\n");
            }
            if (count != 2)
            {
                Console.WriteLine("Invalid Credentials");
            }
            //}
            //if (count == 1)
            //{
            //    Console.WriteLine("No User Found");
            //}
            return count;
        }
    }
}
