using System;
using System.Collections.Generic;
using Ecommerce_product_catalog;
using Ecommerce_product_catalog1;

namespace Ecommerce_App
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;

            do
            {
                Console.WriteLine("\n===== E-Commerce Product Catalog =====");
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. View Products Grouped By Category");
                Console.WriteLine("3. Update Stock Quantity");
                Console.WriteLine("4. Get Products Below Price");
                Console.WriteLine("5. View Category Stock Summary");
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
                        AddProductMenu();
                        break;

                    case 2:
                        DisplayProductsByCategory();
                        break;

                    case 3:
                        UpdateStockMenu();
                        break;

                    case 4:
                        ProductsBelowPriceMenu();
                        break;

                    case 5:
                        DisplayCategoryStockSummary();
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

        static void AddProductMenu()
        {
            Console.Write("Enter Product Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Category: ");
            string category = Console.ReadLine();

            Console.Write("Enter Price: ");
            double price = double.Parse(Console.ReadLine());

            Console.Write("Enter Stock Quantity: ");
            int quantity = int.Parse(Console.ReadLine());

            InventoryManager.AddProduct(name, category, price, quantity);
            Console.WriteLine("Product added successfully!");
        }

        static void DisplayProductsByCategory()
        {
            var groupedProducts = InventoryManager.GroupProductsByCategory();

            if (groupedProducts.Count == 0)
            {
                Console.WriteLine("No products available.");
                return;
            }

            foreach (var category in groupedProducts)
            {
                Console.WriteLine($"\nCategory: {category.Key}");
                foreach (var product in category.Value)
                {
                    DisplayProduct(product);
                }
            }
        }

        static void UpdateStockMenu()
        {
            Console.Write("Enter Product Code: ");
            string code = Console.ReadLine();

            Console.Write("Enter New Stock Quantity: ");
            int quantity = int.Parse(Console.ReadLine());

            bool updated = InventoryManager.UpdateStock(code, quantity);

            if (updated)
                Console.WriteLine("Stock updated successfully!");
            else
                Console.WriteLine("Product not found.");
        }

        static void ProductsBelowPriceMenu()
        {
            Console.Write("Enter Maximum Price: ");
            double maxPrice = double.Parse(Console.ReadLine());

            List<Product> products = InventoryManager.GetProductsBelowPrice(maxPrice);

            if (products.Count == 0)
            {
                Console.WriteLine("No products found below this price.");
                return;
            }

            foreach (var product in products)
            {
                DisplayProduct(product);
            }
        }

        static void DisplayCategoryStockSummary()
        {
            var summary = InventoryManager.GetCategoryStockSummary();

            if (summary.Count == 0)
            {
                Console.WriteLine("No products available.");
                return;
            }

            Console.WriteLine("\nCategory Stock Summary:");
            foreach (var item in summary)
            {
                Console.WriteLine($"Category: {item.Key}, Products Count: {item.Value}");
            }
        }

        static void DisplayProduct(Product p)
        {
            Console.WriteLine(
                $"Code: {p.ProductCode}, Name: {p.ProductName}, " +
                $"Category: {p.Category}, Price: {p.Price}, Stock: {p.StockQuantity}"
            );
        }
    }
}
