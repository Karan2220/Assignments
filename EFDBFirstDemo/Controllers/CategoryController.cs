using EFDBFirstDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EFDBFirstDemo.Controllers
{
    public class CategoryController : Controller
    {
        EFDBFirstDatabaseEntities context = new EFDBFirstDatabaseEntities();
        public ActionResult Index()
        {
            var categories = context.Categories.ToList();
            return View(categories);
        }

        public ActionResult Details( int Id)
        {
            var categories = context.Categories.FirstOrDefault(c => c.CategoryID == Id);
            return View(categories);
        }

        public ActionResult Edit( long id)
        {
            var category = context.Categories.FirstOrDefault(c => c.CategoryID == id);
            return View(category);
        }

        [HttpPost]
        public ActionResult Create(Category category)
        {
            var Editedcategory = context.Categories.FirstOrDefault(c => c.CategoryID == category.CategoryID);
            
            if(Editedcategory!=null)
            {
                Editedcategory.CategoryID= category.CategoryID;
                Editedcategory.CategoryName = category.CategoryName;
                context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int Id)
        {
            var deletedCategory = context.Categories.FirstOrDefault(c => c.CategoryID == Id);

            if(deletedCategory !=null)
            {
                context.Categories.Remove(deletedCategory);
                context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}