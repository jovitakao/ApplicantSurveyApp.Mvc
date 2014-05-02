using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ApplicantSurveyApp.Mvc.Web.Startup))]
namespace ApplicantSurveyApp.Mvc.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
