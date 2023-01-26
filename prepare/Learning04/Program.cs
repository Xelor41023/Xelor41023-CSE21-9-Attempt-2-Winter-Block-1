using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");

        
        
            Assignment MyAssignment = new Assignment("Cory", "Math101x");
            {
                System.Console.WriteLine(MyAssignment.getSummary());

            }

            MathAssignment myMathAssignment = new MathAssignment("Section 4-1", "Problems 1-3");
            {
                System.Console.WriteLine(MyAssignment.getSummary());
                System.Console.WriteLine(myMathAssignment.getHomeworkList());
            }

            WritingAssignment myWritingAssignment  = new WritingAssignment("Cory", "Programming", "How To Inorrectly Format Python Code");
            {
                Console.WriteLine(myWritingAssignment.getSummary());
                Console.WriteLine(myWritingAssignment.getWritingInformation());

            }
    }
}