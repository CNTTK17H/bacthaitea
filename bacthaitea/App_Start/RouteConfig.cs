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


            routes.MapRoute(
            name: "demo",
            url: "demo",
            defaults: new
            {
              controller = "Demo",
              action = "Index",
              id = UrlParameter.Optional
            }
          );

            routes.MapRoute(
            name: "Default",
            url: "{controller}/{action}/{id}",
            defaults: new
            {
             controller = "HomeUser",
             action = "Index",
             id = UrlParameter.Optional
            },
             namespaces: new[] {
                    "MvcArea.Controllers"
                }
            );
        }
    }
}
