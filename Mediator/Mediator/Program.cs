namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Se creeaza mediatorul
            var mediator = new RestaurantMediator();

            // Se adauga restaurante
            mediator.AddRestaurant(new Restaurant { Name = "Pizza Hut" });
            mediator.AddRestaurant(new Restaurant { Name = "McDonald's" });
            mediator.AddRestaurant(new Restaurant { Name = "KFC" });

            // Se adauga review-uri
            var client1 = new Client(mediator);
            client1.LeaveReview("Pizza Hut", 4, "The pizza was delicious!");

            var client2 = new Client(mediator);
            client2.LeaveReview("McDonald's", 2, "The burger was cold and tasted bad.");

            var client3 = new Client(mediator);
            client3.LeaveReview("KFC", 3, "The chicken was okay, but the fries were cold.");

            // Se afiseaza toate restaurantele
            client1.DisplayAllRestaurants();

            // Se afiseaza review-urile pentru Pizza Hut
            client2.DisplayReviewsForRestaurant("Pizza Hut");

            // Se afiseaza review-urile pentru KFC
            client3.DisplayReviewsForRestaurant("KFC");

            // Se adauga inca un review pentru Pizza Hut
            client1.LeaveReview("Pizza Hut", 5, "Best pizza ever!");

            // Se afiseaza review-urile pentru Pizza Hut
            client2.DisplayReviewsForRestaurant("Pizza Hut");

            // Se afiseaza toate restaurantele, inclusiv noul rating pentru Pizza Hut
            client2.DisplayAllRestaurants();

        }
    }
}