using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Marketing.Startup))]
namespace Marketing
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
