using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DingDing.Startup))]
namespace DingDing
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
