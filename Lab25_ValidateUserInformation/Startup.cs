using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lab25_ValidateUserInformation.Startup))]
namespace Lab25_ValidateUserInformation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
