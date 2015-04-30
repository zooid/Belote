using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Belote.Web.Startup))]
namespace Belote.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
