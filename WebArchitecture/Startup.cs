using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebArchitecture.Startup))]
namespace WebArchitecture
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
