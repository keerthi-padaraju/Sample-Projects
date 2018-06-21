using AuthTest.Core;
using AuthTest.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace AuthTest.Controllers
{
    public class AuthController : ApiController
    {
        [HttpGet]
        public async Task<IHttpActionResult> Get()
        {
            using (var context = new Core.AuthContext())
            {
                return Ok(await context.TestAuth.ToListAsync());
            }
        }
    }
}
