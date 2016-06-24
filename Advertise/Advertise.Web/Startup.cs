using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Advertise.Web.Startup))]
namespace Advertise.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
