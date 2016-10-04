using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_TuinCentrum.Startup))]
namespace MVC_TuinCentrum
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
