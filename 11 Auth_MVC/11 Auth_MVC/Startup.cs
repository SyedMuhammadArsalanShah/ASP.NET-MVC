using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_11_Auth_MVC.Startup))]
namespace _11_Auth_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
