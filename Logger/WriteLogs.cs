using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sitecore.CustomLogger.Logger
{
    public class WriteLogs
    {
        private static Func<string, ILog> getLogAppender = (x) => {return Diagnostics.LoggerFactory.GetLogger(x);};

        public static void Info(string logAppender,string message)
        {
            ILog logger = getLogAppender(logAppender);
            logger.Info(message);
        }

        public static void Error(string logAppender, Exception error)
        {
            ILog logger = getLogAppender(logAppender);
            logger.Error(error.ToString());
        }

        public static string GetMaskedPhoneNumber(string phoneNumber)
        {
            return string.Format("XXXXXXX{0}", phoneNumber.Substring(6, 3));
        }
    }
}