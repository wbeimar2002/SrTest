using SrTest.API.App_Start;
using SrTest.API.DependencyResolution;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web.Http;

namespace SrTest.API
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Configuración y servicios de API web
           
            // Rutas de API web
            config.MapHttpAttributeRoutes();
               
           
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            StructuremapWebApi.Start();


        }
    }
}
