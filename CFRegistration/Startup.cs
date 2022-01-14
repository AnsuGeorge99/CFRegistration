using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CFRegistration.Startup))]
namespace CFRegistration
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
