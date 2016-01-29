using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(sthlmflowmvc.Startup))]
namespace sthlmflowmvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
