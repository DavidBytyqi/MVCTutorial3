using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCTutorial3.Startup))]
namespace MVCTutorial3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
