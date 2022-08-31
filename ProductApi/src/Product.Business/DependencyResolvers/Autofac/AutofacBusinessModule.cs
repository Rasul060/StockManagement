using Autofac;
using Product.Business.Abstract;
using Product.Business.Concrete;
using Product.DataAccess.Abstract;
using Product.DataAccess.Concrete.EntityFramework;

namespace Product.Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ProductManager>().As<IProductService>();
            builder.RegisterType<EfProductDal>().As<IProductDal>();

            builder.RegisterType<ProductCategoryManager>().As<IProductCategoryService>();
            builder.RegisterType<EfProductCategoryDal>().As<IProductCategoryDal>();

            // var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            //builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
            //    .EnableInterfaceInterceptors(new ProxyGenerationOptions()
            //    {
            //        Selector = new AspectInterceptorSelector()
            //    }).SingleInstance();

        }
    }
}
