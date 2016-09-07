using SampleODataService.Model;
using System.Web.Http;
using System.Web.OData;
using System.Web.OData.Routing;

namespace SampleODataService.Controllers
{
    [ODataRoutePrefix("organizations")]
    public class OrganizationsController : ODataController
    {
        [HttpGet, ODataRoute("({id})")]
        public IHttpActionResult Get([FromODataUri] int id)
        {
            var organization = new Organization
            {
                Id = 1,
                Name = "Organization 1"
            };

            return Ok(organization);
        }
    }
}