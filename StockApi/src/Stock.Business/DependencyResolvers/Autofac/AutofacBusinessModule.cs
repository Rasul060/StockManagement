using Autofac;
using System;
using System.Collections.Generic;
using System.Text;
using Autofac.Extras.DynamicProxy;
using Stock.Business.Abstract;
using Stock.Business.Concrete;
using Stock.Core.Utilities.Interceptors;
using Stock.DataAccess.Abstract;
using Stock.DataAccess.Concrete.EntityFramework;
using Castle.DynamicProxy;
using Product.Business.Abstract;
using Product.Business.Concrete;
using Product.DataAccess.Abstract;
using Product.DataAccess.Concrete.EntityFramework;

namespace Stock.Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ProductStockManager>().As<IProductStockService>();
            builder.RegisterType<EfProductStockDal>().As<IProductStockDal>();

            builder.RegisterType<ProductManager>().As<IProductService>();
            builder.RegisterType<EfProductDal>().As<IProductDal>();


            //var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            //builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
            //    .EnableInterfaceInterceptors(new ProxyGenerationOptions()
            //    {
            //        Selector = new AspectInterceptorSelector()
            //    }).SingleInstance();

        }
    }
}
