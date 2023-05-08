using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class Client
    {
        private IRestaurantMediator mediator;

        public Client(IRestaurantMediator mediator)
        {
            this.mediator = mediator;
        }

        public void LeaveReview(string restaurantName, double rating, string comment)
        {
            mediator.AddReview(new Review { RestaurantName = restaurantName, Rating = rating, Comment = comment });
        }

        public void DisplayReviewsForRestaurant(string restaurantName)
        {
            mediator.DisplayReviewsForRestaurant(restaurantName);
        }

        public void DisplayAllRestaurants()
        {
            mediator.DisplayAllRestaurants();
        }
    }
}
