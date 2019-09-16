using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AllianceBankMVC_bmiles.Startup))]
namespace AllianceBankMVC_bmiles
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
