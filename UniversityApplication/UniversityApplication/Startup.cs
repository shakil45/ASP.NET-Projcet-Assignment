using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UniversityApplication.Startup))]
namespace UniversityApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
