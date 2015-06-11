using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Katalogen.Startup))]
namespace Katalogen
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
