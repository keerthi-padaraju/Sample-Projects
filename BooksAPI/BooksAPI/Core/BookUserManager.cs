using BooksAPI.Core;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class BookUserManager : UserManager<IdentityUser>
{
    public BookUserManager() : base(new BookUserStore())
    {
    }
}