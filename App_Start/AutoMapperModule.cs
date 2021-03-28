using Autofac;
using AutoMapper;
using Cars.Data.Models;
using Cars.Domain.Models;
using FirstApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstApp.App_Start
{
    public class AutoMapperModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.Register(context => new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<CarModel, CarViewModel>().ReverseMap();
                cfg.CreateMap<Car, CarModel > ().ReverseMap();
            }
            ));

            builder.Register(c =>
            {
                var context = c.Resolve<IComponentContext>();
                var config = context.Resolve<MapperConfiguration>();
                return config.CreateMapper(context.Resolve);
            })
                .As<IMapper>()
                .InstancePerLifetimeScope();
        }
    }
}