using System;


public class JournalEntries
{
    public List<string> _completedJournalEntries = new List <string>();

    static string GetDateTime()
    {
        string currentDateTime = "";
        currentDateTime = DateTime.Now.ToString("h:mm:ss tt yyyy-MM-dd"); 
        return currentDateTime;

    }

    static string ChoosePrompt()
    {
        string prompt = "";
        Random randomnumber = new Random();
        int randomPromptNumber = randomnumber.Next(1,5);

        if (randomPromptNumber == 1)

        {
            prompt = "What  occured today that was interesting or exciting to you?";
        }

        if (randomPromptNumber == 2)

        {
            prompt = "What happened today that you think you should of handled different?";
        }

        if (randomPromptNumber == 3)

        {
            prompt = "What goal would you like to  make to finish by the end of the week?";
        }

        if (randomPromptNumber == 4)

        {
            prompt = "What phyical fitness Goal would you like to  acheive by  the end of the week?";
        }
        if (randomPromptNumber == 5)

        {
            prompt = "What spirutal insights have you had  this week?";
        }

        if (randomPromptNumber < 1 ||  randomPromptNumber> 5)

        {
            Console.WriteLine("A Error Has Occured  Random Prompt number on line 11 of journalentries.cs is greater then or less then 0");
        }

        return prompt;

    }

    public void JournalEntry()
    {
        string dateTime = "";
        string prompt = "";
        string journalEntryInput = "";
        string journalEntryInputWithDateAndTime = "";
        string journalEntryInputCheck = "";
        string loweredJournalEntryInputCheck = journalEntryInputCheck.ToLower();
        bool journalEntryInputDone = false;
        dateTime = GetDateTime();
        prompt = ChoosePrompt();

        do{

        Console.WriteLine($"Todays prompt is {prompt} please enter your repsonse.");
        journalEntryInput = Console.ReadLine();
        System.Console.WriteLine($"Input Accepted your input was {journalEntryInput}");
        System.Console.WriteLine("Is this input ok? enter y/n");
        journalEntryInputCheck = Console.ReadLine();

        if (loweredJournalEntryInputCheck == "y")
        {
            Console.WriteLine("Entry Completed");
            journalEntryInputWithDateAndTime = (@$"{dateTime} {journalEntryInput}");
            _completedJournalEntries.Add(journalEntryInputWithDateAndTime);
            journalEntryInputDone = true;
        }
        else if (loweredJournalEntryInputCheck == "n")
        {
            Console.WriteLine("Ok Please Renter your response to the prompt.");
            journalEntryInputDone = false;
        }

        else
        {
            System.Console.WriteLine("Invalid input please enter y or n");
        }

        }while (journalEntryInputDone == false);

    }

    

}














