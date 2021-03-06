﻿using Autofac;
using Autofac.Integration.WebApi;
using Land.Data.Repositories;
using Land.Data.Repositories.Interfaces;
using Land.Services.LandProperties;
using Land.Services.Mortgages;
using Land.Services.Owners;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection;
using System.Web.Http;
using System.Web.Http.Cors;

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
            builder.RegisterType<MortgagesService>().As<IMortgagesService>();
            builder.RegisterType<mortgageRepository>().As<ImortgageRepository>();
            builder.RegisterType<LandPropertiesService>().As<ILandPropertiesService>();
            builder.RegisterType<LandPropertyRepository>().As<ILandPropertyRepository>();

            var container = builder.Build();
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);

            var cors = new EnableCorsAttribute("*", "*", "*");
            config.EnableCors(cors);

            var formatters = GlobalConfiguration.Configuration.Formatters;
            var jsonFormatter = formatters.JsonFormatter;
            var settings = jsonFormatter.SerializerSettings;
            settings.Formatting = Formatting.Indented;
            settings.ContractResolver = new CamelCasePropertyNamesContractResolver();
        }
    }
}
