using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OnlineShopWebApi.Controllers;
using OnlineShopWebApi.Models;

namespace OnlineShopWebApi.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            CustomerController customerController = new CustomerController();
            Customer customer = customerController.Get("Tereena");
            Assert.AreEqual("Tereena", customer.FullName);
            Assert.AreEqual("tereena", customer.Password);
            Assert.AreEqual("tereena@gmail.com", customer.Email);
            Assert.AreEqual(705665748, customer.PhoneNumber);
            Assert.AreEqual("Chittoor", customer.Address);
        }
    }
}
