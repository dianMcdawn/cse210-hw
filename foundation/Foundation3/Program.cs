using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation3 World!");
        Console.WriteLine("");

        //New main Activity list
        List<Activity> activities = new List<Activity>();

        //Getting current datetime
        DateTime todaytime = DateTime.Now;

        //Adding data to the list

        //Running (title, datetime, duration in minutes, miles)
        Running run = new Running("First running", todaytime, 30, 5);

        //Bicycle (title, datetime, duration in minutes, speed)
        Bicycles bic = new Bicycles("First cycle", todaytime, 60, 15);

        //Swimming (title, datetime, duration in minutes, laps)
        Swimming swi = new Swimming("First cycle", todaytime, 60, 50);

        //Addint to the same list
        activities.Add(run);
        activities.Add(bic);
        activities.Add(swi);

        //Loop for each activity and retreive its summary
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }

    }
}