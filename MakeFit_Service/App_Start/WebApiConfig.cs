using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Microsoft.Practices.Unity;
using MakeFit_Service.DependencyResolver;
using Unity;

namespace MakeFit_Service
{
    public static class WebApiConfig
    {
        [Authorize]
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            var container = new UnityContainer();
            //container.RegisterType<>
            //  config.DependencyResolver = new MakeFit_Service.DependencyResolver.DependencyResolver(container);
            // Web API routes
            config.EnableCors();
            config.MapHttpAttributeRoutes();
            
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new {controller="index",action="getallusers", id = RouteParameter.Optional }                
            );
        }
    }
}
