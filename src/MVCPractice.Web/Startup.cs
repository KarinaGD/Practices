using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCPractice.Web.Startup))]
namespace MVCPractice.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
