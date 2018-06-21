using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SocialAuth.Startup))]
namespace SocialAuth
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
