using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ViewNumberSeq.Startup))]
namespace ViewNumberSeq
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
