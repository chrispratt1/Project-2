using New_Project_2.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace New_Project_2
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            //tell the Entity Framework which connection we will be using
            Database.SetInitializer<NewProject2Context>(null);
            
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
