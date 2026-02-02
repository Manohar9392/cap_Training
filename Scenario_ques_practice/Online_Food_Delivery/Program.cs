using System;
using System.Collections.Generic;

namespace Online_Food_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;

            do
            {
                Console.WriteLine("\n===== Online Food Delivery System =====");
                Console.WriteLine("1. Add Restaurant");
                Console.WriteLine("2. Add Food Item");
                Console.WriteLine("3. View Restaurants Grouped By Cuisine");
                Console.WriteLine("4. Place Order");
                Console.WriteLine("5. View Pending Orders");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice: ");

                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input. Enter a number.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        AddRestaurantMenu();
                        break;

                    case 2:
                        AddFoodItemMenu();
                        break;

                    case 3:
                        DisplayRestaurantsByCuisine();
                        break;

                    case 4:
                        PlaceOrderMenu();
                        break;

                    case 5:
                        DisplayPendingOrders();
                        break;

                    case 0:
                        Console.WriteLine("Exiting application...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }

            } while (choice != 0);
        }

        // ===== Menu Methods =====

        /// <summary>
        /// Prompts the user to enter restaurant details and adds a new restaurant menu to the system.
        /// </summary>
        /// <remarks>This method interacts with the console to collect the restaurant name, cuisine type,
        /// location, and delivery charge from the user. The entered information is then used to add the restaurant via
        /// the delivery manager. Input validation is not performed; ensure that the delivery charge entered is a valid
        /// numeric value to avoid runtime errors.</remarks>

        static void AddRestaurantMenu()
        {
            Console.Write("Enter Restaurant Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Cuisine Type: ");
            string cuisine = Console.ReadLine();

            Console.Write("Enter Location: ");
            string location = Console.ReadLine();

            Console.Write("Enter Delivery Charge: ");
            double charge = double.Parse(Console.ReadLine());

            Delivery_Manger.AddRestaurant(name, cuisine, location, charge);
            Console.WriteLine("Restaurant added successfully!");
        }

        /// <summary>
        /// Displays a menu in the console to prompt the user for food item details and adds the new food item to the
        /// system.
        /// </summary>
        /// <remarks>This method interacts with the user via the console to collect the food item's name,
        /// category, price, and associated restaurant ID. The collected information is then passed to the food item
        /// management system for addition. Input validation is not performed; invalid or malformed input may cause
        /// exceptions.</remarks>

        public static void AddFoodItemMenu()
        {
            Console.Write("Enter Food Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Category: ");
            string category = Console.ReadLine();

            Console.Write("Enter Price: ");
            double price = double.Parse(Console.ReadLine());

            Console.Write("Enter Restaurant ID: ");
            int restaurantId = int.Parse(Console.ReadLine());

            Delivery_Manger.AddFoodItem(name, category, price, restaurantId);
            Console.WriteLine("Food item added successfully!");
        }

        /// <summary>
        /// Displays a list of restaurants grouped by cuisine type to the console.
        /// </summary>
        /// <remarks>If no restaurants are available, a message indicating this is displayed. Each group
        /// includes the cuisine name and details for each restaurant, such as ID, name, location, and delivery charge.
        /// This method is intended for console applications and writes output directly to the standard output
        /// stream.</remarks>

        public static void DisplayRestaurantsByCuisine()
        {
            var grouped = Delivery_Manger.GroupRestaurantsByCuisine();

            if (grouped.Count == 0)
            {
                Console.WriteLine("No restaurants available.");
                return;
            }

            foreach (var cuisine in grouped)
            {
                Console.WriteLine($"\nCuisine: {cuisine.Key}");
                foreach (var restaurant in cuisine.Value)
                {
                    Console.WriteLine(
                        $"Id: {restaurant.Id}, Name: {restaurant.Name}, " +
                        $"Location: {restaurant.Location}, Delivery Charge: {restaurant.DeliveryCharge}"
                    );
                }
            }
        }


        /// <summary>
        /// Displays a menu that prompts the user to enter a customer ID and a list of food item IDs, then attempts to
        /// place an order for the specified items.
        /// </summary>
        /// <remarks>This method interacts with the console to collect user input and provides feedback on
        /// whether the order was placed successfully. It is intended for use in a console application and requires
        /// valid customer and food item IDs to succeed.</remarks>

        public static void PlaceOrderMenu()
        {
            Console.Write("Enter Customer ID: ");
            int customerId = int.Parse(Console.ReadLine());

            Console.Write("Enter Food Item IDs (comma separated): ");
            string input = Console.ReadLine();

            List<int> itemIds = new List<int>();
            foreach (var id in input.Split(','))
            {
                if (int.TryParse(id.Trim(), out int itemId))
                {
                    itemIds.Add(itemId);
                }
            }

            bool success = Delivery_Manger.PlaceOrder(customerId, itemIds);

            if (success)
                Console.WriteLine("Order placed successfully!");
            else
                Console.WriteLine("Order failed. No valid food items found.");
        }


        /// <summary>
        /// Displays a list of all pending orders and their details to the console.
        /// </summary>
        /// <remarks>If there are no pending orders, a message indicating this is displayed. For each
        /// pending order, the method outputs the order's ID, customer ID, date, total amount, status, and a list of
        /// associated food items. This method is intended for console-based applications and writes output directly to
        /// the standard output stream.</remarks>

        public static void DisplayPendingOrders()
        {
            List<Order> orders = Delivery_Manger.GetPendingOrders();

            if (orders.Count == 0)
            {
                Console.WriteLine("No pending orders.");
                return;
            }

            foreach (var order in orders)
            {
                Console.WriteLine(
                    $"\nOrder Id: {order.Id}, Customer Id: {order.CustomerId}, " +
                    $"Date: {order.OrderDate}, Total: {order.TotalAmount}, Status: {order.Status}"
                );

                Console.WriteLine("Food Items:");
                foreach (var item in order.FoodItems)
                {
                    Console.WriteLine($" - {item.Name} ({item.Category}) : ₹{item.Price}");
                }
            }
        }
    }
}
