using System;
using System.Formats.Asn1;
using System.IO;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Develop02 World!");

        //Starter variables
        int option;
        Journal journal = new Journal();
        journal._name = "My journal"; //Default name

        //Using a loop iteration to mantain the program always active
        do
        {
            //Making the choise selection
            Console.WriteLine("Please select one of the folowing choices: ");
            Console.WriteLine("1. Journal Name");
            Console.WriteLine("2. Write");
            Console.WriteLine("3. Display");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Save");
            Console.WriteLine("6. Quit");
            Console.Write("What would you like to do? (Number) ");
            string choice = Console.ReadLine();

            //Some corrections if user write the option instead of the number
            if (choice != "1" && choice != "2" && choice != "3" && choice != "4" && choice != "5" && choice != "6")
            {
                if (choice == "Journal" || choice == "Journal Name" || choice == "1. Journal Name") { choice = "1"; }
                else if (choice == "Write" || choice == "2. Write") { choice = "2"; }
                else if (choice == "Display" || choice == "3. Display") { choice = "3"; }
                else if (choice == "Load" || choice == "4. Load") { choice = "4"; }
                else if (choice == "Save" || choice == "5. Save") { choice = "5"; }
                else if (choice == "Quit" || choice == "6. Quit") { choice = "6"; }
                else { choice = "6"; }//If nothing is correct the program will shutdown
            }

            //Transforming string choice to int
            option = int.Parse(choice);

            //Selecting a proper journal name
            if (option == 1)
            {
                Console.WriteLine("");
                Console.WriteLine("Please, enter your journal name: ");
                Console.Write("");
                string jname = Console.ReadLine();
                journal._name = jname;
                Console.WriteLine("");
                Console.WriteLine("Remember this name will be used to load and save data.");
            }

            //Writing a new entry
            else if (option == 2)
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

            //Displaying everything saved
            else if (option == 3)
            {
                //This display all data saved on journey class
                Console.WriteLine("");
                journal.Display();
            }

            //Reading TEXT file and saving it to the classes
            else if (option == 4)
            {
                Console.WriteLine("");
                Console.WriteLine("What is the TEXT or CSV filename?");
                Console.Write("");
                string filename = Console.ReadLine();
                //Separate filename from file extention
                string[] extention = filename.Split(".");
                string[] lines = System.IO.File.ReadAllLines(filename);

                if (extention[1] == "txt" || extention[1] == "csv")
                {
                    //Reading everyline
                    foreach (string line in lines)
                    {
                        string[] parts = line.Split(";");

                        string journalname = parts[0];
                        string entrydate = parts[1];
                        string entryquestion = parts[2];
                        string entryanswer = parts[3];

                        //If journal name of the TEXT line match the journal name of the current session, it will be loaded
                        if (journal._name == journalname)
                        {
                            Entry entry = new Entry();
                            entry._date = entrydate;
                            entry._question = entryquestion;
                            entry._entry = entryanswer;
                            journal._entries.Add(entry);
                        }
                    }
                    Console.WriteLine("Data loaded.");
                    Console.Write("");
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("The File extention must be TXT or CSV. Please try again.");
                    Console.WriteLine("");
                }
            }

            //Saving data on a TEXT file
            else if (option == 5)
            {
                Console.WriteLine("");
                Console.WriteLine("What is the TEXT or CSV filename?");
                Console.Write("");
                string filename = Console.ReadLine();
                string[] extention = filename.Split(".");
                //string fileName = "journal.txt";

                if (extention[1] == "txt" || extention[1] == "csv")
                {
                    //Console.WriteLine(File.Exists(curFile) ? "File exists." : "File does not exist.");
                    bool fileexist = File.Exists(filename);
                    if (fileexist == true)
                    {
                        journal.Save(filename);
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("The File does not exist. Please try again.");
                        Console.WriteLine("");
                    }
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("The File extention must be TXT or CSV. Please try again.");
                    Console.WriteLine("");
                }
            }


        } while (option != 6);

        //If user select quit option or a activate it by choicing something is not present in the options it will shutdown
        Console.WriteLine("");
        Console.WriteLine("Thank you for using this program. Have a great day.");
        Console.WriteLine("Good bye");
    }
}