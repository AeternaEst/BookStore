using BookStore.Logic.Services;
using BookStore.Presentation.DependencyResolvers;
using BookStore.Presentation.Extensions;
using Microsoft.Extensions.DependencyInjection;

namespace BookStore.Presentation.App_Start
{
    public class MicrosoftDependencyInjection
    {
        public static void SetDependencyResolver()
        {
            var services = new ServiceCollection();

            services.AddTransient<ITestService, TestService>();

            services.AddControllersAsServices();

            var serviceProvider = services.BuildServiceProvider();

            var dependencyResolver = new MicrosoftDependencyResolver(serviceProvider);

            System.Web.Mvc.DependencyResolver.SetResolver(dependencyResolver);
        }
    }
}
