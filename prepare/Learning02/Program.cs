using System;
using System.Collections.Generic;  

class Program
{
    static void Main(string[] args)
    {
        Job Job1 = new Job();
        Job1._company = "Kroger";
        Job1._jobTitle = "Bagger";
        Job1._startYear = "2018";
        Job1._endYear = "2022";
        

        Job Job2 = new Job();
        Job2._company = "Walmart";
        Job2._jobTitle = "Greeter";
        Job2._startYear = "2015";
        Job2._endYear = "2018";
        

        Resume resume1 = new Resume();

        resume1._name  = " John Doe";

        resume1.Job1.jobInfoDisplay();
        resume1.Job2.jobInfoDisplay();


    }
}

