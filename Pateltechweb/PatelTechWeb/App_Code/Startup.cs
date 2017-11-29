using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Pateltechweb.Startup))]
namespace Pateltechweb
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
