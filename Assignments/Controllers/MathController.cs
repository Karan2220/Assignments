using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignments.Controllers
{
    public class MathController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [Route("Math/Add/{a}/{b}")]
        public ActionResult Add(int a , int b)
        {
            int sum = a + b;
            return Content("Sum=" + sum);
        }

        //[Route("Math/Square/{n}")]
        [Route("{n}")]
        public ActionResult Square(int? n)
        {
            int? square = n * n;
            
            if(n.GetType() == typeof(int))
            {
                return Content("Square=" + square);
            }
            else
            {
                return Content("only numbers are allowed");
            }
           
        }
    }
}