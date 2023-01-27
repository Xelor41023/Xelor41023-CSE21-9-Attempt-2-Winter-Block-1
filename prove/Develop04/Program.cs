using System;

class Program
{
    static void Main(string[] args)
    {
        int ActivityChoice = 0;
        Console.WriteLine(@$"Welcome to the program what would you like to do today?
        
            1. Breathing Activity
            2. Reflection Activity
            3. Listing Activity
            4. Quit
            )"
        
            switch(ActivityChoice)
            {

                case 0:
                Activity myActivity = new Activity("Breathing", 60, "Welcome To The Activity ", "End Activity");

                break;




            }
        );



    
    }
}