using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AuthTest.Core
{
    //Specifying which DbContext to be used by the UserStore
    public class TestUserManager : UserManager<IdentityUser>
    {
        public TestUserManager() : base(new TestUserStore())
        {
        }
    }
}