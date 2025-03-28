using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Video
{
    public string Title { get; set; }
    public string Creator { get; set; }
    public int LengthInSeconds { get; set; }
    public List<Comment> Comments { get; set; }

    public Video(string title, string creator, int lengthInSeconds)
    {
        Title = title;
        Creator = creator;
        LengthInSeconds = lengthInSeconds;
        Comments = new List<Comment>();
    }
    public int GetNumberOfcomments()
    {
        return Comments.Count;
    }

    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }
}
