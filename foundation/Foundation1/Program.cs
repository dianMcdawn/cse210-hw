using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Foundation1 World!");
        //Clearing console
        Console.Clear();

        //Writing some text to style the screen
        Console.WriteLine("Youtube video comment checker system");
        Console.WriteLine("");

        //Adding new videos and their comments
        Video video1 = new Video("Testing Task 1","Patricio",120);
        Video video2 = new Video("Testing Task 2","John",245);
        Video video3 = new Video("Testing Excersie","Thomas",60);
        Video video4 = new Video("Testing Test","Mark",180);

        //Adding comments to each video
        video1.SetNewComment("Harry","Thanks for this, i was searching for this information.");
        video1.SetNewComment("Timothy","I can't understand, could you add some mor information? please?");
        video1.SetNewComment("Leland","For me this is clear, thank you.");
        video1.SetNewComment("Jamie","When will task 2 come?");

        video2.SetNewComment("Clarie","This is a good way to prepare ourself for the test.");
        video2.SetNewComment("Terry","Thanks, this video helpe me understand our class.");
        video2.SetNewComment("Lucy","Impresive!");
        video2.SetNewComment("Audrey","Is there a short way to solve this?");

        video3.SetNewComment("Scout","Why we need to use that calculation?");
        video3.SetNewComment("Gresham","This was hard, but i could achive it!");
        video3.SetNewComment("Ted","I'm taking soo long to end this, any advise?");
        video3.SetNewComment("Cheryl","Can we contact you for any need?");

        video4.SetNewComment("Jenson","Hope this is not the end");
        video4.SetNewComment("Una","This wasn't so bad, i though it could be harder");
        video4.SetNewComment("Toby","Thanks a lot this test was more easy than the excersice");
        video4.SetNewComment("Angela","Thank you for all the preparation for this exam!");

        //Displaying all videos
        video1.Display();
        Console.WriteLine("");
        video2.Display();
        Console.WriteLine("");
        video3.Display();
        Console.WriteLine("");
        video4.Display();
    }
}