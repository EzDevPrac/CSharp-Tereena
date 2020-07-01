using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShopSystem
{
    class CustomerHandler : ICustomerHandler
    {
        List<Customer> customers = new List<Customer>();
        public List<Customer> GetList()
        {
            return customers;
        }
        public void Register()
        {
            Console.WriteLine("Enter fullname \n password\n email\n phonenum \n address\n ");
            string fullname = Console.ReadLine();
            string password = Console.ReadLine();
            string email = Console.ReadLine();
            int phone = Convert.ToInt32(Console.ReadLine());
            string address = Console.ReadLine();

            Customer customer = new Customer(fullname,password,email,phone,address);

            
            customers.Add(customer);
        }

        public void Retrieve()
        {
            foreach(Customer c in customers)
            {
                Console.WriteLine("FullName-{0}, Password-{1},Email-{1}, PhoneNumber-{2}, Address-{3}",
                    c._FullName,c._Password,c._Email,c._PhoneNumber,c._Address);
            }
        }

        public void UpdateCustomer()
        {
            Console.WriteLine("Enter the Username and Password to change details");
            string username = Console.ReadLine();
            string password = Console.ReadLine();
            foreach(Customer c in customers)
            {
                if ((username == c._Email) && (password == c._Password))
                {
                    Console.WriteLine("Enter the password to change");
                    string pass = Console.ReadLine();
                    c._Password = pass;
                }
            }
           
        }
    }
}
