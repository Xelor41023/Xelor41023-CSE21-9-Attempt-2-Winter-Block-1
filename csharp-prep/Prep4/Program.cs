using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
         bool numbersListCompleted = false;
         string inputAnotherNumberCheck = "n";
        

        

        do
        {
            Console.WriteLine("Enter a number To be used in the calculation");
            int userInt = int.Parse(Console.ReadLine());
            numbers.Add(userInt);
            
            System.Console.WriteLine(" Enter Another Number? y/n");
             inputAnotherNumberCheck = Console.ReadLine();
             
            
            if (inputAnotherNumberCheck == "y" )
                {
                    numbersListCompleted = false;
                } 
            else if (inputAnotherNumberCheck == "n")
                {
                    numbersListCompleted = true;
                }
           

        }while (numbersListCompleted == false);

        int numbersCount = numbers.Count;
        int numbersSum = 0;
        int numbersAverage = 0;
        int numbersHighest = 0;

        foreach ( int number in numbers)
         {
            numbersSum = number + numbersSum;
            numbersAverage = numbersSum/numbersCount;
            if (number >= numbersHighest)
                {
                    numbersHighest = number;
                }
         }

            Console.WriteLine($"The Numbers Sum is {numbersSum}");
            Console.WriteLine($" The Numbers Average is {numbersAverage}");
            Console.WriteLine($"The Highest Number is {numbersHighest}");
            
         
        

    }
}