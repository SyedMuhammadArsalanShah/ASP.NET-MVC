using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BootstrapTemplate.Startup))]
namespace BootstrapTemplate
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
