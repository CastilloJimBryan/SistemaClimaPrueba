using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SsitemaClima.Startup))]
namespace SsitemaClima
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
