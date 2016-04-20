using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AssignmentWeb.Startup))]
namespace AssignmentWeb
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
