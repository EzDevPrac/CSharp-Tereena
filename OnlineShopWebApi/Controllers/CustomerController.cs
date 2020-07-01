using Newtonsoft.Json.Linq;
using OnlineShopWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
//using System.Web.Mvc;

namespace OnlineShopWebApi.Controllers
{
    public class CustomerController : ApiController
    {
        static List<Customer> customers = new List<Customer>()
        { 
            new Customer { FullName = "Tereena", Password = "tereena", Email = "tereena@gmail.com", PhoneNumber = 705665748, Address = "Chittoor" },
            new Customer { FullName = "Terna", Password = "terna", Email = "terna@gmail.com", PhoneNumber = 705748, Address = "Chittoor" },
        };

        
        // GET: api/Customer
        public List<Customer> Get()
        {
            return customers;
        }

        // GET: api/Customer/id

        public Customer Get(string id)
        {
            return customers.Where(c => c.FullName == id).FirstOrDefault();
        }

        //public IHttpActionResult Get(string id)
        //{
        //    Customer customer = customers.Where(c => c.FullName == id).FirstOrDefault();
        //    if(customer == null)
        //    {
        //        return NotFound();
        //    }
        //    else
        //    {
        //        return Ok(customer);
        //    }
        //}
        public void Post([FromBody]Customer customer)
        {
            customers.Add(customer);
        }

        public void Put(string id,[FromBody]Customer customer)
        {
            Customer customer1 = customers.Where(c => c.FullName == id).FirstOrDefault();
        }

        public void Delete(string id)
        {
            customers.Remove(customers.FirstOrDefault(c => c.FullName == id));
            
        }
    }
}