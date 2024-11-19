using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Develop03 World!");

        //New scripture
        Scripture verse1 = new Scripture();
        verse1.setScripture("Trust in the Lord with all thine heart; and lean not unto thine own understanding.");

        //New scripture
        Scripture verse2 = new Scripture();
        verse2.setScripture("In all thy ways acknowledge him, and he shall direct thy paths.");

        //Setingg reference
        Reference reference = new Reference();
        reference.setReference("Proverbs 3:5-6");
        reference.addScripture(verse1);
        reference.addScripture(verse2);

        //Starter variables
        string option;
        int tries = 0;

        //Using a loop iteration to mantain the program always active
        do
        {
            //Clearing console
            Console.Clear();

            //Printing reference
            reference.printReference();
            reference.printScriptures(tries);
            Console.WriteLine("");

            Console.WriteLine("Press 'enter' to continue or type 'quit' to finish ");
            option = Console.ReadLine();

            tries = tries + 1;
        } while (option.ToLower() != "quit" && option.ToLower() != "q");//Set option to be uppercase to easy finding an end

        //If user select quit option or a activate it by choicing something is not present in the options it will shutdown
        Console.WriteLine("");
        Console.WriteLine("Thank you for using this program. Have a great day.");
        Console.WriteLine("Good bye");
    }
}