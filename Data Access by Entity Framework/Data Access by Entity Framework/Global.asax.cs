using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Data_Access_by_Entity_Framework
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {

            Database.SetInitializer<Data_Access_by_Entity_Framework.Models.StudentContext>(null);
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
