using System;

class Program
{
    static void Main(string[] args)
    {
        // Asking the user for their grade percentage
        Console.Write("Enter your grade percentage: ");
        int percentage = int.Parse(Console.ReadLine());

        // Determining the letter grade
        string letter;

        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80)
        {
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Determining the sign of the grade if it greater than or equal to 7 the its a "+" and when it less than 3 than its a "-"
        string sign = "";
        int lastDigit = percentage % 10;

        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if (lastDigit < 3 && lastDigit != 0)
        {
            sign = "-";
        }

        // Making sure that it does not assign A+ or F-
        if (letter == "A" && sign == "+")
        {
            sign = ""; // No A+
        }

        if (letter == "F")
        {
            sign = ""; // No F+ or F-
        }

        // Print the final grade
        Console.WriteLine($"Your letter grade is: {letter}{sign}");

        // Printing out the congratulations message if the user passed the course.
        if (percentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("Don't give up! Better luck next time.");
        }
    }
}