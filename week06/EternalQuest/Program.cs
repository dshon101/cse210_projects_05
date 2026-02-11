using System;

// Exceeding Requirements:
// 1. Added leveling system - users level up every 1000 points with special messages
// 2. Added negative goal type - users lose points for bad habits they want to break
// 3. Added achievement badges - unlock special badges at milestone scores (500, 2000, 5000)
// 4. Added goal streak counter - tracks consecutive days of completing eternal goals

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}