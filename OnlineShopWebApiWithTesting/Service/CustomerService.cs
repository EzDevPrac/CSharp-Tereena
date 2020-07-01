using OnlineShopWebApiWithTesting.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShopWebApiWithTesting.Service
{
    public class CustomerService
    {
        static List<Customer> customers = new List<Customer>()
        {
            new Customer { FullName = "Tereena", Password = "tereena", Email = "tereena@gmail.com", PhoneNumber = 705665748, Address = "Chittoor" },
            new Customer { FullName = "Terna", Password = "terna", Email = "terna@gmail.com", PhoneNumber = 705748, Address = "Chittoor" },
        };

        public List<Customer> GetCustomer()
        {
            return customers;
        }

        public void AddCustomer(Customer customer)
        {
            customers.Add(customer);
        }

        public Customer GetCustomerByName(string name)
        {
            return customers.Where(c => c.FullName == name).FirstOrDefault();
        }

        public Customer Login(string username, string password)
        {
            foreach(var user in customers) {
                if ((username == user.FullName) && (password == user.Password))
                {
                    return user;
                }
            }
            return null;
        }
    }
}