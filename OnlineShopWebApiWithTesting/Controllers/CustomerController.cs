using OnlineShopWebApiWithTesting.Models;
using OnlineShopWebApiWithTesting.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace OnlineShopWebApiWithTesting.Controllers
{
    public class CustomerController : ApiController
    {
        CustomerService customerService = new CustomerService();

        // GET: api/Customer
        public List<Customer> Get()
        {
            return customerService.GetCustomer();
        }

        //public IHttpActionResult Get()
        //{
        //    var b = customerService.GetCustomer();
        //    return Ok(b);
        //}

        // GET: api/Customer/name
        //public IHttpActionResult Get(string id)
        //{
        //     var a = customerService.GetCustomerByName(id);
        //    return Ok(a);
        //}

        public Customer Get(string id)
        {
            Customer a = customerService.GetCustomerByName(id);
            return a;
        }
        // POST: api/Customer
        public void Post([FromBody]Customer customer)
        {
            customerService.AddCustomer(customer);
        }

        // PUT: api/Customer/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Customer/5
        public void Delete(int id)
        {

        }
    }
}
