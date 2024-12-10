using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Develop06 World!");
        //Clearing screen
        Console.Clear();

        //Showing Creativity and Exceeding Requirements
        /*
        This programm take track of all events of every type by using a new class call GoalEvent.
        On it, a datetime is saved to show when a mark has been added.
        */

        //Starting Main Class
        Console.WriteLine("Please enter your name: ");
        string name = Console.ReadLine();
        MainMenu manager = new MainMenu(name);

        manager.Start();
    }
}