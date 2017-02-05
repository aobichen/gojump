using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(www.gojump.com.tw.Startup))]
namespace www.gojump.com.tw
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
