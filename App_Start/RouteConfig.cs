using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SidcaMrv2
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            routes.MapRoute(
                "inicio",
                "Home",
                new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                "sobre",
                "About",
                new { controller = "Home", action = "About", id = UrlParameter.Optional }
            );

            routes.MapRoute(
               "contato",
               "contact",
               new { controller = "Home", action = "Contact", id = UrlParameter.Optional }
           );
            routes.MapRoute(
              "PendentesImportacao",
              url: "pendentes/importacao",
              new { controller = "Importacao", action = "Index", id = UrlParameter.Optional }
           );

            routes.MapRoute(
              "PendentesAcervo",
              url: "pendentes/acervo",
              new { controller = "PendentesAcervo", action = "Index", id = UrlParameter.Optional }
           );

            routes.MapRoute(
              "PendentesCadastro",
              url: "pendentes/cadastro",
              new { controller = "PendentesCadastro", action = "Index", id = UrlParameter.Optional }
           );
            /**/
            routes.MapRoute(
            "FinalizadoAcervo",
            url: "finalizado/acervo",
            new { controller = "FinalizadoAcervo", action = "Index", id = UrlParameter.Optional }
         );
            routes.MapRoute(
              "FinalizadoCadastro",
              url: "finalizado/cadastro",
              new { controller = "FinalizadoCadastro", action = "Index", id = UrlParameter.Optional }
           );


            routes.MapRoute(
              "PendenteCadCadastramento",
              url: "Pendente/cadastro/cadastramento",
              new { controller = "PendenteCadCadastramento", action = "Edit", id = UrlParameter.Optional }
           );
            /**/
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
