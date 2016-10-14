using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAngular.Startup))]
namespace WebAngular
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
