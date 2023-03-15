using System.Web;
using System.Web.Mvc;

namespace LeTanDung_2011064649_bigschool
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
