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

            //Breathing
            Breathing breathing = new Breathing("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");

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

            //Some variables
            string title = "";
            string message = "";

            if (option > 0 && option < 4)
            {
                //Clearing screen
                Console.Clear();

                //Finding title and message
                if (option == 1) { title = breathing.GetTitle(); message = breathing.GetMessage(); }
                else if (option == 2) { title = reflection.GetTitle(); message = reflection.GetMessage(); }
                else if (option == 3) { title = listing.GetTitle(); message = listing.GetMessage(); }

                //Showing title and message according the activity
                Console.WriteLine("Welcome to the " + title + " Activity");
                Console.WriteLine("");
                Console.WriteLine(message);
                Console.Write("How long in seconds (aprox.), would you want to work in this activity: ");
                string duration = Console.ReadLine();
                int seconds = int.Parse(duration);

                //Inititating some variables
                int index = 0;
                int i = 0;
                int j = 0;

                //Clearing screen
                Console.Clear();

                //Waiting room
                Console.WriteLine("Get ready..");
                Console.Write("+");
                for (j = 0; j < 8; j++)
                {
                    Thread.Sleep(500);
                    Console.Write("\b \b");
                    Console.Write("x");
                    Thread.Sleep(500);
                    Console.Write("\b \b");
                    Console.Write("+");
                }
                Console.Write("\b \b");

                //FIRST ACTIVITY
                if (option == 1)
                {
                    DateTime startTime = DateTime.Now;
                    DateTime futureTime = startTime.AddSeconds(seconds);
                    DateTime currentTime = DateTime.Now;
                    int breathCount = 0;
                    do
                    {
                        Console.Write("\b \b");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.Write("Breathe in...4");
                        i = 4;
                        do
                        {
                            Thread.Sleep(1000);
                            i--;
                            Console.Write("\b \b");
                            Console.Write(i);
                        } while (i > 0);
                        Console.WriteLine("");
                        Console.Write("Breathe out...6");
                        j = 6;
                        do
                        {
                            Thread.Sleep(1000);
                            j--;
                            Console.Write("\b \b");
                            Console.Write(j);
                        } while (j > 0);
                        Console.WriteLine("");
                        currentTime = DateTime.Now;
                        breathCount++;
                    } while (currentTime < futureTime);
                    //Counting how many times in and out where made
                    breathing.SetBreathCount(breathCount);
                }//Option 1

                //SECOND ACTIVITY
                else if (option == 2)
                {
                    //Choosing randomly a prompt from all possible prompts
                    Random randomPrompt = new Random();
                    index = randomPrompt.Next(reflection.GetPromtList().Count);
                    string prompt = reflection.GetPromtList()[index];
                    Console.WriteLine("Consider the following prompt:");
                    Console.WriteLine("");
                    Console.WriteLine("---" + prompt + "---");
                    Console.WriteLine("");
                    Console.Write("When you have something in mind, press enter to continue.");
                    Console.ReadLine();

                    Console.WriteLine("Now ponder on each of the following questions as the related to this experience.");
                    Console.WriteLine("");
                    Console.Write("You may begin in: 5");
                    i = 5;
                    do
                    {
                        Thread.Sleep(1000);
                        i--;
                        Console.Write("\b \b");
                        Console.Write(i);
                    } while (i > 0);

                    //Clearing screen
                    Console.Clear();

                    DateTime startTime = DateTime.Now;
                    DateTime futureTime = startTime.AddSeconds(seconds);
                    DateTime currentTime = DateTime.Now;
                    do
                    {
                        Console.Write("\b \b");
                        int state = 1;
                        string quest = "";

                        //Choosing randomly a prompt from all possible questions, bypassing all of those whose state is 1
                        do
                        {
                            Random randomQuestion = new Random();
                            index = randomQuestion.Next(reflection.GetQuestionList().Count);
                            Questions question = reflection.GetQuestionList()[index];
                            quest = question.GetQuestion();
                            state = question.GetState();
                            if (state == 0) { question.SetState(1); }//Change the questions state to not being repeated
                        } while (state == 1);

                        //Printing question
                        Console.WriteLine("");
                        Console.Write(quest + " ");
                        Console.Write("|");

                        for (j = 0; j < 4; j++)
                        {
                            Thread.Sleep(500);
                            Console.Write("\b \b");
                            Console.Write("/");
                            Thread.Sleep(500);
                            Console.Write("\b \b");
                            Console.Write("-");
                            Thread.Sleep(500);
                            Console.Write("\b \b");
                            Console.Write("\\");
                            Thread.Sleep(500);
                            Console.Write("\b \b");
                            Console.Write("|");
                        }
                        Console.Write("\b \b");

                        currentTime = DateTime.Now;
                        Console.WriteLine("");
                    } while (currentTime < futureTime);
                }//Option 2

                //THIRD ACTIVITY
                else if (option == 3)
                {
                    //Choosing randomly a prompt from all possible prompts
                    Random randomPrompt = new Random();
                    index = randomPrompt.Next(listing.GetPromtList().Count);
                    string prompt = listing.GetPromtList()[index];
                    Console.WriteLine("List as many responses you can to the following prompt:");
                    Console.WriteLine(prompt);
                    Console.WriteLine("");
                    Console.Write("You may begin in: 5");
                    i = 5;
                    do
                    {
                        Thread.Sleep(1000);
                        i--;
                        Console.Write("\b \b");
                        Console.Write(i);
                    } while (i > 0);

                    //Clearing screen
                    Console.Clear();

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

                    //Showing how many responses are at the end
                    Console.WriteLine($"You listed {listing.GetNumberOfItems()} items");
                }//Option 3

                //**************************************************

                Console.WriteLine("");
                Console.WriteLine("Well done!!");
                Console.Write("+");
                for (j = 0; j < 8; j++)
                {
                    Thread.Sleep(500);
                    Console.Write("\b \b");
                    Console.Write("x");
                    Thread.Sleep(500);
                    Console.Write("\b \b");
                    Console.Write("+");
                }
                Console.Write("\b \b");
                Console.WriteLine($"You have completed another {seconds} seconds of the {title} Activity.");
                Console.Write("+");
                for (j = 0; j < 8; j++)
                {
                    Thread.Sleep(500);
                    Console.Write("\b \b");
                    Console.Write("x");
                    Thread.Sleep(500);
                    Console.Write("\b \b");
                    Console.Write("+");
                }

            }
        } while (option != 4);
    }
}