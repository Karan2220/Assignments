using EFDBFirstDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EFDBFirstDemo.Controllers
{
    public class ProductController : Controller
    {
        EFDBFirstDatabaseEntities context = new EFDBFirstDatabaseEntities();
        public ActionResult Index()
        {          
            var products =  context.Products.ToList();
            return View(products);
        }

        public ActionResult Details(int id)
        {
            var product = context.Products.FirstOrDefault(p=>p.ProductID == id);
            return View(product);
        }

        public ActionResult Add()
        {         
            return View();
        }

        [HttpPost]
        public ActionResult Create(Product product)
        {
            if(product!=null)
            {
                context.Products.Add(product);
                context.SaveChanges();
            }          
            return RedirectToAction("Index");
        }

        public ActionResult Edit(long Id)
        {
            var product = context.Products.FirstOrDefault(p => p.ProductID == Id);
            return View(product);
        }

        [HttpPost]
        public ActionResult Update(Product product)
        {
            var prod = context.Products.FirstOrDefault(p => p.ProductID == product.ProductID);
            prod.ProductID=  product.ProductID;
            prod.ProductName = product.ProductName;
            prod.Price = product.Price;
            prod.AvailabilityStatus = product.AvailabilityStatus;
            prod.DateOfPurchase = product.DateOfPurchase;
            prod.CategoryID = product.CategoryID;
            prod.BrandID = product.BrandID;
            prod.Active = product.Active;

            context.SaveChanges();
            return RedirectToAction("Index");
        }
      
        public ActionResult Delete( int Id)
        {
            var product = context.Products.FirstOrDefault(p => p.ProductID == Id);

            if(product !=null)
            {
                context.Products.Remove(product);
                context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

    }
}