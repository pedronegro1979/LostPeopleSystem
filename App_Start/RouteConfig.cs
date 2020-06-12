using System.Web.Mvc;
using System.Web.Routing;

namespace LostPeopleSystem
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "LostPeopleSystem", action = "Index", id = UrlParameter.Optional },
                 namespaces: new[] { "RecreationalServicesTicketingSystem.Controllers" }
            );

            routes.MapRoute(
                name: "LostPeopleSystem",
                url: "{controller}/{action}/{name}/{id}"
            );
        }
    }
}
