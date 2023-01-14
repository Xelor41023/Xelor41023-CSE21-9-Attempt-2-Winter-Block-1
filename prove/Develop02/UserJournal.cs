using.System;
using System.IO;
using System.Text;


public class UserJournal
{
    public void writeToCSV()
    {
       StringBuilder builder = new StringBuilder();

       string text1 = "Text1";
       string text2 = "Text2";
       builder.AppendLine(string.Format("{0}|{1}", text1, text2));
    }

    public void ReadFromCSV()
    {
        StreamReader streamReader = new StreamReader(filePath);

        while (!streamReader.EndOfStream)
        {var line = streamReader.ReadLine();
        var values =  line.Split('|');

        Console.WriteLine("{0}}(1}", values[0], values[1]);
    }









}