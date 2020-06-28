using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShopping
{
    class Customer
    {
        public string FullName;
        public string Password;
        public string Email;
        public int PhoneNumber;
        public string BillingAddress;

        ShoppingCart sc = new ShoppingCart();
        SalesStaff ss = new SalesStaff();
        public Customer()
        {

        }
        public Customer(string fullname, string password, string email, int phoneNumber, string billingAddress)
        {
            this.FullName = fullname;
            this.Password = password;
            this.Email = email;
            this.PhoneNumber = phoneNumber;
            this.BillingAddress = billingAddress;

        }
        public Customer(string UserName, string Password)
        {
            this.FullName = UserName;
            this.Password = Password;
        }

        public string GetFullName()
        {
            return FullName;
        }
        public string GetEmail()
        {
            return Email;
        }
        public void SetFullName(string fullname)
        {
            this.FullName = fullname;
        }

        public string GetPassword()
        {
            return Password;
        }
        public void SetPassword(string password)
        {
            this.Password = password;
        }
        public int GetPhonenum()
        {
            return PhoneNumber;
        }
        public void SetPhoneNum(int phno)
        {
            this.PhoneNumber = phno;
        }
        public string GetAddress()
        {
            return BillingAddress;
        }
        public void SetAddress(string address)
        {
            this.BillingAddress = address;
        }
        
        public void AddCart(string mailid)
        {
            sc.AddToCart(mailid);

        }
        public void Display(string mailid)
        {
            sc.ViewCart(mailid);
        }
        //public void DeleteItem()
        //{
        //    sc.DeleteCart();
        //}
        public bool po;
        public bool PlaceOrder()
        {
            int a = sc.cart.Count;
            if (a != 0)
            {
                Console.WriteLine("do u want to place order.....if yes enter yes... if not enter no");
                string result = Console.ReadLine();
                if (result == "yes")
                {
                    ss.ProcessOrder();
                    po = true;
                    return true;
                }
                else
                {
                    Console.WriteLine("Can't process order");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("Cart is empty to place order");
                return false;
            }
        }
        public void Damage()
        {
            if (po == true)
            {
                Console.WriteLine("If there is damage in item ....enter yes..if not no");
                string damage = Console.ReadLine();
                if (damage == "yes")
                {
                    ss.Refund();

                }
                else
                {
                    Console.WriteLine("No damage ..so cant return money");

                }
            }
            else
            {
                Console.WriteLine("Place order first to return");
            }
        }
    }
}
