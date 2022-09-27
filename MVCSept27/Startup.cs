using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCSept27.Startup))]
namespace MVCSept27
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
