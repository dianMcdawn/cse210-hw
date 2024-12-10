using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Develop06 World!");
        //Clearing screen
        Console.Clear();

        //Starting Main Class
        Console.WriteLine("Please enter your name: ");
        string name = Console.ReadLine();
        MainMenu manager = new MainMenu(name);

        manager.Start();
    }
}