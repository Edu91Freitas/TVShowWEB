using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TVShowWEB.Startup))]
namespace TVShowWEB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
