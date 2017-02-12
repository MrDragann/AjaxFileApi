using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AjaxFileApi.Startup))]
namespace AjaxFileApi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
