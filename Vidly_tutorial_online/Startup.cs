using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Vidly_tutorial_online.Startup))]
namespace Vidly_tutorial_online
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
