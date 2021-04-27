using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using Autofac.Extras.DynamicProxy;
using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.EntityFramework;

namespace BusinessLayer.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //Birisi IProductService isterse ona ProductManager instancesi ver
            //startup da yazdığımız kodla aynı işlevi sağlar
            builder.RegisterType<ProductManager>().As<IProductService>().SingleInstance(); //tek bir instance
            builder.RegisterType<EfProductDal>().As<IProductDAL>().SingleInstance();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();

        }
    }
}
