using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_10_DataAnnotations.Startup))]
namespace _10_DataAnnotations
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
