using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ragnar.Startup))]
namespace Ragnar
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
