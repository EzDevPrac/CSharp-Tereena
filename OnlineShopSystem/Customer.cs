using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace OnlineShopSystem
{
    class Customer : Person
    {
        
        public Customer()
        {

        }

        public Customer(string fullname, string password, string email, int phoneNumber, string billingAddress)
        {
            this._FullName = fullname;
            this._Password = password;
            this._Email = email;
            this._PhoneNumber = phoneNumber;
            this._Address = billingAddress;

        }

        
    }
}
