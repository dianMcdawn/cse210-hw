using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");
        Console.WriteLine("");

        //Generating an assignment
        //Assignment assign = new Assignment("Samuel Bennett", "Multiplication");
        //MathAssignment mathAssign = new MathAssignment("Roberto Rodriguez", "Fractions", "Section 7.3", "Problems 8-19");
        WritingAssignment writingAssign = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");

        //Displaying
        //Console.WriteLine(mathAssign.GetSummary());
        //Console.WriteLine(mathAssign.GetHomeworkList());
        Console.WriteLine(writingAssign.GetWritingInformation());
    }
}