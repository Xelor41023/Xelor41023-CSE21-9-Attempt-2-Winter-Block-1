using System;

class Program
{
    static void Main(string[] args)
    {
        WelcomeMessage();
        string fullName = GetUserName();
        int userNumber = GetUserNumber();
        int squaredUserNumber = SquareUserNumber(userNumber);
        DisplayResult(fullName, squaredUserNumber);
    }
    static void WelcomeMessage()
    {
        Console.WriteLine("Welcome to The Program");
    }

    static string GetUserName()
    {
        string firstName = "";
        string lastName = "";
        string fullName = "";

        Console.WriteLine("What is your First Name?");
        firstName = Console.ReadLine();
        Console.WriteLine($"input accepted your first name is {firstName}");
        Console.WriteLine("What is your last name?");
        lastName = Console.ReadLine();
        Console.WriteLine($"input accepted your last name is {lastName}");
        fullName = firstName + "" + lastName;
        return fullName;

    }

    static int GetUserNumber()
    {
        int userNumber = 0;
        System.Console.WriteLine("What is your favorite Number?");
        userNumber = int.Parse(Console.ReadLine());
        Console.WriteLine($"input accepted your favorite number is {userNumber}");
        return userNumber;
    }

    static int SquareUserNumber( int userNumber)
    {
        int squaredUserNumber = userNumber * userNumber;
        return squaredUserNumber;
    }

    static void DisplayResult(string fullName, int squaredUserNumber)
    {
        Console.WriteLine($"{fullName} the square of your number is  {squaredUserNumber}");
    }

}
    