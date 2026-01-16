using System;

class Program
{
    static void Main(string[] args)
    {
        // Creating the first job class instance
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        // Creating the second job class instance
        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;

        // Creating the resume class instance
        Resume myResume = new Resume();
        myResume._name = "Demetrious Shoniwa";

        // Adding the jobs to resume list
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        // Displaying the resume itself
        myResume.Display();
    }
}