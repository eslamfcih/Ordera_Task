using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ordera_Task.Startup))]
namespace Ordera_Task
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
