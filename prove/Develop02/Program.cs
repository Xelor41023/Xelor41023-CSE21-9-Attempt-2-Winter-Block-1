using System;

class Program
{
    string filePath = "D:\School\CSE210 ( Attempt 2)\Repsotorys\Winter Block 1\Xelor41023-CSE21-9-Attempt-2-Winter-Block-1\prove\Develop02";
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
        UserJournal = MyJournal = new UserJournal();
        
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