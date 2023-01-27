using System.Diagnostics;
using System.Threading;
using System;

public class Activity
{
    private string _activityName;
    private int    _activityDuration;
    private string _activitystartMessage;
    private string _activityendMessage;

    public Activity(string activityName, int activityDuration, string activityStartMessage, string activityEndMessage)
    {
        _activityName = activityName;
        _activityDuration = activityDuration;
        _activitystartMessage = activityStartMessage;
        _activityendMessage = activityEndMessage;
    }

    public string getActivityName()
    {
        return _activityName;
    }
    public int getActivityDuration()
    {
        return _activityDuration;
    }
    public string getActivityStartMessage()
    {
        return _activitystartMessage;
    }
    public string getActivityEndMessage()
    {
        return _activityEnd;
    }

    public void displaySpinner(int numSecondsToRun)
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        int spinnerCounter = 0;

        while (stopwatch.ElapsedMilliseconds / 1000 < numSecondsToRun)
        {
            spinnerCounter++;
            switch (spinnerCounter %4)
            {
                case 0: 
                Console.WriteLine("/");
                break;

                case 1: 
                Console.WriteLine("-"); 
                break;

                case 2: 
                Console.WriteLine("\\"); 
                break;

                case 3:
                Console.WriteLine("|"); 
                break;
            }
        }
        Console.Write(" ");
    }
}

