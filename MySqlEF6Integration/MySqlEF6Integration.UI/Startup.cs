using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MySqlEF6Integration.UI.Startup))]
namespace MySqlEF6Integration.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
