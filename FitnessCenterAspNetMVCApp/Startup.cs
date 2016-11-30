using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FitnessCenterAspNetMVCApp.Startup))]
namespace FitnessCenterAspNetMVCApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
