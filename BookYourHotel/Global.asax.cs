using Interfaces;
using Services;
using SimpleInjector;
using SimpleInjector.Integration.WebApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace BookYourHotel
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            var container = new Container();
            container.Register<IBookingServices, BookingServices>(Lifestyle.Singleton);
            container.Verify();
            GlobalConfiguration.Configuration.DependencyResolver = new SimpleInjectorWebApiDependencyResolver(container);
            var config = new HttpConfiguration();
            config.MapHttpAttributeRoutes();

            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}