﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Buoi9
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Sach", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
               name: "SachTheoCD",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "ChuDe", action = "SachTheoCD", id = UrlParameter.Optional }
           );
        }
    }
}