using Microsoft.AspNet.Identity.EntityFramework;
using BooksAPI.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BooksAPI.Core
{
        //Specifying which DbContext to be used by the UserStore
        public class BookUserStore : UserStore<IdentityUser>
        { 
            public BookUserStore() : base(new BooksContext())
            {
            }
        }
}