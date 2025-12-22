using System;

class Program
{
    static void Main()
    {
        int choice;

        do
        {
            // Display menu
            Console.WriteLine("\n===== Main Menu =====");
            Console.WriteLine("1. Say Hello");
            Console.WriteLine("2. Display Date & Time");
            Console.WriteLine("3. Calculate Square of a Number");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Hello! Welcome to the program.");
                    break;

                case 2:
                    Console.WriteLine($"Current Date & Time: {DateTime.Now}");
                    break;

                case 3:
                    Console.Write("Enter a number to square: ");
                    int num = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Square of {num} is {num * num}");
                    break;

                case 4:
                    Console.WriteLine("Exiting... Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

        } while (choice != 4); // Keep showing menu until user chooses Exit
    }
}
