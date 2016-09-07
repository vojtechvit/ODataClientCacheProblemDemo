using Microsoft.Owin;
using SampleODataService.Model;
using Owin;
using System.Web.Http;
using System.Web.OData.Builder;
using System.Web.OData.Extensions;

[assembly: OwinStartup(typeof(SampleODataService.Startup))]

namespace SampleODataService
{
    public class Startup
    {
        public void Configuration(IAppBuilder appBuilder)
        {
            var config = new HttpConfiguration();

            var model = new ODataConventionModelBuilder();

            model.EntitySet<Organization>("organizations");

            config.MapODataServiceRoute("ODataRoot", "v1", model.GetEdmModel());

            appBuilder.UseWebApi(config);
        }
    }
}