using BasicWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BasicWebAPI.Controllers
{
    public class ProductController : ApiController
    {
        Entities db = new Entities();
        //POST 
        public string Post(Product product)
        {
            db.Products.Add(product);
            db.SaveChanges();
            return "product Added";
        }

        //GET
        public IEnumerable<Product> GetAll()
        {
            return db.Products.ToList();
        }

        //GET PRODUCT BY ID 
        public Product Get(int id)
        {
            Product product = db.Products.Find(id);
            return product;
        }

        //Update 
         public string update(int id, Product pro)
        {
            var product = db.Products.Find(id);
            product.Name = pro.Name;
            product.Price = pro.Price;
            product.Quanity = pro.Quanity;
            product.Active = pro.Active;
            db.Entry(product).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return "update Product Success ";
        }
        //DELETE 
        public string Delete(int id)
        {
            Product product = db.Products.Find(id);
            db.Products.Remove(product);
            return "Delete data success ";
        }

    }
}
