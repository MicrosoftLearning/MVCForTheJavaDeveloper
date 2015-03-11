using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ToDoSample.Startup))]
namespace ToDoSample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
