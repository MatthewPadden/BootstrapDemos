using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CustomScaffolding.Startup))]
namespace CustomScaffolding
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
