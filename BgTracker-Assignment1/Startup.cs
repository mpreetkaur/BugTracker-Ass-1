using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BgTracker_Assignment1.Startup))]
namespace BgTracker_Assignment1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
