using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignments.Controllers
{
    public class PersonController : Controller
    {
        [Route("Index")]
        [Route("")] // making Index actionMethod as default
        public ActionResult Index()
        {
            return View();
        }

        //[Route("Person/Age/{year}/{month}/{date}")]    
        [Route("Age/{year}/{month}/{date}")]
        [Route("{year}/{month}/{date}")]
        public ActionResult Age(int year, int month, int date)
        {
            DateTime today = DateTime.Today;
            int AgeInyears = today.Year - year;
            return Content("Age=" + AgeInyears);
        }

        //[Route("Person/FullName/{firstname}/{lastname}")]
        //[Route("FullName/{firstname}/{lastname}")]
        [Route("{firstname}/{lastname}")]
        public ActionResult FullName(string firstname, string lastname)
        {
            string fullname = firstname + " " + lastname;
            return Content("FullName=" + fullname);         
        }
    }
}