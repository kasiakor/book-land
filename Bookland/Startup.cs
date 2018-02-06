using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Bookland.Startup))]
namespace Bookland
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
