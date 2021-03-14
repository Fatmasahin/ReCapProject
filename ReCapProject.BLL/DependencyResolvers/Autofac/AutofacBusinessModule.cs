using System;
using Autofac;
using Autofac.Extras.DynamicProxy;
using Castle.DynamicProxy;
using ReCapProject.BLL.Abstract;
using ReCapProject.BLL.Concrete;
using ReCapProject.Core.Utilities.Interceptors;
using ReCapProject.DAL.Abstract;
using ReCapProject.DAL.Concrete.EntityFramework;

namespace ReCapProject.BLL.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule:Module
    {
        public AutofacBusinessModule()
        {
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CarManager>().As<ICarService>().SingleInstance();
            builder.RegisterType<ColorManager>().As<IColorService>().SingleInstance();
            builder.RegisterType<BrandManager>().As<IBrandService>().SingleInstance();
            builder.RegisterType<CarDAL>().As<ICarDAL>().SingleInstance();
            builder.RegisterType<ColorDAL>().As<IColorDAL>().SingleInstance();
            builder.RegisterType<BrandDAL>().As<IBrandDAL>().SingleInstance();
            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}
