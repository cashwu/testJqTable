using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(testJqTable.Startup))]
namespace testJqTable
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
