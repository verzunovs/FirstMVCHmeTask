using Autofac;
using Autofac.Integration.Mvc;
using Cars.Data.Contracts;
using Cars.Data.Repositories;
using Cars.Domain.Contracts;
using Cars.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstApp.App_Start
{
    public class AutofacConfig
    {
        public static void ConfigureContainer() 
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterType<CarsService>().As<ICarsService>();
            builder.RegisterType<CarsRepository>().As<ICarRepository>();
            builder.RegisterType<ShopService>().As<IShopService>();
            builder.RegisterType<ShopRepository>().As<IShopRepository>();
            builder.RegisterModule<AutoMapperModule>();

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}