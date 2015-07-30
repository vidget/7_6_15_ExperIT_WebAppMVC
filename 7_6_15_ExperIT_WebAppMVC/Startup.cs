using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_7_6_15_ExperIT_WebAppMVC.Startup))]
namespace _7_6_15_ExperIT_WebAppMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
