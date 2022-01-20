using FA.JustBlog.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace FA.JustBlog
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //named parameters
            routes.MapRoute(
                name: "categories",
                url: "category/{year}/{month}",
                defaults: new { Controller = "Category", Action = "ListPosts" },
                constraints: new { year = @"\d{4}", month = @"\d{2}" },
                namespaces: new string[] { "FA.JustBlog.Controllers" }
                );

            routes.MapRoute(
                name: "Get Post By Title",
                url: "post/{url}",
                defaults: new { Controller = "Post", Action = "GetPostByTitle" },
                namespaces: new string[] { "FA.JustBlog.Controllers" }
                );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new string[] { "FA.JustBlog.Controllers" }
            );
        }
    }
}
