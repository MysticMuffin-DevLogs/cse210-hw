using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Microsft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2019;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._company = "Adobe";
        job2._jobTitle = "Graphic Designer";
        job2._startYear = 2000;
        job2._endYear = 3000;

        Resume myResume = new Resume();
        myResume._personName = "John Doe";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.DisplayResume();
    }
}