using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SpacePowerResource.Startup))]
namespace SpacePowerResource
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
