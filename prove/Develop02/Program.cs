using System;

class Program
{
    string filePath = "D:\\School\\CSE210 ( Attempt 2)\\Repsotorys\\Winter Block 1\\Xelor41023-CSE21-9-Attempt-2-Winter-Block-1\\prove\\Develop02";
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
        UserJournal MyJournal = new UserJournal();
        JournalEntries journalEntries = new JournalEntries();

        if (UserInput == "1")
        {
            journalEntries.JournalEntry();
        }
        else if (UserInput == "2")
        {
           MyJournal.displayCSV();
        }
        else if (UserInput == "3")
        {
               MyJournal.ReadFromCSV();
        }
        else if (UserInput == "4")
        {
           MyJournal.writeToCSV(journalEntries._completedJournalEntries); 
        }
        else if (UserInput == "5")
        {
            System.Environment.Exit(1);
        }
        else
        {
            System.Console.WriteLine("Invalid Input Please Enter 1-5");
        }
    }
}