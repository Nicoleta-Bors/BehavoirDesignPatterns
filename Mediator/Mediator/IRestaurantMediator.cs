using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    interface IRestaurantMediator
    {
        void AddRestaurant(Restaurant restaurant);
        void AddReview(Review review);
        void DisplayReviewsForRestaurant(string restaurantName);
        void DisplayAllRestaurants();
    }
}
