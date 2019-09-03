using EFDBFirstDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EFDBFirstDemo.Controllers
{
    public class BrandController : Controller
    {
        EFDBFirstDatabaseEntities _context = new EFDBFirstDatabaseEntities();
        public ActionResult Index()
        {
            var brands =  _context.Brands.ToList();
            return View(brands);
        }

        public ActionResult Details(int id)
        {
            var brand = _context.Brands.FirstOrDefault(b => b.BrandID == id);
            return View(brand);
        }

        public ActionResult Edit(long Id)
        {
            var brand = _context.Brands.FirstOrDefault(b => b.BrandID == Id);
            return View(brand);
        }
         
        [HttpPost]
        public ActionResult Create(Brand brand)
        {
            var Editedbrand = _context.Brands.FirstOrDefault(b => b.BrandID == brand.BrandID);

            //left side datebase values and right side form values. 
            //assigning form values to database values.

            if(Editedbrand != null)
            {
                Editedbrand.BrandID = brand.BrandID;
                Editedbrand.BrandName = brand.BrandName;
                _context.SaveChanges();
            }
        

            return RedirectToAction("Index");
        }

        public ActionResult Delete( int Id)
        {
            var deleteBrand = _context.Brands.FirstOrDefault(b => b.BrandID == Id);

            if(deleteBrand !=null)
            {
                _context.Brands.Remove(deleteBrand);
                _context.SaveChanges();
            }
          

            return RedirectToAction("Index");
        }
    }
}