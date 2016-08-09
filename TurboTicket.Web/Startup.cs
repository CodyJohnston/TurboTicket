using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TurboTicket.Web.Startup))]
namespace TurboTicket.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
