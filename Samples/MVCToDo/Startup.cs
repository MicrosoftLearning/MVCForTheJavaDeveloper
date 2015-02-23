using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCToDo.Startup))]
namespace MVCToDo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
