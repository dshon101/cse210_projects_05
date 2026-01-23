using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        /*
         * EXCEEDING REQUIREMENTS:
         * - The program stores multiple scriptures.
         * - A scripture is selected at random for memorization.
         * - Only unhidden words are hidden each round.
         * - After completing a scripture, a new random one is chosen.
         */

        List<Scripture> scriptures = new List<Scripture>
        {
            new Scripture(
                new Reference("John", 3, 16),
                "For God so loved the world that he gave his only begotten Son that whosoever believeth in him should not perish but have everlasting life"
            ),
            new Scripture(
                new Reference("Proverbs", 3, 5, 6),
                "Trust in the Lord with all thine heart and lean not unto thine own understanding In all thy ways acknowledge him and he shall direct thy paths"
            ),
            new Scripture(
                new Reference("Psalm", 23, 1),
                "The Lord is my shepherd I shall not want"
            ),
            new Scripture(
                new Reference("Philippians", 4, 13),
                "I can do all things through Christ which strengtheneth me"
            ),
            new Scripture(
                new Reference("Romans", 8, 28),
                "And we know that all things work together for good to them that love God to them who are the called according to his purpose"
            ),
            new Scripture(
                new Reference("Isaiah", 41, 10),
                "Fear thou not for I am with thee be not dismayed for I am thy God I will strengthen thee yea I will help thee yea I will uphold thee with the right hand of my righteousness"
            ),
            new Scripture(new Reference("Proverbs", 15,1),
                "A soft answer turneth away wrath but grievous words stir up anger"
            )

        };

        Random random = new Random();

        while (scriptures.Count > 0)
        {
            Scripture scripture = scriptures[random.Next(scriptures.Count)];

            while (true)
            {
                Console.Clear();
                scripture.Display();

                if (scripture.IsCompletelyHidden())
                {
                    break;
                }

                Console.WriteLine();
                Console.Write("Press Enter to continue or type 'quit' to exit: ");
                string input = Console.ReadLine().ToLower();

                if (input == "quit")
                {
                    return;
                }

                scripture.HideRandomWords(3);
            }

            scriptures.Remove(scripture);

            Console.WriteLine("\nScripture completed!");
            Console.Write("Press Enter for a new scripture or type 'quit' to exit: ");

            if (Console.ReadLine().ToLower() == "quit")
            {
                return;
            }
        }

        Console.WriteLine("\nAll scriptures completed. Well done!");
    }
}
