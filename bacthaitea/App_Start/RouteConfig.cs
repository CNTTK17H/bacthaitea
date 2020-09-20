using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace bacthaitea
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
                routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
                routes.MapRoute(
                name: "Order",
                url: "order",
                defaults: new { controller = "Order", action = "Index" }
                );
             routes.MapRoute(
             name: "Report",
             url: "report",
             defaults: new { controller = "Report", action = "Index" }
             );
            routes.MapRoute(
              name: "Product",
              url: "list-pruduct",
              defaults: new { controller = "Product", action = "Index" }
            );

            routes.MapRoute(
               name: "Home",
               url: "home",
               defaults: new { controller = "Home", action = "Index"}
           );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
