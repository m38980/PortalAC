using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PortalConsumidor.Startup))]
namespace PortalConsumidor
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
