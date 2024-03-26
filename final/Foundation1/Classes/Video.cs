using System;
using System.Collections.Generic;

public class Video 
{
    private string _title;
    private string _author;
    private double _length;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, double length)
    {
        _title = title;
        _author = author;
        _length = length;
    }
    public void ListComment(Comment comment) //passes in a Comment object and stores that comment in the _comments collection
    {
        _comments.Add(comment);
    }
    public int CountComments()
    {
        int count = 0;
        count = _comments.Count;
        return count;
    }
    public void DisplayInfo()
    {
        Console.WriteLine("--------------------------------------------------------------");
        Console.WriteLine($"Title: {_title} | Creator: {_author} | Duration: {_length} seconds");
        Console.WriteLine();
        int commentCount = CountComments();
        Console.WriteLine($"Number of comments: {commentCount}"); 
        foreach (Comment comment in _comments) //if there is a comment show it
        {
            comment.DisplayInfo();
        }    
        Console.WriteLine("--------------------------------------------------------------");
    }
}
