using System;
using System.Collections.Generic;  
public class Job
{
    public string _company = "";
    public string _jobTitle = "";
    public string _startYear = "";
    public string _endYear  = "";

    public void jobInfoDisplay()
    {
        System.Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }









}