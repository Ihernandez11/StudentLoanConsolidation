using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StudentLoanConsolidation.Startup))]
namespace StudentLoanConsolidation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
