using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VidlyAppWithNLayerArchitecture.Startup))]
namespace VidlyAppWithNLayerArchitecture
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
