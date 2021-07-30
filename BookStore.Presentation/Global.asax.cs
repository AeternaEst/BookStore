using BookStore;
using BookStore.Presentation.App_Start;
using BookStore.Presentation.HttpModules;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

//[assembly: PreApplicationStartMethod(typeof(Global), "InitMicrosoftDependencyInjectionAdvanced")]
[assembly: PreApplicationStartMethod(typeof(Global), "InitMicrosoftDependencyInjection")]
namespace BookStore
{
    public class Global : System.Web.HttpApplication
    {

        public static void InitMicrosoftDependencyInjectionAdvanced()
        {
            RegisterModule(typeof(ServiceScopeModule));
            MicrosoftDependencyInjectionAdvanced.SetupDependencyInjection();
        }

        public static void InitMicrosoftDependencyInjection()
        {
            MicrosoftDependencyInjection.SetDependencyResolver();
        }

        protected void Application_Start()
        {
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }

    }
}