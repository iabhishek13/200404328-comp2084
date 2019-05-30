using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApplication1_200404328.Startup))]
namespace WebApplication1_200404328
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
