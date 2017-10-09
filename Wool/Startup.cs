using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Wool.Startup))]
namespace Wool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
