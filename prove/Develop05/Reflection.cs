public class Reflection : Activity
{
    private List<string> _prompt = new List<string>();
    private List<Questions> _question = new List<Questions>();

    //Constructors
    public Reflection(string title, string message, int duration, string promt, string question) : base(title, message, duration)
    {
        SetPrompt(promt);
        SetQuestion(question);
    }
    public Reflection(string title, string message, int duration, string promt) : base(title, message, duration)
    {
        SetPrompt(promt);
    }
    //Setters
    public void SetPrompt(string promt)
    {
        _prompt.Add(promt);
    }
    public void SetQuestion(string question)
    {
        Questions quest = new Questions(question, 0);
        _question.Add(quest);
    }
    //Getters
    public List<string> GetPromtList()
    {
        return _prompt;
    }
    private List<Questions> GetQuestionList()
    {
        return _question;
    }
    //Methods
    public void InititateReflectionActivity()
    {
        //Choosing randomly a prompt from all possible prompts
        Random randomPrompt = new Random();
        int index = randomPrompt.Next(GetPromtList().Count);
        string prompt = GetPromtList()[index];
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine("");
        Console.WriteLine("---" + prompt + "---");
        Console.WriteLine("");
        Console.Write("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as the related to this experience.");
        Console.WriteLine("");

        //Countdown at 5 seconds
        base.CountDown(5);

        //Clearing screen
        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(base.GetDuration());
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
                index = randomQuestion.Next(GetQuestionList().Count);
                Questions question = GetQuestionList()[index];
                quest = question.GetQuestion();
                state = question.GetState();
                if (state == 0) { question.SetState(1); }//Change the questions state to not being repeated
            } while (state == 1);

            //Printing question
            Console.WriteLine("");
            Console.Write(quest + " ");

            base.ShowSecondWheel();

            currentTime = DateTime.Now;
            Console.WriteLine("");

        } while (currentTime < futureTime);
    }
}