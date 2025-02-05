using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        Video video1 = new Video("Voltron", "Joaquim Dos Santos", 900);
        Video video2 = new Video("How to make Cakes", "Favour Chide", 100);
        Video video3 = new Video("how to build a box", "Michel stones", 900 );

        video1.AddComment(new Comment("James", "Great introduction!"));
        video1.AddComment(new Comment("Cluff", "Very helpful, thanks!"));
        video1.AddComment(new Comment("Jasper", "Clear and concise."));

        video2.AddComment(new Comment("Mike", "Very helpful, thanks!"));
        video2.AddComment(new Comment("Emmanuel", "Well explained."));
        video2.AddComment(new Comment("Eva", "Learned a lot!"));

        video3.AddComment(new Comment("Ben", "Design patterns are crucial."));
        video3.AddComment(new Comment("Bianca", "Excellent examples."));
        video3.AddComment(new Comment("chi chi", "Very informative."));

        List<Video> videos = new List<Video> { video1, video2, video3 };

        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

            foreach (var comment in video.GetComments())
            {
                 Console.WriteLine($"- {comment._CommenterName}: {comment.Text}");  
            }  
            Console.WriteLine(new string('-', 40));  
        }  
    }  
}  