using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(newSmartEvent.Startup))]
namespace newSmartEvent
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
