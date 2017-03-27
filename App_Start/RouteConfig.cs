using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using HomeLibrary.Controllers;
using HomeLibrary.Models;

namespace HomeLibrary
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{author}/{name}",
                defaults:
                new
                {
                    controller = "Home",
                    action = "Index",
                    author = UrlParameter.Optional,
                    name = UrlParameter.Optional
                }
            );

            routes.MapRoute(
                name: "BooksList",
                url: "{controller}/{action}/{books}",
                defaults: new
                {
                    controller = "BooksList",
                    action = "Index",
                    books = UrlParameter.Optional
                }
            );
        }
    }
}
