using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Develop03 World!");

        /*
        //New scripture
        Scripture verse1 = new Scripture("Trust in the Lord with all thine heart; and lean not unto thine own understanding.");

        //New scripture
        Scripture verse2 = new Scripture("In all thy ways acknowledge him, and he shall direct thy paths.");

        //Setingg reference
        Reference reference = new Reference("Proverbs 3:5-6");
        reference.AddScripture(verse1);
        reference.AddScripture(verse2);
        */

        //Reading scriptures from a file
        string filename = "scriptures.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);
        List<string> allScriptures = new List<string>();
        //Reading everyline
        foreach (string line in lines)
        {
            string[] parts = line.Split("/");
            string loadedReference = parts[0];
            allScriptures.Add(loadedReference);
        }

        // Choosing randomly a scripture
        Random random = new Random();
        int index = random.Next(allScriptures.Count);
        string selectedReference = allScriptures[index];

        //Creating the reference
        Reference reference = new Reference(selectedReference);
        foreach (string line in lines)
        {
            string[] parts = line.Split("/");
            string loadedReference = parts[0];
            string loadedVerse = parts[1];

            if (loadedReference == selectedReference)
            {
                Scripture verse = new Scripture(loadedVerse);
                reference.AddScripture(verse);
            }
        }

        //Starter variables
        string option;
        int tries = 0;

        //Using a loop iteration to mantain the program always active
        do
        {
            //Clearing console
            Console.Clear();

            //Printing reference
            reference.PrintReference(tries);
            Console.WriteLine("");

            Console.WriteLine("Press 'enter' to continue or type 'quit' to finish ");
            option = Console.ReadLine();

            //Getting hidden state
            if (reference.GetHidenState() == 1) { option = "quit"; }

            tries = tries + 1;
        } while (option.ToLower() != "quit" && option.ToLower() != "q");//Set option to be uppercase to easy finding an end

        //If user select quit option or a activate it by choicing something is not present in the options it will shutdown
        Console.WriteLine("");
        Console.WriteLine("Thank you for using this program. Have a great day.");
        Console.WriteLine("Good bye");
    }
}