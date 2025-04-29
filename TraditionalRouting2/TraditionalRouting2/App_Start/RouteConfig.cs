using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace TraditionalRouting2
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapMvcAttributeRoutes();//Attribute Routing ke liye ye likhna hota hai
            /*routes.MapRoute(
                name: "allstudents",
                url: "students",
                defaults: new { Controller = "Student", action = "Getallstudents" }
                );
            routes.MapRoute(
                name: "getstudent",
                url: "students/{id}",
                defaults: new { Controller = "Student", action = "Getstudent", id = 1 }
                );
            routes.MapRoute(
                name: "studentaddress",
                url: "students/{id}/Address",
                defaults: new { Controller = "Student", action = "GetStudentAddress" },
                constraints: new{id = @"\d+"}
                );*/
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
