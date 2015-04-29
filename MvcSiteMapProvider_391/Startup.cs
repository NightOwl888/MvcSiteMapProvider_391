using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcSiteMapProvider_391.Startup))]
namespace MvcSiteMapProvider_391
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
