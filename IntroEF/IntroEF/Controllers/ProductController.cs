using IntroEF.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntroEF.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            var db = new ProductDB_sm22Entities();
            var products = db.Products.ToList();
            return View(products);
        }
        public ActionResult Create() {
            var p = new Product() { Name="Jack fruit", Price=10,Qty=100,Description="National Fruit"};
            var db = new ProductDB_sm22Entities();
            db.Products.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int id) {
            var db = new ProductDB_sm22Entities();
            var product =(from p in db.Products where p.Id == id select p).SingleOrDefault();
            product.Name = "Banana";
            product.Price = 40;
            product.Qty = 100;
            product.Description = "Shobri";
            db.SaveChanges();
            return RedirectToAction("Index");

            //db.Products.Remove(p);
            //db.SaveChanges();

        }
        public ActionResult Delete(int id) {
            var db = new ProductDB_sm22Entities();
            var product = (from p in db.Products where p.Id == id select p).SingleOrDefault();
            db.Products.Remove(product);
            db.SaveChanges();
            return RedirectToAction("Index");

        }



    }
}