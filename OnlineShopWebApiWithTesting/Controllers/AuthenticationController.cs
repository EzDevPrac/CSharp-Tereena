using OnlineShopWebApiWithTesting.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OnlineShopWebApiWithTesting.Controllers
{
    public class AuthenticationController : ApiController
    {
        CustomerService customerService = new CustomerService();

        // POST: api/Authentication
        public IHttpActionResult Post(string username,string password)
        {
            var r = customerService.Login(username, password);
            return Ok(r);
        }
    }
}
