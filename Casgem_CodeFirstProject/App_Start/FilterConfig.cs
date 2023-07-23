using System.Web;
using System.Web.Mvc;

namespace Casgem_CodeFirstProject
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
