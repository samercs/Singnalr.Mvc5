using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SignalrApp.Startup))]
namespace SignalrApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
