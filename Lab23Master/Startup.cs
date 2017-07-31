using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lab23Master.Startup))]
namespace Lab23Master
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
