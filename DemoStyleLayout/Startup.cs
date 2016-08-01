using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DemoStyleLayout.Startup))]
namespace DemoStyleLayout
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
