using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShopSystem
{
    interface IMarketingPersonHandler
    {
        public int MarketStaffLogin();
        public void AddProduct();
        public void ViewProduct();
        public void UpdateProduct();
        public void DeleteProduct();
    }
}
