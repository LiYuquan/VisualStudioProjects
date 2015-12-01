using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MySite.View.Startup))]
namespace MySite.View
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
