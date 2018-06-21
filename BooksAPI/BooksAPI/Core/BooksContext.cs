using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Owin;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using BooksAPI.Models;

namespace BooksAPI.Core
{

    public class BooksContext : IdentityDbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Review> Reviews { get; set; }
    }
}