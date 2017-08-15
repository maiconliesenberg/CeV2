using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CompraVenda.Startup))]
namespace CompraVenda
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
