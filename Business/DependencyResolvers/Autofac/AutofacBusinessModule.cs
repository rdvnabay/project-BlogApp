using Autofac;
using YazilimBlogApp.BusinessLayer.Abstract;
using YazilimBlogApp.BusinessLayer.Concrete;
using YazilimBlogApp.DataAccessLayer.Abstract;
using YazilimBlogApp.DataAccessLayer.Concrete.EfCore.EntityFramework;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<BlogManager>().As<IBlogService>().SingleInstance();
            builder.RegisterType<EfBlogDal>().As<IBlogDal>().SingleInstance();

            builder.RegisterType<CategoryManager>().As<ICategoryService>().SingleInstance();
            builder.RegisterType<EfCategoryDal>().As<ICategoryDal>().SingleInstance();
        }
    }
}

