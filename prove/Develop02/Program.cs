using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Develop02 World!");

        //Starter variables
        int option;
        Journal journal = new Journal();
        journal._name = "My journal";

        //Using a loop iteration to mantain the program always active
        do
        {
            //Making the choise selection
            Console.WriteLine("Please select one of the flowwing choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? (Number)");
            string choice = Console.ReadLine();

            //Some corrections if user write the entiry option instead of the number
            if (choice == "Write" || choice == "1. Write") { choice = "1"; }
            else if (choice == "Display" || choice == "2. Display") { choice = "2"; }
            else if (choice == "Load" || choice == "3. Load") { choice = "3"; }
            else if (choice == "Save" || choice == "4. Save") { choice = "4"; }
            else if (choice == "Quit" || choice == "5. Quit") { choice = "5"; }
            else { choice = "5"; }//If nothing is correct the program will shutdown
            //Transforming string choice to int
            option = int.Parse(choice);

            if (option == 1)
            {
                //Using questions and answers with lists
                List<string> questions = new List<string>();
                List<string> answers = new List<string>();

                questions[0] = "What was the best part of my day?";
                questions[1] = "Could you do what you spected to do?";
                questions[2] = "Is there something to change or improve from this day?";
                questions[3] = "How do you felt during this day?";
                questions[4] = "How would you rate this day?";

                //Promt questions using list and for loop
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(questions[i]);
                    Console.Write("");
                    answers[i] = Console.ReadLine();
                }

                //Date
                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();

                //Using for loop to add entries classes to journal class
                for (int i = 0; i < 5; i++)
                {
                    Entry entry = new Entry();
                    entry._date = dateText;
                    entry._question = questions[i];
                    entry._entry = answers[i];
                    journal._entries.Add(entry);
                }
            }
            else if (option == 2)
            {
                journal.Display();
            }

            else if (option == 3)
            {
                option = 5;
            }

            else if (option == 4)
            {
                option = 5;
            }


        } while (option == 5);

        //If user select quit option or a activate it by choicing something is not present in the options it will shutdown
        Console.WriteLine("");
        Console.WriteLine("Thank you for using this program. Have a great day.");
        Console.WriteLine("Good bye");
    }
}