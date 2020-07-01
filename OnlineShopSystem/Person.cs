using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShopSystem
{
    class Person
    {
        private string FullName;
        private string Password;
        private string Email;
        private int PhoneNumber;
        private string BillingAddress;

        public Person()
        {

        }
        public Person(string fullname, string password, string email, int phoneNumber, string billingAddress)
        {
            this.FullName = fullname;
            this.Password = password;
            this.Email = email;
            this.PhoneNumber = phoneNumber;
            this.BillingAddress = billingAddress;

        }
        public Person(string UserName, string Password)
        {
            this.FullName = UserName;
            this.Password = Password;
        }

        public string _FullName { 
            get { return FullName; }
            set { FullName = value; } }
        public string _Password {
            get { return Password; }
            set { Password = value; }
        }
        public int _PhoneNumber {
            get { return PhoneNumber; }
            set { PhoneNumber = value; }
        }
        public string _Email {
            get { return Email; }
            set { Email = value; }
        }
        public string _Address {
            get { return BillingAddress; }
            set { BillingAddress = value; }
        }



    }
}
