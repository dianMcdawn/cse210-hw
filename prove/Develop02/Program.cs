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
            Console.Write("What would you like to do? (Number) ");
            string choice = Console.ReadLine();

            //Some corrections if user write the option instead of the number
            if (choice != "1" && choice != "2" && choice != "3" && choice != "4" && choice != "5")
            {
                if (choice == "Write" || choice == "1. Write") { choice = "1"; }
                else if (choice == "Display" || choice == "2. Display") { choice = "2"; }
                else if (choice == "Load" || choice == "3. Load") { choice = "3"; }
                else if (choice == "Save" || choice == "4. Save") { choice = "4"; }
                else if (choice == "Quit" || choice == "5. Quit") { choice = "5"; }
                else { choice = "5"; }//If nothing is correct the program will shutdown
            }

            //Transforming string choice to int
            option = int.Parse(choice);

            if (option == 1)
            {
                Console.WriteLine("");
                //Using questions and answers with lists
                List<string> questions = new List<string>();
                List<string> answers = new List<string>();

                questions.Add("What was the best part of my day?");
                questions.Add("Could you do what you spected to do?");
                questions.Add("Is there something to change or improve from this day?");
                questions.Add("How do you felt during this day?");
                questions.Add("How would you rate this day?");

                //Promt questions using list and for loop
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(questions[i]);
                    Console.Write("");
                    string answer = Console.ReadLine();
                    answers.Add(answer);
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
                //This display all data saved on journey class
                Console.WriteLine("");
                journal.Display();
            }

            else if (option == 3)
            {
                Console.WriteLine("");
                option = 5;
            }

            else if (option == 4)
            {
                Console.WriteLine("");
                option = 5;
            }


        } while (option != 5);

        //If user select quit option or a activate it by choicing something is not present in the options it will shutdown
        Console.WriteLine("");
        Console.WriteLine("Thank you for using this program. Have a great day.");
        Console.WriteLine("Good bye");
    }
}