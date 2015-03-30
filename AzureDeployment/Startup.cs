using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AzureDeployment.Startup))]
namespace AzureDeployment
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
