using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DeployMe.Startup))]
namespace DeployMe
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
