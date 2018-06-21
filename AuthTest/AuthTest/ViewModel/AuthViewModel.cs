using AuthTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/*This class copies all the properties from Review entity to ReviewViewModel and vice versa 
 * helping it to prevent unwanted information being sent to the client.*/
namespace AuthTest.ViewModels
{
    /* to keep our API RESTful, we return the newly created entity (or its view model representation) 
     * back to the client for consumption, removing the need to re-fetch the entire data set.*/
    public class AuthViewModel
    {
        public AuthViewModel()
        {
        }

        public AuthViewModel(TestAuth test)
        {
            if (test == null)
            {
                return;
            }

            ID = test.ID;
            Name = test.Name;
            Desc = test.Desc;
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }

        public TestAuth ToReview()
        {
            return new TestAuth
            {
                ID = ID,
                Desc = Desc,
                Name = Name
            };
        }
    }
}