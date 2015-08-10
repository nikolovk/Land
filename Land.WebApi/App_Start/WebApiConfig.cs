using Autofac;
using Autofac.Integration.WebApi;
using Land.Data.Repositories;
using Land.Data.Repositories.Interfaces;
using Land.Services.Owners;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection;
using System.Web.Http;

namespace Land.WebApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));


            var builder = new ContainerBuilder();


            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            builder.RegisterType<OwnersService>().As<IOwnersService>();
            builder.RegisterType<OwnerRepository>().As<IOwnerRepository>();

            var container = builder.Build();
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
}
