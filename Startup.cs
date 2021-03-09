using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PartyTTHK_K.Startup))]
namespace PartyTTHK_K
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
