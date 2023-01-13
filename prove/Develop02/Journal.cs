using.System;
using System.IO;


public class userJournal
{
    
    
    public string MakeCsvFile()
    {
        JournalEntries myJournal = new JournalEntries();
        string _JournalName = "";
        Console.WriteLine("Please Enter Journal Name");
        _JournalName = System.Console.ReadLine();
        System.Console.WriteLine(@$"Input Accepted Journal Name is now {_JournalName}");

        using (StreamWriter outputFile = new StreamWriter(_JournalName))
        {
            foreach (string line in myJournal._completedJournalEntries)
            {
                File.AppendAllLines();

            }

        }

    }

    public static void saveEntries()
    {

    }

    public static void loadEntries()
    {

    }









}