using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(TheMealDealWebApi.Startup))]

namespace TheMealDealWebApi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
