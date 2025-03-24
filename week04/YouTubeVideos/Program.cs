using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        List<Video> videos = new List<Video>();
        Video video1 = new Video("How to make Sulfur Hexaflouride!", "Science show", 900);
        Video video2 = new Video("Look at this scary game!", "Gamer Nation", 1200);
        Video video3 = new Video("Funniest memes of the year", "Funnystuffhere", 760);
        Video video4 = new Video("I bit charlie's finger", "randomuser232", 30);
        video1.addComments();
        video2.addComments();
        video3.addComments();
        video4.addComments();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);
        foreach (Video v in videos)
        {
            v.DisplayContent();
            Console.WriteLine();
        }
    }
}