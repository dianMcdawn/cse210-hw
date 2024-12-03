using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Develop05 World!");

        //Starter variables
        int option = 0;

        do
        {
            //Clearing screen
            Console.Clear();

            //Making the choise selection
            Console.WriteLine("Please select one of the following activities: ");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("What would you like to do? (Number) ");
            string choice = Console.ReadLine();

            //Some corrections if user write the option instead of the number
            if (choice != "1" && choice != "2" && choice != "3" && choice != "4" && choice != "5" && choice != "6")
            {
                if (choice.ToLower() == "breathing activity" || choice.ToLower() == "breathing" || choice.ToLower() == "1. breathing activity") { choice = "1"; }
                else if (choice.ToLower() == "reflection activity" || choice.ToLower() == "reflection" || choice.ToLower() == "2. reflection activity") { choice = "2"; }
                else if (choice.ToLower() == "listing activity" || choice.ToLower() == "listing" || choice.ToLower() == "3. listing activity") { choice = "3"; }
                else if (choice.ToLower() == "quit" || choice.ToLower() == "4. quit") { choice = "4"; }
                else { choice = "4"; }//If nothing is correct the program will shutdown
            }

            //Transforming string choice to int
            option = int.Parse(choice);

            //Setting Classes Data

            //Reflection
            Reflection reflection = new Reflection("Reflection", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", "Think of a time when you stood up for someone else.", "Why was this experience meaningful to you?");
            reflection.SetPrompt("Think of a time when you did something really difficult.");
            reflection.SetPrompt("Think of a time when you helped someone in need.");
            reflection.SetPrompt("Think of a time when you did something truly selfless.");
            reflection.SetQuestion("Have you ever done anything like this before?");
            reflection.SetQuestion("How did you get started?");
            reflection.SetQuestion("How did you feel when it was complete?");
            reflection.SetQuestion("What made this time different than other times when you were not as successful?");
            reflection.SetQuestion("What is your favorite thing about this experience?");
            reflection.SetQuestion("What could you learn from this experience that applies to other situations?");
            reflection.SetQuestion("What did you learn about yourself through this experience?");
            reflection.SetQuestion("How can you keep this experience in mind in the future?");

            //Listing
            Listing listing = new Listing("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", "Who are people that you appreciate?");
            listing.SetPrompt("What are personal strengths of yours?");
            listing.SetPrompt("Who are people that you have helped this week?");
            listing.SetPrompt("When have you felt the Holy Ghost this month?");
            listing.SetPrompt("Who are some of your personal heroes?");

            //Using the option choosed to find what to do
            if (option == 1)
            {
                Console.WriteLine("");
                Console.WriteLine("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                Console.WriteLine("Please, input how long in seconds (aprox.) you want to work in this activity: ");
                string duration = Console.ReadLine();
                int seconds = int.Parse(duration);

                int timer = 0;
                do
                {
                    Console.WriteLine("Breathe in...");
                    Thread.Sleep(4000);
                    Console.WriteLine("Breathe out...");
                    Thread.Sleep(4000);
                    timer += 8;
                } while (timer < seconds);
            }
            else if (option == 2)
            {
                Console.WriteLine("");
                Console.WriteLine(reflection.GetMessage());
                Console.WriteLine("Please, input how long in seconds (aprox.) you want to work in this activity: ");
                string duration = Console.ReadLine();
                int seconds = int.Parse(duration);

                //Index random
                int index = 0;

                //Choosing randomly a prompt from all possible prompts
                Random randomPrompt = new Random();
                index = randomPrompt.Next(reflection.GetPromtList().Count);
                string prompt = reflection.GetPromtList()[index];
                Console.WriteLine(prompt);
                Console.WriteLine("");

                int timer = 0;
                do
                {
                    Console.Write("\b \b");

                    //Choosing randomly a prompt from all possible questions
                    Random randomQuestion = new Random();
                    index = randomQuestion.Next(reflection.GetQuestionList().Count);
                    string question = reflection.GetQuestionList()[index];
                    Console.WriteLine(question);

                    Console.Write("+");
                    for (int j = 0; j < 8; j++)
                    {
                        Thread.Sleep(500);
                        Console.Write("\b \b"); // Erase the + character
                        Console.Write("x"); // Replace it with the - character
                        Thread.Sleep(500);
                        Console.Write("\b \b"); // Erase the + character
                        Console.Write("+"); // Replace it with the - character
                    }

                    timer += 8;
                } while (timer < seconds);


            }
            else if (option == 3)
            {
                Console.WriteLine("");
                Console.WriteLine(listing.GetMessage());
                Console.WriteLine("Please, input how long in seconds (aprox.) you want to work in this activity: ");
                string duration = Console.ReadLine();
                int seconds = int.Parse(duration);

                //Index random
                int index = 0;

                //Choosing randomly a prompt from all possible prompts
                Random randomPrompt = new Random();
                index = randomPrompt.Next(listing.GetPromtList().Count);
                string prompt = listing.GetPromtList()[index];
                Console.WriteLine(prompt);
                Console.WriteLine("");

                int timer = 15;
                Console.Write(timer);
                do
                {
                    Thread.Sleep(1000);
                    timer--;
                    Console.Write("\b \b");
                    Console.Write("\b\b \b");
                    Console.Write(timer);
                } while (timer != 0);

                //Now is time for user to input data
                Console.WriteLine("Now list your responses!!!");
                DateTime startTime = DateTime.Now;
                DateTime futureTime = startTime.AddSeconds(seconds);
                DateTime currentTime = DateTime.Now;
                do
                {
                    string respon = Console.ReadLine();
                    listing.SetResponse(respon);
                    currentTime = DateTime.Now;
                } while (currentTime < futureTime);

            }
        } while (option != 4);
    }
}