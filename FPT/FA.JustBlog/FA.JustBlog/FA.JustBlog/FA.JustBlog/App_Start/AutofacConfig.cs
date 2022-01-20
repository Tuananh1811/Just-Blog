using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using FA.JustBlog.Core;
using FA.JustBlog.Core.Infrastructures;
using FA.JustBlog.Core.Repositories;
using FA.JustBlog.Services.Categories;
using FA.JustBlog.Services.Posts;
using System.Linq;
using System.Web.Http;
using System.Web.Mvc;

namespace FA.JustBlog.App_Start
{
    public class AutofacConfig
    {
        public static void RegisterComponents()
        {
            var builder = new ContainerBuilder();
            //register
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterApiControllers(typeof(MvcApplication).Assembly);

            builder.RegisterType<JustBlogContext>().AsSelf().InstancePerRequest();

            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerRequest();

            // Scan an assembly for components
            builder.RegisterAssemblyTypes(typeof(PostRepository).Assembly)
                   .Where(t => t.Name.EndsWith("Repository"))
                   .AsImplementedInterfaces()
                   .InstancePerLifetimeScope();

            builder.RegisterAssemblyTypes(typeof(PostService).Assembly)
                   .Where(t => t.Name.EndsWith("Service"))
                   .AsImplementedInterfaces()
                   .InstancePerLifetimeScope();

            //category
            builder.RegisterAssemblyTypes(typeof(CategoryRepository).Assembly)
                   .Where(t => t.Name.EndsWith("Repository"))
                   .AsImplementedInterfaces()
                   .InstancePerLifetimeScope();

            builder.RegisterAssemblyTypes(typeof(CategoryService).Assembly)
                   .Where(t => t.Name.EndsWith("Service"))
                   .AsImplementedInterfaces()
                   .InstancePerLifetimeScope();

            var container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            GlobalConfiguration.Configuration.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
}