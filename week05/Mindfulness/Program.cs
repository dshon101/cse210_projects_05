using System;

// Exceeding Requirements:
// 1. Activity log tracking - keeps count of how many times each activity has been performed
// 2. No duplicate prompts - ensures all prompts are used before repeating in reflection and listing activities
// 3. Enhanced breathing animation - the countdown appears next to the text for better visual flow

class Program
{
    static void Main(string[] args)
    {
        int breathingCount = 0;
        int reflectionCount = 0;
        int listingCount = 0;

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity breathing = new BreathingActivity();
                breathing.Run();
                breathingCount++;
            }
            else if (choice == "2")
            {
                ReflectionActivity reflection = new ReflectionActivity();
                reflection.Run();
                reflectionCount++;
            }
            else if (choice == "3")
            {
                ListingActivity listing = new ListingActivity();
                listing.Run();
                listingCount++;
            }
            else if (choice == "4")
            {
                Console.WriteLine($"\nActivity Log:");
                Console.WriteLine($"  Breathing: {breathingCount} times");
                Console.WriteLine($"  Reflection: {reflectionCount} times");
                Console.WriteLine($"  Listing: {listingCount} times");
                Console.WriteLine("\nThank you for using the Mindfulness Program!");
                break;
            }
        }
    }
}