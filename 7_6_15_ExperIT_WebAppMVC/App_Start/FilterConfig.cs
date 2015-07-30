using System.Web;
using System.Web.Mvc;

namespace _7_6_15_ExperIT_WebAppMVC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
