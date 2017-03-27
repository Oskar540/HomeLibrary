using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HomeLibrary.Startup))]
namespace HomeLibrary
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
