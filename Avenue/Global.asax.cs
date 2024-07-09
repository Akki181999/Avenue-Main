using Avenue.App_Start;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using DevExpress.Xpo.Logger;
using log4net;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Security;
using System.Web.SessionState;

namespace Avenue
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);

            // Initialize XPO
            XpoDefault.ConnectionString = ConfigurationManager.ConnectionStrings["Atlas"].ConnectionString;
            XpoDefault.Session = null; // This will create a new session for each request
        }
    }

}
