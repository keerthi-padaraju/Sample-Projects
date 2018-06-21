using BooksAPI.Core;
using BooksAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Data.Entity;
using System.Web.Http;

namespace BooksAPI.Controllers
{
    [Authorize(Roles = "Administrator")]
    //RESTful endpoint to retrieve all the books data
    public class BooksController : ApiController
    {
        /*async allows the thread to be released whilst data is 
         *being retrieved from the database and converted to objects to be consumed by the code.
         *And code picks up where it left once the async is complete.
         */
        
        [HttpGet]
        public async Task<IHttpActionResult> Get()
        {
            using (var context = new BooksContext())
            {
                return Ok(await context.Books.Include(x => x.Reviews).ToListAsync());
            }
        }
    }
}