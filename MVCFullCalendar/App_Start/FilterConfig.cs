using System.Web;
using System.Web.Mvc;

namespace MVCFullCalendarICal
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}