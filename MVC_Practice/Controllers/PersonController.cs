using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Practice.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Age(int year, int month, int date)
        {
            DateTime today = DateTime.Today;
            ViewBag.AgeInYears = today.Year - year;           
            return View();
        }
        public ActionResult FullName(string firstname, string lastname)
        {
            ViewBag.FullName = firstname + lastname;
            return View();
        }
    }
}