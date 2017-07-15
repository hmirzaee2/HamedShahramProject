using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HamedShahramProject.Startup))]
namespace HamedShahramProject
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
