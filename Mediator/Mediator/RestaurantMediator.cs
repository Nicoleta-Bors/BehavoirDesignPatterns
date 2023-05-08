using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class RestaurantMediator : IRestaurantMediator
    {
        private List<Restaurant> restaurants = new List<Restaurant>();
        private List<Review> reviews = new List<Review>();

        public void AddRestaurant(Restaurant restaurant)
        {
            restaurants.Add(restaurant);
        }

        public void AddReview(Review review)
        {
            reviews.Add(review);

            // Se calculeaza rating-ul mediu pentru fiecare restaurant
            foreach (var restaurant in restaurants)
            {
                double sum = 0;
                int count = 0;
                foreach (var r in reviews)
                {
                    if (r.RestaurantName == restaurant.Name)
                    {
                        sum += r.Rating;
                        count++;
                    }
                }
                restaurant.Rating = count > 0 ? sum / count : 0;
            }
        }

        public void DisplayReviewsForRestaurant(string restaurantName)
        {
            Console.WriteLine($"Reviews for restaurant {restaurantName}:");
            foreach (var r in reviews)
            {
                if (r.RestaurantName == restaurantName)
                {
                    Console.WriteLine($"{r.Rating}/5 stars - {r.Comment}");
                }
            }
        }

        public void DisplayAllRestaurants()
        {
            Console.WriteLine("All restaurants:");
            foreach (var restaurant in restaurants)
            {
                Console.WriteLine($"{restaurant.Name} ({restaurant.Rating}/5 stars)");
            }
        }
    }
}
