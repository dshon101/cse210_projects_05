using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base(
        "Breathing Activity",
        "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public override void Run()
    {
        StartActivity();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("\n\nBreathe in...");
            ShowCountdown(4);

            if (DateTime.Now >= endTime) break;

            Console.Write("\nNow breathe out...");
            ShowCountdown(6);
        }

        EndActivity();
    }
}