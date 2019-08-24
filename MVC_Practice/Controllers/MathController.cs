using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Practice.Controllers
{
    public class MathController : Controller
    {
        // GET: Math
        public ActionResult Index()
        {            
            return View();
        }
        public ActionResult Add(int a, int b)
        {
            ViewBag.sum = a + b;
            return View();
        }
        public ActionResult Square(int n)
        {
            ViewBag.square = n * n;
            return View();
        }
    }
}