using AccessDetails;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace DatabaseConnection.Controllers
{
    [Route("api/[controller]")]
    public class DetailsController : ApiController
    {
        [HttpGet]
        public IEnumerable<Detail> Get()
        {
            using (API_TESTINGEntities entities = new API_TESTINGEntities())
            {
               return entities.Detail.ToList();
            }
        }
    }
}
