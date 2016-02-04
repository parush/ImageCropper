using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CropperTest.Startup))]
namespace CropperTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
