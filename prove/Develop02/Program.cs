using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(@$"Welcome To Your Journal Please Select One Of the Following Options.
        1.Write
        2.Display
        3.Load
        4.Save
        5.Quit
        ");
        
        System.Console.WriteLine("Which One Would You Like To Do Today?");
        string UserInput = Console.ReadLine();
        
        if (UserInput == "1")
        {

        }
        else if (UserInput == "2")
        {

        }
        else if (UserInput == "3")
        {

        }
        else if (UserInput == "4")
        {
            
        }
        else if (UserInput == "5")
        {
            break;
        }
        else
        {
            System.Console.WriteLine("Invalid Input Please Enter 1-5");
        }
    }
}