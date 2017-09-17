using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_14DTHC1_2.Startup))]
namespace _14DTHC1_2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
