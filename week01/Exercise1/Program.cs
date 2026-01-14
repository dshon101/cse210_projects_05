using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello and welcome.");
        Console.Write("So What is you firstname? ");

        string firstName = Console.ReadLine();
        Console.Write("What is your lastname? ");

        string lastName = Console.ReadLine();
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }
}