using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Foody.Startup))]
namespace Foody
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
