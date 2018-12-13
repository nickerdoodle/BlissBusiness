using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SomethingBorrowed.Startup))]
namespace SomethingBorrowed
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
