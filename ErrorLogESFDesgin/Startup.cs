using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ErrorLogESFDesgin.Startup))]
[assembly: log4net.Config.XmlConfigurator(ConfigFile = "Web.config", Watch = true)]
namespace ErrorLogESFDesgin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
