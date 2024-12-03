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
            Breathing breathing = new Breathing("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", 0);

            //Reflection
            Reflection reflection = new Reflection("Reflection", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", 0, "Think of a time when you stood up for someone else.", "Why was this experience meaningful to you?");
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
            Listing listing = new Listing("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 0, "Who are people that you appreciate?");
            listing.SetPrompt("What are personal strengths of yours?");
            listing.SetPrompt("Who are people that you have helped this week?");
            listing.SetPrompt("When have you felt the Holy Ghost this month?");
            listing.SetPrompt("Who are some of your personal heroes?");

            if (option > 0 && option < 4)
            {
                //FIRST ACTIVITY
                if (option == 1)
                {
                    breathing.InitiatingActivity();
                    breathing.InitiateBreathActivity();
                    breathing.EndingActivity();
                }//Option 1

                //SECOND ACTIVITY
                else if (option == 2)
                {
                    reflection.InitiatingActivity();
                    reflection.InititateReflectionActivity();
                    reflection.EndingActivity();
                }//Option 2

                //THIRD ACTIVITY
                else if (option == 3)
                {
                    listing.InitiatingActivity();
                    listing.InititateListingActivity();
                    listing.EndingActivity();
                }//Option 3

            }
        } while (option != 4);
    }
}