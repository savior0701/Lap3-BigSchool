using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lap3_BigSchool.Startup))]
namespace Lap3_BigSchool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
