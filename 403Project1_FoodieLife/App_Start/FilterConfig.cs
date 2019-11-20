using System.Web;
using System.Web.Mvc;

namespace _403Project1_FoodieLife
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
