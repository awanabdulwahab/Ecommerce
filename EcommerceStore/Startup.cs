using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EcommerceStore.Startup))]
namespace EcommerceStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
