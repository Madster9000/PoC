using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using System.Web.Mvc;
using System.Web.Routing;

[assembly: OwinStartup(typeof(PoC.Easy.Web.Startup))]

namespace PoC.Easy.Web
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            //app.Run(context =>
            //{
            //    context.Response.ContentType = "text/html; charset=utf-8";
            //    return context.Response.WriteAsync("<h2>Привет мир!</h2>");
            //});
        }
    }
}
