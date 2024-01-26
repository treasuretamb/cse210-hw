using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // instances of Job class
        Job job1 = new Job("Junior Web Developer", "Amazon", 2025, 2026);
        Job job2 = new Job("Web Developer", "Apple", 2027, 2033);

        // instance of Resume class
        Resume myResume = new Resume("Treasure Tamb");

        // Add jobs to the list of jobs in the Resume
        myResume.AddJob(job1);
        myResume.AddJob(job2);

        // Display resume
        myResume.Display();
    }
}