using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShopSystem
{
    interface ICartHandler
    {
        public void AddToCart();
        public void ViewCart();
        public void DeleteCart();

    }
}
