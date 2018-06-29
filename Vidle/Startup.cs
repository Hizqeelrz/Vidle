using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Vidle.Startup))]
namespace Vidle
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
