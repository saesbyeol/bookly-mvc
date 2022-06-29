using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Http;
using AutoMapper;
using Bookly.App_Start;

namespace Bookly
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            // AUTO MAPPER SETUP
            Mapper.Initialize(c=>c.AddProfile<MappingProfile>());

            // WEB API INIT
            GlobalConfiguration.Configure(WebApiConfig.Register);

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
