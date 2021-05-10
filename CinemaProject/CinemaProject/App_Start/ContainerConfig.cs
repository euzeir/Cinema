using Autofac;
using Autofac.Integration.Mvc;
using CinemaProjectData.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CinemaProject
{
    public class ContainerConfig
    {
        internal static void RegisterContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterType<InMemoryCinemaData>().As<ICinema>().SingleInstance();
            builder.RegisterType<InMemoryCinemaData>().As<ISalaCinematografica>().SingleInstance();
            builder.RegisterType<InMemoryCinemaData>().As<ISpettatore>().SingleInstance();
            builder.RegisterType<InMemoryCinemaData>().As<IBiglietto>().SingleInstance();

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}