using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Food_Delivery
{
    public class FoodItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
        public int RestaurantId { get; set; }

        /// <summary>
        /// Initializes a new instance of the FoodItem class with the specified identifier, name, category, price, and
        /// associated restaurant.
        /// </summary>
        /// <param name="id">The unique identifier for the food item.</param>
        /// <param name="name">The name of the food item. Cannot be null or empty.</param>
        /// <param name="category">The category to which the food item belongs. Cannot be null or empty.</param>
        /// <param name="price">The price of the food item. Must be greater than or equal to 0.</param>
        /// <param name="restaurantId">The identifier of the restaurant that offers this food item.</param>
        public FoodItem(int id, string name, string category, double price, int restaurantId)
        {
            this.Id = id;
            this.Name = name;
            this.Category = category;
            this.Price = price;
            this.RestaurantId = restaurantId;
        }
    }
}
