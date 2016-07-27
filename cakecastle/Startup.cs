using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(cakecastle.Startup))]
namespace cakecastle
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
