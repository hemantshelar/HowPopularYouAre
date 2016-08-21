using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HowPopularYouAreUI.Startup))]
namespace HowPopularYouAreUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
