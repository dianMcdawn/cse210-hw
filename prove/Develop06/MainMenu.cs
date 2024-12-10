public class MainMenu
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;
    private string _playerName;

    //Constructor
    public MainMenu(string name)
    {
        _playerName = name;
        _score = 0;
    }
    //Setters
    private void SetPlayerName(string name)
    {
        _playerName = name;
    }

    //Methods
    public void Start()
    {
        //Some global variables
        int choise = 9;

        //Main Menu
        do
        {
            //Clearing screen
            Console.Clear();

            //Making the choise selection
            Console.WriteLine($"Player: {_playerName}");
            Console.WriteLine("");
            Console.WriteLine("Please select one of the following options: ");
            Console.WriteLine("1. Display Player Info");
            Console.WriteLine("2. List your goals");
            Console.WriteLine("3. Show descriptions of your goals");
            Console.WriteLine("4. Create new goal");
            Console.WriteLine("5. Edit a goal");
            Console.WriteLine("6. Record a event");
            Console.WriteLine("7. Save goals");
            Console.WriteLine("8. Load goals");
            Console.WriteLine("9. Quit");
            Console.Write("What would you like to do? (Number) ");
            string opt = Console.ReadLine();
            if (opt != "1" && opt != "2" && opt != "3" && opt != "4" && opt != "5" && opt != "6" && opt != "7" && opt != "8")
            { choise = 9; }
            else { choise = int.Parse(opt); }

            //Working every option
            if (choise == 1)
            {
                DisplayPlayerInfo();
            }
            else if (choise == 2)
            {
                ListGoalNames();
            }
            else if (choise == 3)
            {
                ListGoalDetails();
            }
            else if (choise == 4)
            {
                CreateGoal();
            }
            else if (choise == 5)
            {
                choise = 9;
            }
            else if (choise == 6)
            {
                RecordEvent();
            }
            else if (choise == 7)
            {
                SaveGoals();
            }
            else if (choise == 8)
            {
                LoadGoals();
            }

        } while (choise != 9);
    }
    private void DisplayPlayerInfo()
    {
        //Clearing screen
        Console.Clear();
        Console.WriteLine(_playerName);
        Console.ReadLine();
    }
    private void ListGoalNames()
    {
        //Clearing screen
        Console.Clear();
        if (_goals.Count() > 0)
        {
            foreach (Goal goal in _goals)
            {
                Console.WriteLine(goal.GetRepresentation());
            }
        }
        else
        {
            Console.WriteLine("There are no records to show.");
        }
        Console.ReadLine();
    }
    private void ListGoalDetails()
    {
        //Clearing screen
        Console.Clear();
        if (_goals.Count() > 0)
        {
            foreach (Goal goal in _goals)
            {
                Console.WriteLine(goal.GetDetails());
            }
        }
        else
        {
            Console.WriteLine("There are no records to show.");
        }
        Console.ReadLine();
    }
    private void CreateGoal()
    {
        //Some global variables
        int choise = 4;
        DateOnly today = DateOnly.FromDateTime(DateTime.Now);

        //Main Menu
        do
        {
            //Clearing screen
            Console.Clear();

            //Making the choise selection
            Console.WriteLine("Wich kind of goal you want to create?: ");
            Console.WriteLine("1. Simple one time goal");
            Console.WriteLine("2. Check goal");
            Console.WriteLine("3. Continuous goal");
            Console.WriteLine("4. Return");
            Console.Write("What would you like to do? (Number) ");
            string opt = Console.ReadLine();
            if (opt != "1" && opt != "2" && opt != "3")
            { choise = 4; }
            else { choise = int.Parse(opt); }

            //Common Screen
            if (choise != 4)
            {
                //Clearing screen
                Console.Clear();
                //Enter information
                Console.WriteLine("Please enter the following information: ");

            }

            //Working every option
            if (choise == 1)
            {
                Console.Write("Name: "); string name = Console.ReadLine();
                Console.Write("Description: "); string desc = Console.ReadLine();
                Console.Write("Points: "); string points = Console.ReadLine(); int puntos = int.Parse(points);
                Console.Write("Difficulty (Hard, Medium, Easy): "); string diff = Console.ReadLine();
                //OneGoal goal = new OneGoal("Finish College", "Finish every class of this year.", 5000, "Hard", false, today);
                GoalSimple goal = new GoalSimple(name, desc, puntos, diff, false, today);
                _goals.Add(goal);
            }
            else if (choise == 2)
            {
                Console.Write("Name: "); string name = Console.ReadLine();
                Console.Write("Description: "); string desc = Console.ReadLine();
                Console.Write("Points for achieved one: "); string points = Console.ReadLine(); int puntos = int.Parse(points);
                Console.Write("Points for achieved all: "); string pointsAll = Console.ReadLine(); int puntosAll = int.Parse(points);
                Console.Write("Difficulty (Hard, Medium, Easy): "); string diff = Console.ReadLine();
                Console.Write("How many to achieve (number): "); string goalTo = Console.ReadLine(); int goalToAchieve = int.Parse(goalTo);
                GoalCheck goal = new GoalCheck(name, desc, puntosAll, diff, goalToAchieve, puntos, false, today);
                _goals.Add(goal);
            }
            else if (choise == 3)
            {
                Console.Write("Name: "); string name = Console.ReadLine();
                Console.Write("Description: "); string desc = Console.ReadLine();
                Console.Write("Points: "); string points = Console.ReadLine(); int puntos = int.Parse(points);
                Console.Write("Difficulty (Hard, Medium, Easy): "); string diff = Console.ReadLine();
                Console.Write("Period (Daily, Weekly, Monthly): "); string period = Console.ReadLine();
                GoalEternal goal = new GoalEternal(name, desc, puntos, diff, period, false, today);
                _goals.Add(goal);
            }
        } while (choise != 4);
    }
    private void RecordEvent()
    {
        //Some global variables
        int choise;
        int last = _goals.Count() + 1;

        //Main Menu
        do
        {
            //Clearing screen
            Console.Clear();

            //Making the choise selection
            Console.WriteLine("Choose one of your goals to add an event to it: ");
            int count = 1;
            foreach (Goal goal in _goals)
            {
                Console.WriteLine($"{count}. {goal.GetRepresentation()}");
                count++;
            }
            Console.WriteLine($"{last}. Return");
            Console.WriteLine("What would you choose? (Number) ");
            string opt = Console.ReadLine();
            choise = int.Parse(opt);
            if (choise < 1 || choise > last)
            { choise = last; }
            else { choise = int.Parse(opt); }

            //If the option is nor to return previous screen
            if (choise != last)
            {
                _goals[choise].RecordEvent();
                //Clearing screen
                Console.Clear();
                Console.WriteLine("Event recorded.");
                Console.ReadLine();
            }
        } while (choise != last);
    }
    private void SaveGoals()
    {
        string fileName = "goals.txt";
        foreach (Goal goal in _goals)
        {
            goal.SaveToText(fileName, _playerName);
        }
        Console.WriteLine("Data has been saved.");
        Console.ReadLine();
    }
    private void LoadGoals() { }

}