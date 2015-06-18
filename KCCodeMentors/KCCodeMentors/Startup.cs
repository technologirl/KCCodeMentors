using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KCCodeMentors.Startup))]
namespace KCCodeMentors
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
