using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create videos
        var video1 = new Video("Video 1", "Alex Rivers", 300);
        var video2 = new Video("Video 2", "Jordan Blake", 450);
        var video3 = new Video("Video 3", "Taylor Morgan", 600);

        // Add comments 
        video1.AddComment(new Comment("KayCee Jay", "Great video!"));
        video1.AddComment(new Comment("Luna", "Very informative, thanks!"));
        video1.AddComment(new Comment("CoCo Bean", "Loved the video it was great."));

        video2.AddComment(new Comment("Mazzie", "This video is awesome."));
        video2.AddComment(new Comment("Riley Malco", "Thanks!"));
        video2.AddComment(new Comment("Major", "Can you do a follow-up?"));

        video3.AddComment(new Comment("James Jones", "Amazing content!"));
        video3.AddComment(new Comment("Lucy Maze", "Great!"));
        video3.AddComment(new Comment("Jessie", "Keep up the great work!"));

        // list of videos
        var videos = new List<Video> { video1, video2, video3 };


        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Creator: {video.Creator}");
            Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfcomments()}");
            Console.WriteLine("Comments:");

            foreach (var comment in video.Comments)
            {
                Console.WriteLine($"- {comment.CommenterName}: {comment.CommentText}");
            }

            Console.WriteLine();
        }
    }
}