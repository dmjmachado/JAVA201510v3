using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JAVA201510v3.Startup))]
namespace JAVA201510v3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
