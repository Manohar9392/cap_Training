using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Food_Delivery
{
    /// <summary>
    /// Provides static methods and collections for managing restaurants, food items, and orders in a food delivery
    /// system.
    /// </summary>
    /// <remarks>This class serves as a central manager for adding restaurants and food items, grouping
    /// restaurants by cuisine, placing orders, and retrieving pending orders. All members are static and the
    /// collections are maintained in memory. This class is not thread-safe.</remarks>
    public static class Delivery_Manger
    {
        public static List<Restaurant> Restaurants = new List<Restaurant>();// List to store restaurants
        public static List<FoodItem> FoodItems = new List<FoodItem>();// List to store food items
        public static List<Order> Orders = new List<Order>();// List to store orders

        /// <summary>
        /// Adds a new restaurant to the collection with the specified name, cuisine, location, and average charge.
        /// </summary>
        /// <param name="name">The name of the restaurant to add. Cannot be null or empty.</param>
        /// <param name="cuisine">The type of cuisine offered by the restaurant. Cannot be null or empty.</param>
        /// <param name="location">The location or address of the restaurant. Cannot be null or empty.</param>
        /// <param name="charge">The average charge per person at the restaurant. Must be a non-negative value.</param>

        public static void AddRestaurant(string name,string cuisine,string location,double charge)
        {
            Restaurant restaurant = new Restaurant(Restaurants.Count + 1, name, cuisine, location, charge);
            Restaurants.Add(restaurant);
        }

        /// <summary>
        /// Adds a new food item to the collection with the specified name, category, price, and associated restaurant.
        /// </summary>
        /// <param name="name">The name of the food item to add. Cannot be null or empty.</param>
        /// <param name="category">The category to which the food item belongs. Cannot be null or empty.</param>
        /// <param name="price">The price of the food item. Must be greater than or equal to 0.</param>
        /// <param name="restaurantId">The identifier of the restaurant to which the food item is associated.</param>
        public static void AddFoodItem(string name, string category, double price, int restaurantId)
        {
            FoodItem foodItem = new FoodItem(FoodItems.Count + 1, name, category, price, restaurantId);
            FoodItems.Add(foodItem);
        }

        /// <summary>
        /// Groups all restaurants by their cuisine type.
        /// </summary>
        /// <returns>A dictionary where each key is a cuisine type and the corresponding value is a list of restaurants that
        /// serve that cuisine. If no restaurants are available, the dictionary will be empty.</returns>

        public static Dictionary<string, List<Restaurant>> GroupRestaurantsByCuisine()
        {
            Dictionary<string, List<Restaurant>> groupedRestaurants = new Dictionary<string, List<Restaurant>>();
            foreach (Restaurant restaurant in Restaurants)
            {
                if (!groupedRestaurants.ContainsKey(restaurant.CuisineType))
                {
                    groupedRestaurants[restaurant.CuisineType] = new List<Restaurant>();
                }
                groupedRestaurants[restaurant.CuisineType].Add(restaurant);
            }
            return groupedRestaurants;
        }


        /// <summary>
        /// Attempts to place a new order for the specified customer with the given list of food item IDs.
        /// </summary>
        /// <remarks>The method creates an order only if at least one valid food item ID is provided. If
        /// none of the specified item IDs match available food items, no order is created and the method returns
        /// false.</remarks>
        /// <param name="customerId">The unique identifier of the customer placing the order.</param>
        /// <param name="itemIds">A list of food item IDs to include in the order. Each ID should correspond to an available food item.</param>
        /// <returns>true if the order was successfully placed; otherwise, false.</returns>

        public static bool PlaceOrder(int customerId, List<int> itemIds)
        {
            List<FoodItem> orderedItems = new List<FoodItem>();
            double totalAmount = 0;
            foreach (var item in itemIds)
            {
                
                foreach(var foodItem in FoodItems)
                {
                    if(foodItem.Id == item)
                    {
                        orderedItems.Add(foodItem);
                        totalAmount += foodItem.Price;
                    }
                }

            }
            if(orderedItems.Count > 0)
            {
                Order order = new Order(Orders.Count + 1, customerId, orderedItems, totalAmount);
                Orders.Add(order);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Retrieves a list of orders that are currently pending and have not yet been processed.
        /// </summary>
        /// <returns>A list of <see cref="Order"/> objects with a status of "Placed". The list is empty if there are no pending
        /// orders.</returns>


        public static  List<Order> GetPendingOrders()
        {
           return Orders.Where(o => o.Status == "Placed").ToList();
        }
    }
}
