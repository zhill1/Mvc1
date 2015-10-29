using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mvc1.Startup))]
namespace Mvc1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
