using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_08_Model_First_Approach.Startup))]
namespace _08_Model_First_Approach
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
