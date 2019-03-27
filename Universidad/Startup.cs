using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Universidad.Startup))]
namespace Universidad
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
