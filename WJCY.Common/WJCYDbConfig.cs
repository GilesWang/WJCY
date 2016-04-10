using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Caching;

namespace WJCY.Common
{
    public class WJCYDbConfig
    {
        private static readonly Cache dbConnctionStrCache = HttpRuntime.Cache;

        #region Properties
        public static string Environment { get { return ConfigurationManager.AppSettings["Environment"]; } }

        public static string ConnectionStr
        {
            get
            {

                if (dbConnctionStrCache["ConnectionStr"] == null)
                {
                    string connectionStr = ConfigurationManager.ConnectionStrings["WJCYContext"].ConnectionString;
                    dbConnctionStrCache.Add("ConnectionStr", connectionStr, null, Cache.NoAbsoluteExpiration, new TimeSpan(1, 0, 0), CacheItemPriority.Normal, null);
                    return connectionStr;
                }
                else
                {
                    return (string)dbConnctionStrCache["ConnectionStr"];
                }

            }
        }
        #endregion
    }
}
