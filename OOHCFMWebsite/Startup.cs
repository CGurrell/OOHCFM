using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OOHCFMWebsite.Startup))]
namespace OOHCFMWebsite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
