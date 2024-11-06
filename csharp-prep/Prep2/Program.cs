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
        string symbol;
        string passed;

        if (gradePerc >= 90) { letter = "A"; }
        else if (gradePerc >= 80) { letter = "B"; }
        else if (gradePerc >= 70) { letter = "C"; }
        else if (gradePerc >= 60) { letter = "D"; }
        else if (gradePerc < 60) { letter = "F"; }
        else { letter = "No grade"; }

        if (gradePerc < 90 && gradePerc >= 87 || gradePerc < 80 && gradePerc >= 87 || gradePerc < 70 && gradePerc >= 77 || gradePerc < 60 && gradePerc >= 67) { symbol = "+"; }
        else if (gradePerc < 93 && gradePerc > 90 || gradePerc < 83 && gradePerc > 80 || gradePerc < 73 && gradePerc > 70 || gradePerc < 63 && gradePerc > 60) { symbol = "-"; }
        else { symbol = ""; }

        Console.WriteLine("");
        Console.WriteLine($"Your grade is: {letter}{symbol}");

        if (letter == "A" || letter == "B" || letter == "C") { passed = "Approved"; }
        else { passed = "Fail"; }

        Console.WriteLine("");
        Console.WriteLine($"You have {passed} this course.");

        //Console.WriteLine("Hello Prep2 World!");
    }
}