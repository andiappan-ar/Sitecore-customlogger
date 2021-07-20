using Sitecore.CustomLogger.Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace Sitecore.CustomLogger.Controller
{
    public class TestController 
    {
        // GET: Test
        public void Index()
        {
            MethodBase method = System.Reflection.MethodBase.GetCurrentMethod();
            string fullMethodName = method.ReflectedType.Name + "." + method.Name;
            // Log
            WriteLogs.Info("SitecoreCustomLogger", fullMethodName + " Initiated");
            // Output will be below
            // TestController.Index Initiated
        }
    }
}