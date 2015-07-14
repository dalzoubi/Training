using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CarwoodsApplication.Startup))]
namespace CarwoodsApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
