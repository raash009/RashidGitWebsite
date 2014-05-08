using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RashidGitWebsite.Startup))]
namespace RashidGitWebsite
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
