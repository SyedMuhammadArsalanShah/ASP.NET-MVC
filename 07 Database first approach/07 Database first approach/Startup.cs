using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_07_Database_first_approach.Startup))]
namespace _07_Database_first_approach
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
