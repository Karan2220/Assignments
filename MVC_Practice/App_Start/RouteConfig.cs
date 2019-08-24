using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC_Practice
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
         
            routes.MapRoute(
               name: "Add",
               url: "{controller}/{action}/{a}/{b}",
               defaults: new { controller = "Math", action = "Index", id = UrlParameter.Optional }
           );

            routes.MapRoute(
               name: "Square",
               url: "{controller}/{action}/{n}",
               defaults: new { controller = "Math", action = "Index", id = UrlParameter.Optional }
           );

            routes.MapRoute(
               name: "Age",
               url: "{controller}/{action}/{year}/{month}/{date}",
               defaults: new { controller = "Person", action = "Index", id = UrlParameter.Optional }
           );
            routes.MapRoute(
          name: "FullName",
          url: "{controller}/{action}/{firstname}/{lastname}",
          defaults: new { controller = "Person", action = "Index", id = UrlParameter.Optional }
      );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Math", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
