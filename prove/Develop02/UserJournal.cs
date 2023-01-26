using System;
using System.Text;


public class UserJournal 
{

    string filePath = "D:\\School\\CSE210 ( Attempt 2)\\Repsotorys\\Winter Block 1\\Xelor41023-CSE21-9-Attempt-2-Winter-Block-1\\prove\\Develop02";
    //JournalEntries journalEntries = new JournalEntries();
    List<string> entriesInCSV = new List<string>();
    public void writeToCSV(List<string> journalEntries)
    {
       StringBuilder builder = new StringBuilder();
        // Loop through journalEntries and write them to file.
        foreach 
       string prompt = journalEntries.choose
       string _completedJournalEntries = ;
       foreach (string line in _)
       builder.AppendLine(string.Format("{0}|{1}", prompt, _completedJournalEntries));

       File.WriteAllText(filePath, builder.ToString());
    }

    public void ReadFromCSV()
    {
        StreamReader streamReader = new StreamReader(filePath);

        while (!streamReader.EndOfStream)
        {
            var line = streamReader.ReadLine();
            //var values =  line.Split('|');
            entriesInCSV.Add(line.Replace('|', ' '));
        }

        // Console.WriteLine("{0}}(1}", values[0], values[1]);
    }

    public void displayCSV()
    {
        foreach (string entry in entriesInCSV)
        {
            Console.WriteLine(entry);
            
        }
    }











}