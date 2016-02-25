using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Applicative_Order.Startup))]
namespace Applicative_Order
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
