using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LeTanDung_2011064649_bigschool.Startup))]
namespace LeTanDung_2011064649_bigschool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
