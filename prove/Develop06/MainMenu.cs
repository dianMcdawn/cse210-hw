public class MainMenu
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;
    private string _playerName;

    //********************************************
    //                CONSTRUCTORS
    //********************************************
    public MainMenu(string name)
    {
        _playerName = name;
        _score = 0;
    }
    //***************************************
    //                SETTERS
    //***************************************
    private void SetPlayerName(string name)
    {
        _playerName = name;
    }
    private void SetScore()
    {
        int score = 0;
        foreach (Goal goal in _goals)
        {
            score = score + goal.GetScore();
        }
        _score = score;
    }
    //***************************************
    //                METHODS
    //***************************************
    public void Start()
    {
        //Some global variables
        int choise = 8;

        //Main Menu
        do
        {
            //Clearing screen
            Console.Clear();

            //Refreshing Score
            SetScore();

            //Making the choise selection
            Console.WriteLine($"Player: {_playerName}");
            Console.WriteLine("");
            Console.WriteLine("Please select one of the following options: ");
            Console.WriteLine("1. Display Player Info");
            Console.WriteLine("2. List your goals");
            Console.WriteLine("3. Show descriptions of your goals");
            Console.WriteLine("4. Create new goal");
            Console.WriteLine("5. Record a event");
            Console.WriteLine("6. Save goals");
            Console.WriteLine("7. Load goals");
            Console.WriteLine("8. Quit");
            Console.Write("What would you like to do? (Number) ");
            string opt = Console.ReadLine();
            if (opt != "1" && opt != "2" && opt != "3" && opt != "4" && opt != "5" && opt != "6" && opt != "7")
            { choise = 8; }
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
                RecordEvent();
            }
            else if (choise == 6)
            {
                SaveGoals();
            }
            else if (choise == 7)
            {
                LoadGoals();
            }

        } while (choise != 8);
    }
    public void CountDown(int start)
    {
        Console.Write($"Returning in: {start}");
        do
        {
            Thread.Sleep(1000);
            start--;
            Console.Write("\b \b");
            Console.Write(start);
        } while (start > 0);
    }
    private void DisplayPlayerInfo()
    {
        //Clearing screen
        Console.Clear();

        //Refreshing total Score
        SetScore();

        //Writing data
        Console.WriteLine($"Player name: {_playerName}");
        Console.WriteLine($"Total Goals: {_goals.Count()}");
        Console.WriteLine($"Total Score: {_score} points");
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
                GoalSimple goal = new GoalSimple(1, name, desc, puntos, diff, false, today, today);
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
                GoalCheck goal = new GoalCheck(2, name, desc, puntosAll, diff, goalToAchieve, puntos, false, today, today);
                _goals.Add(goal);
            }
            else if (choise == 3)
            {
                Console.Write("Name: "); string name = Console.ReadLine();
                Console.Write("Description: "); string desc = Console.ReadLine();
                Console.Write("Points: "); string points = Console.ReadLine(); int puntos = int.Parse(points);
                Console.Write("Difficulty (Hard, Medium, Easy): "); string diff = Console.ReadLine();
                Console.Write("Period (Daily, Weekly, Monthly): "); string period = Console.ReadLine();
                GoalEternal goal = new GoalEternal(3, name, desc, puntos, diff, period, false, today, today);
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
                //Index to identify the goal to edit
                int index = choise - 1;

                //If goal is not completed yet, let save a new event
                string message = "";
                if (_goals[index].IsComplete() == false)
                {
                    _goals[index].RecordEvent();

                    if (_goals[index].GetGoalType() == 1)
                    {
                        message = message + $"Your goal has been Completed!!! Congratulation, you won {_goals[index].GetPoints()} points";
                    }
                    else if (_goals[index].GetGoalType() == 2)
                    {
                        message = message + $"Your goal task has been recorded!!! Congratulation, you won {_goals[index].GetLessPoints()} points";
                        //Let call IsComplete again, maybe the new added event completed the goal
                        if (_goals[index].IsComplete() == true)
                        {
                            message = message + $"Your goal has been Completed!!! Congratulation, you won {_goals[index].GetPoints()} extra points";
                        }
                    }
                    else if (_goals[index].GetGoalType() == 3)
                    {
                        message = message + $"Your goal task has been recorded!!! Congratulation, you won {_goals[index].GetPoints()} points";
                    }
                }
                else
                {
                    message = "This event can't be recorded, you already completed this goal!.";
                }

                //Clearing screen
                Console.Clear();
                Console.WriteLine(message);

                Console.ReadLine();
            }
        } while (choise != last);
    }
    private void SaveGoals()
    {
        //Clearing screen
        Console.Clear();

        string fileName = "goals.txt";

        using (StreamWriter outputFile = new StreamWriter(fileName)) //, append: true
        {
            foreach (Goal goal in _goals)
            {
                //Retreiving each line to be saved
                string stringLine = goal.GetStringSave(_playerName);
                //Checking if there are more than one line in the same string
                string[] parts = stringLine.Split("&&");
                if (parts.Count() > 0)
                {
                    foreach (string line in parts)
                    {
                        //If a line is empty, it will not be saved
                        if (line != "" && line != null)
                        {
                            outputFile.WriteLine(line);
                        }
                    }
                }
                else
                {
                    outputFile.WriteLine(stringLine);
                }
            }
        }
        Console.WriteLine("Data has been saved.");
        CountDown(3);
    }
    private void LoadGoals()
    {
        //Clearing screen
        Console.Clear();

        string fileName = "goals.txt";
        string currentLine = "";
        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            //Player Name ; Goal Name ; Goal Description ; Date Start ; Date Update/Completed ; Points ; Points individual (Check) ; Difficulty ; Period ; Goal to be achieved ; Event Date
            string[] parts = line.Split(";");
            string playerName = parts[0];
            string goalTp = parts[1];
            int goalType = int.Parse(goalTp);
            string goalName = parts[2];
            string goalDesc = parts[3];
            string dateSrt = parts[4];
            DateOnly dateStart = DateOnly.Parse(dateSrt);
            string dateUpdt = parts[5];
            DateOnly dateUpdate = DateOnly.Parse(dateUpdt);
            string pointsAll = parts[6];
            int puntosAll = int.Parse(pointsAll);
            string pointsOne = parts[7];
            int puntos = int.Parse(pointsOne);
            string diff = parts[8];
            string period = parts[9];
            string goalAchieve = parts[10];
            int goalToAchieve = int.Parse(goalAchieve);
            string eventDt = parts[11];
            DateOnly eventDate = DateOnly.Parse(eventDt);

            //Creating main
            if (playerName == _playerName)
            {
                //If it is a Eternal Goal
                if (goalType == 3)
                {
                    //Let check if the line is about the same Goal, but a different event
                    if (currentLine != goalName + goalDesc + puntosAll + diff + period + dateStart + dateUpdate)
                    {
                        //Player Name ; Goal Name ; Goal Description ; Date Start ; Date Update/Completed ; Points ; X ; Difficulty ; Period ; X ; Event Date       
                        GoalEternal goal = new GoalEternal(3, goalName, goalDesc, puntosAll, diff, period, false, dateStart, dateUpdate);
                        currentLine = goalName + goalDesc + puntosAll + diff + period + dateStart + dateUpdate;

                        //Saving it
                        _goals.Add(goal);

                        //If this line have an event date, let create it
                        if (eventDt != null)
                        {
                            GoalEvent evento = new GoalEvent(eventDate);
                            goal.SetNewGoalEvent(evento);
                        }
                    }
                    else
                    {
                        //If this line have an event date, let create it
                        if (eventDt != null)
                        {
                            //Take the last index, as the last one of the list is the last one we saved before
                            int index = _goals.Count() - 1;
                            GoalEvent evento = new GoalEvent(eventDate);
                            _goals[index].SetNewGoalEvent(evento);
                        }
                    }
                }
                //If it is a Check Goal
                else if (goalType == 2)
                {
                    //Let check if the line is about the same Goal, but a different event
                    if (currentLine != goalName + goalDesc + puntosAll + diff + goalToAchieve + puntos + dateStart + dateUpdate)
                    {
                        //Player Name ; Goal Name ; Goal Description ; Date Start ; Date Update/Completed ; Points ; Points individual (Check) ; Difficulty ; X ; Goal to be achieved ; Event Date       
                        GoalCheck goal = new GoalCheck(2, goalName, goalDesc, puntosAll, diff, goalToAchieve, puntos, false, dateStart, dateUpdate);
                        currentLine = goalName + goalDesc + puntosAll + diff + goalToAchieve + puntos + dateStart + dateUpdate;

                        //Saving it
                        _goals.Add(goal);

                        //If this line have an event date, let create it
                        if (eventDt != null)
                        {
                            GoalEvent evento = new GoalEvent(eventDate);
                            goal.SetNewGoalEvent(evento);
                        }
                    }
                    else
                    {
                        //If this line have an event date, let create it
                        if (eventDt != null)
                        {
                            //Take the last index, as the last one of the list is the last one we saved before
                            int index = _goals.Count() - 1;
                            GoalEvent evento = new GoalEvent(eventDate);
                            _goals[index].SetNewGoalEvent(evento);
                        }
                    }
                }
                //If it is a Simple Goal
                else if (goalType == 1)
                {//Let check if the line is about the same Goal, but a different event
                    if (currentLine != goalName + goalDesc + puntosAll + diff + dateStart + dateUpdate)
                    {
                        //Player Name ; Goal Name ; Goal Description ; Date Start ; Date Update/Completed ; Points ; X ; Difficulty ; X ; X ; Event Date       
                        GoalSimple goal = new GoalSimple(1, goalName, goalDesc, puntosAll, diff, false, dateStart, dateUpdate);
                        currentLine = goalName + goalDesc + puntosAll + diff + dateStart + dateUpdate;

                        //Saving it
                        _goals.Add(goal);

                        //If this line have an event date, let create it
                        if (eventDt != null)
                        {
                            GoalEvent evento = new GoalEvent(eventDate);
                            goal.SetNewGoalEvent(evento);
                        }
                    }
                }
            }
        }
        Console.WriteLine("Data has been loaded.");
        CountDown(3);
    }
}