using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(New_Project_2.Startup))]
namespace New_Project_2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
