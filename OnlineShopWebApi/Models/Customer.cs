using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShopWebApi.Models
{
    public class Customer
    {
        public string FullName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public string Address { get; set; }
    }
}