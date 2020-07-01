using Newtonsoft.Json.Linq;
using OnlineShopWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OnlineShopWebApi.Controllers
{
    public class AuthenticationController : ApiController
    {
        public IHttpActionResult Login(string username, string password)
        {
            CustomerController customerController = new CustomerController();
            var userLists = customerController.Get();
            foreach(var user in userLists)
            {
                if(user.FullName == username && user.Password == password)
                {
                    return Ok(user);
                }
            }
            return null;
        }
    }
}
