using System;

class Program
{
    static void Main(string[] args)
    {
        //Getting variable data
        Console.Write("Please, enter your grade percentage: ");
        string grade = Console.ReadLine();
        float gradePerc = float.Parse(grade);
        string letter;
        string passed;

        if (gradePerc >= 90) { letter = "A"; }
        else if (gradePerc >= 80) { letter = "B"; }
        else if (gradePerc >= 70) { letter = "C"; }
        else if (gradePerc >= 60) { letter = "D"; }
        else if (gradePerc < 60) { letter = "F"; }
        else { letter = "No grade"; }

        Console.Write("");
        Console.Write($"Your grade is: {letter}");

        if (letter == "A" || letter == "B" || letter == "C") { passed = "Approved"; }
        else { passed = "Fail"; }

        Console.Write("");
        Console.Write($"You have {passed} this course.");

        Console.WriteLine("Hello Prep2 World!");
    }
}