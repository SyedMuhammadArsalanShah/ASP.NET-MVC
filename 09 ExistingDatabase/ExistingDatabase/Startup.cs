using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExistingDatabase.Startup))]
namespace ExistingDatabase
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
