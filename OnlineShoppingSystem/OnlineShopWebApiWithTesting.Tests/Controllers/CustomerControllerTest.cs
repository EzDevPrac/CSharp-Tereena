using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OnlineShopWebApiWithTesting.Controllers;
using System.Web.UI.WebControls;
using OnlineShopWebApiWithTesting.Models;

namespace OnlineShopWebApiWithTesting.Tests.Controllers
{
    
    [TestClass]
    public class CustomerControllerTest
    {
        
        [TestMethod]
        public void GetCustomerByName_ShouldReturnCustomer()
        {
            CustomerController customerController = new CustomerController();
            Customer customer = customerController.Get("Tereena");

            Assert.AreEqual("Tereena", customer.FullName);
            Assert.AreEqual("tereena", customer.Password);
            Assert.AreEqual("tereena@gmail.com", customer.Email);
            Assert.AreEqual(705665748, customer.PhoneNumber);
            Assert.AreEqual("Chittoor", customer.Address);
        }

        //[TestMethod]
        //public void TestMethod2()
        //{
        //    CustomerController customerController = new CustomerController();
        //    var testCustomers = GetTestProducts();
        //    Customer customer = customerController.Post(testCustomers);
            

        //}

        [TestMethod]
        public void GetAllCustomers_ShouldReturnAllCustomers()
        {
            
            var controller = new CustomerController();
            var testCustomers = GetTestProducts();
            var result = controller.Get();
            Assert.AreEqual(testCustomers.Count, result.Count);
        }

        private List<Customer> GetTestProducts()
        {
            var testCustomers = new List<Customer>();
            testCustomers.Add(new Customer { FullName = "Tereena", Password = "tereena", Email = "tereena@gmail.com", PhoneNumber = 705665748, Address = "Chittoor" });
            testCustomers.Add(new Customer { FullName = "Terna", Password = "terna", Email = "terna@gmail.com", PhoneNumber = 705748, Address = "Chittoor" });
            
            return testCustomers;
        }
    }
    
}
