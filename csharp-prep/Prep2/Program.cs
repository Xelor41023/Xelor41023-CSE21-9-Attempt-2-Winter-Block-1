using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What Grade did the user recive?");
        string studentGrade = Console.ReadLine();
        Console.WriteLine($" Input accepted user recived a grade of {studentGrade}");
        int numStudentGrade = int.Parse(studentGrade);
        string studentGradeLetter = "";

        if (numStudentGrade >= 90)
            {
                studentGradeLetter = "A";
            }
        else if (numStudentGrade >= 80)
            {
                studentGradeLetter = "B";
            }
        else if (numStudentGrade >= 70)
            {
                studentGradeLetter = "C";
            }
        else if (numStudentGrade >= 60)
            {
                studentGradeLetter = "D";
            }
        else if  (numStudentGrade < 60)
            {
                studentGradeLetter = "F";
            }
        
        Console.WriteLine($"Student Recived a Grade of {numStudentGrade} and recived a letter of {studentGradeLetter}");

        if (numStudentGrade >70)
            {
                Console.WriteLine(" Student has pass the job good job!");
            }
        else
            {
                Console.WriteLine("Try again I belive in you!");
            }

    }
}