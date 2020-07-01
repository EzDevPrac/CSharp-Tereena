using OnlineShopWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OnlineShopWebApi.Controllers
{
    public class ProductController : ApiController
    {
        List<Product> products = new List<Product>();

        public ProductController()
        {
            products.Add(new Product { ProductId = 1, ProductName = "Samsung", ProductCost = 1000 });
            products.Add(new Product { ProductId = 2, ProductName = "OnePlus", ProductCost = 2000 });
            products.Add(new Product { ProductId = 3, ProductName = "Mi", ProductCost = 3000 });
        }

        // GET: api/Product
        public List<Product> Get()
        {
            return products;
        }

        // GET: api/Product/id
        public Product Get(int id)
        {
            return products.Where(p => p.ProductId == id).FirstOrDefault();
        }

        // POST: api/Product
        public void Post([FromBody]Product product)
        {
            products.Add(product);
        }

        // PUT: api/Product/id
        public void Put(int id, [FromBody]Product product)
        {
            var entity = products.FirstOrDefault(p => p.ProductId == id);
            entity.ProductId = product.ProductId;
            entity.ProductName = product.ProductName;
            entity.ProductCost = product.ProductCost;
        }

        // DELETE: api/Product/id
        public void Delete(int id)
        {
            products.Remove(products.FirstOrDefault(p => p.ProductId == id));
        }
    }
}
