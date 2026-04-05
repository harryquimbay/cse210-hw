using System;

class Program
{
    static void Main(string[] args)
    {
        int choice = 0;

        while (choice != 4)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflection activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");

            string input = Console.ReadLine();
            Console.WriteLine();

            if (int.TryParse(input, out choice))
            {
                if (choice == 1)
                {
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.Run();
                }
                else if (choice == 2)
                {
                    ReflectionActivity reflection = new ReflectionActivity();
                    reflection.Run();
                }
                else if (choice == 3)
                {
                    ListingActivity listing = new ListingActivity();
                    listing.Run();
                }
                else if (choice == 4)
                {
                    Console.WriteLine("Goodbye!");
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
            }

            if (choice != 4)
            {
                Console.WriteLine();
                Console.WriteLine("Press enter to return to the menu.");
                Console.ReadLine();
            }
        }
    }
}