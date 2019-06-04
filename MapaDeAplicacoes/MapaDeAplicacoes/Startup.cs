using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MapaDeAplicacoes.Startup))]
namespace MapaDeAplicacoes
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
