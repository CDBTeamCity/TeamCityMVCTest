using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TeamCityMVCTest.Startup))]
namespace TeamCityMVCTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
