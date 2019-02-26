using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WondoorfulDesignsStore.Startup))]
namespace WondoorfulDesignsStore
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
