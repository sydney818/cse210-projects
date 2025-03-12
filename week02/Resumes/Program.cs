using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Junior Software Developer";
        job1._company = "Tech Solutions";
        job1._startYear = 2021;
        job1._endYear = 2023;
    
        Job job2 = new Job();

        job2._jobTitle = "Front-End Developer";
        job2._company = "Z Web Design";
        job2._startYear = 2023;
        job2._endYear = 2025;

        Resume myResume = new Resume();
        myResume._name = "Sydney Anderson";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
 
        myResume.Display();
    }

}