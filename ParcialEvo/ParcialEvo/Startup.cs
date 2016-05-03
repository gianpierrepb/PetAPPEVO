using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ParcialEvo.Startup))]
namespace ParcialEvo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
