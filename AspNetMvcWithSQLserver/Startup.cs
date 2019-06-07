using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AspNetMvcWithSQLserver.Startup))]
namespace AspNetMvcWithSQLserver
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
