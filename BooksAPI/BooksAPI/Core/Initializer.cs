using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BooksAPI.Core
{
    using System.Data.Entity;

    public class Initializer : MigrateDatabaseToLatestVersion<BooksContext, Configuration>
    {
    }
}