using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ASP.NET_Routes
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // routes.MapRoute(
            //     name: "Default",
            //     url: "{controller}/{action}/{id}",
            //     defaults: new {controller = "Home", action = "Index", id = UrlParameter.Optional}
            // );
            
            routes.MapRoute(// /V2
                name: "R-1",
                url: "V2",
                defaults: new {controller = "MResearch", action = "M02"});
            
            routes.MapRoute(// /V3
                name: "M-2",
                url: "V3",
                defaults: new { controller = "MResearch", action = "M03" }
            );
            
            routes.MapRoute(// /MResearch
                name: "M-3",
                url: "{controller}",
                defaults: new { controller = "MResearch", action = "M01" }
            );
            
            routes.MapRoute(// /V2/MResearch/M01/1
                name: "M-4",
                url: "V2/{controller}/{action}/{id}",
                defaults: new { controller = "MResearch", id = UrlParameter.Optional }
            );
            
            routes.MapRoute(
                name: "M-5",
                url: "V3/{controller}/{id}",
                defaults: new { controller = "MResearch", action = "M03", id = UrlParameter.Optional }
            );
            
            routes.MapRoute(
                name: "M-6",
                url: "V3/{controller}/{id}/{action}",
                defaults: new { controller = "MResearch", id = UrlParameter.Optional }
            );
            
            routes.MapRoute(
                name: "M-7",
                url: "{controller}/{action}/{id}",
                defaults: new { id = UrlParameter.Optional }
            );
            
            routes.MapRoute(
                name: "M",
                url: "",    
                defaults: new { controller = "MResearch", action = "M01", id = UrlParameter.Optional }
            );
        }
    }
}