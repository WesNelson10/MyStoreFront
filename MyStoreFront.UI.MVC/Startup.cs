using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyStoreFront.UI.MVC.Startup))]
namespace MyStoreFront.UI.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
