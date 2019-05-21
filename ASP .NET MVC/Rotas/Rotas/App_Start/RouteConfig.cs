﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Rotas
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name:" Todas as noticias",
                url:"noticias/",
                defaults: new { controller = "Home", action = "TodasNoticias" }
                );

            routes.MapRoute(
                name: "Categoria especifica",
                url: "noticias/{categoria}",
                defaults: new { controller = "Home", action = "MostrarCategoria" }
                );

            routes.MapRoute(
                name: "Mostra noticia",
                url: "noticias/{categoria}/{titulo}-{noticiaId}/",
                defaults: new { controller = "Home", action = "MostrarNoticia" }
                );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
