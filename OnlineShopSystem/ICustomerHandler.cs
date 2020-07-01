using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShopSystem
{
    interface ICustomerHandler
    {
        public void Register();
        public void Retrieve();
        public void UpdateCustomer();

    }
}
