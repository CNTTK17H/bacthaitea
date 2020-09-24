using System.Web.Mvc;

namespace bacthaitea.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
               "Admin_Order",
               "order",
                new { Controller = "Order", action = "Index", id = UrlParameter.Optional }
           );
            context.MapRoute(
                "Admin_Add_Product",
                "product/add-product",
                 new { Controller = "Product", action = "AddProduct", id = UrlParameter.Optional }
            );
            context.MapRoute(
                "Admin_Product",
                "list-product",
                 new { Controller = "Product", action = "Index", id = UrlParameter.Optional }
            );
            context.MapRoute(
               "Admin_Home",
               "home",
               new { Controller = "Home", action = "Index", id = UrlParameter.Optional }
           );
            context.MapRoute(
                "Admin_default",
                "Admin/{controller}/{action}/{id}",
                new { Controller ="Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}