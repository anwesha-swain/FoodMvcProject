using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using Food.Data.Services;
using System.Web.Http;
using System.Web.Mvc;

namespace Food.Web
{
    public class ContainerConfig
    {
        internal static void RegisterContainer(HttpConfiguration httpConfiguration)
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterApiControllers(typeof(MvcApplication).Assembly);
            //builder.RegisterType<InMemoryRestaurantData>()      //used this before creating database context
            //    .As<IRestaurantData>()
            //    .SingleInstance();
            builder.RegisterType<SqlRestaurantData>()
                .As<IRestaurantData>()
                .InstancePerRequest();
            builder.RegisterType<FoodDbContext>().InstancePerRequest();
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            httpConfiguration.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
}