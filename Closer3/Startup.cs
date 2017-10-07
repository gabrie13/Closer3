using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Closer3.Startup))]
namespace Closer3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
