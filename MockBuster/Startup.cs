using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MockBuster.Startup))]
namespace MockBuster
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
