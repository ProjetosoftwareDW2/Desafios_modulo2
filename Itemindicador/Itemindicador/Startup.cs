using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Itemindicador.Startup))]
namespace Itemindicador
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
