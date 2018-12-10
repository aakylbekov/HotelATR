using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HotelAtr.Web.Startup))]
namespace HotelAtr.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
