using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace AuthTest.Core
{
    public class Initializer : MigrateDatabaseToLatestVersion<AuthContext, Configuration>
    {
    }
}