using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AerynBurgessBio.Startup))]
namespace AerynBurgessBio
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
