using.System;
using System.IO;


public class UserJournal
{
    
    
    public string makeCsvFile()
    {
        JournalEntries myJournal = new JournalEntries();
        string _journalName = "";
        Console.WriteLine("Please Enter Journal Name");
        _journalName = System.Console.ReadLine();
        System.Console.WriteLine(@$"Input Accepted Journal Name is now {_journalName}");

        using (StreamWriter outputFile = new StreamWriter(_journalName))
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