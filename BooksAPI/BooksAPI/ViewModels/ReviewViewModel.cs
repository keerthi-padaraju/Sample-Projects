using BooksAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


/*This class copies all the properties from Review entity to ReviewViewModel and vice versa 
 * helping it to prevent unwanted information being sent to the client.*/
namespace BooksAPI.ViewModels
{
    /* to keep our API RESTful, we return the newly created entity (or its view model representation) 
     * back to the client for consumption, removing the need to re-fetch the entire data set.*/
    public class ReviewViewModel
    {
        public ReviewViewModel()
        {
        }

        public ReviewViewModel(Review review)
        {
            if (review == null)
            {
                return;
            }

            BookId = review.BookId;
            Rating = review.Rating;
            Description = review.Description;
        }

        public int BookId { get; set; }
        public int Rating { get; set; }
        public string Description { get; set; }

        public Review ToReview()
        {
            return new Review
            {
                BookId = BookId,
                Description = Description,
                Rating = Rating
            };
        }
    }
}