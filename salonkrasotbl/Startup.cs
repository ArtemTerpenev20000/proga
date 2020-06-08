using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(salonkrasotbl.Startup))]
namespace salonkrasotbl
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
