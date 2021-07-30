using BookStore.Logic.Services;
using BookStore.Presentation.DependencyResolvers;
using BookStore.Presentation.Extensions;
using BookStore.Presentation.HttpModules;
using Microsoft.Extensions.DependencyInjection;
using System.Web.Mvc;

namespace BookStore.Presentation.App_Start
{
    public class MicrosoftDependencyInjectionAdvanced
    {

        public static void SetupDependencyInjection()
        {
            var services = new ServiceCollection();
            services.AddTransient<ITestService, TestService>();

            services.AddControllersAsServices();

            ServiceScopeModule.SetServiceProvider(services.BuildServiceProvider());

            DependencyResolver.SetResolver(new MicrosoftDependencyResolverAdvanced());
        }

    }
}