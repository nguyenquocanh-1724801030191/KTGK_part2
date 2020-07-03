using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(showphone.Startup))]
namespace showphone
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
