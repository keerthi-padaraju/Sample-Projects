using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using AuthTest.Models;

namespace AuthTest.Core
{
    public class AuthContext : IdentityDbContext
    {
        public DbSet<TestAuth> TestAuth { get; set; }
    }
}