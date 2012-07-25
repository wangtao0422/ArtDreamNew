using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Microsoft.Practices.Unity;
using ArtDream.Domain.Services.Interfaces;
using ArtDream.Domain.Services.Implementations;

namespace ArtDream.Web
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        private readonly IUnityContainer _unityContainer = new UnityContainer();
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Default", // Route name
                "{controller}/{action}/{id}", // URL with parameters
                new { controller = "Home", action = "Index", id = UrlParameter.Optional } // Parameter defaults
            );

        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);

            DependencyResolver.SetResolver(new UnityDependencyResolver(_unityContainer));
            ControllerBuilder.Current.SetControllerFactory(new DefaultControllerFactory(new UnityControllerActivator()));
            RegisterServices(_unityContainer);
        }

        private static void RegisterServices(IUnityContainer container)
        {
            container.RegisterType<IAccountService, AccountService>();
            container.RegisterType<IArticleService, ArticleService>();
        }
    }
}