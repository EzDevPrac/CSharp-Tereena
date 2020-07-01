using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShopSystem
{
    class Marketing : Person
    {
        private int ProductId;
        private string ProductName;
        private int ProductCost;

        public Marketing()
        {

        }
        public Marketing(int productid, string productname, int productcost)
        {
            this.ProductId = productid;
            this.ProductName = productname;
            this.ProductCost = productcost;
        }
        public int _ProductId
        {
            get { return ProductId; }
            set { ProductId = value; }
        }
        public string _ProductName
        {
            get { return ProductName; }
            set { ProductName = value; }
        }
        public int _ProductCost
        {
            get { return ProductCost; }
            set { ProductCost = value; }
        }
    }
}
