using System.Web;
using System.Web.Mvc;
using WebApplication15.Filters;

namespace WebApplication15
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());

            //filters.Add(new ReauestLoggerAttribute());
        }
    }
}
