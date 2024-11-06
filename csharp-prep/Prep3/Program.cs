using System;

class Program
{
    static void Main(string[] args)
    {
        string response;
        do
        {
            //Getting variable data
            //Console.Write("What is the magic number? ");
            //string numberS = Console.ReadLine();
            //float number = float.Parse(numberS);
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 11);
            float guess = 0;
            int count = 0;

            do
            {
                Console.Write("What is your guess? ");
                string guessS = Console.ReadLine();
                guess = float.Parse(guessS);
                string resp = "";

                if (number == guess) { resp = "You guessed it!"; }
                else if (number < guess) { resp = "Lower"; }
                else if (number > guess) { resp = "Higher"; }

                //Tracking how many tries have been made
                count = count + 1;
                Console.WriteLine($"{resp}");
            } while (number != guess);

            Console.WriteLine($"You try {count} times to find the magic number!");
            Console.WriteLine("");

            Console.Write("Do you want to try again? (yes(y) / no (n))");
            response = Console.ReadLine();
        } while (response == "yes" || response == "y");
        Console.WriteLine("");
        //Console.WriteLine("Hello Prep3 World!");

    }
}