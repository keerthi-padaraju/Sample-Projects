using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AuthTest.Core
{
    public class TestUserStore : UserStore<IdentityUser>
    {
        public TestUserStore() : base(new AuthContext())
        {

        }
    }
}