using System;
using System.Collections.Generic;  

class Resume
{
    public string _name = "";
    public List<Job> Jobs = new List<Job>();

    public void displayResume()
    {
        System.Console.WriteLine(_name);
        
        foreach (Job jobItem in Jobs)
        {
            jobItem.jobDisplay();
        }


    }

    











}