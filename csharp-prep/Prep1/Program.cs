using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your first name?");
        string firstName = Console.ReadLine();
        Console.WriteLine($"Input Accepted your first name is {firstName}");
        Console.WriteLine("What is  your last name?");
        string lastName = Console.ReadLine();
        Console.WriteLine($"Input Accepted your last name is {lastName}");
        Console.WriteLine("Printing Iconic Line");
        Console.WriteLine($"My Name is {firstName}.... {firstName}{lastName} ");


    }
}