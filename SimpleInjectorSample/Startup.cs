using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SimpleInjectorSample.Startup))]
namespace SimpleInjectorSample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
