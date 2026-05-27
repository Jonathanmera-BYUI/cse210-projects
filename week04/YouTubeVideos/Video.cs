using System;
using System.Collections.Generic;
using System.Net;
using System.Reflection.Metadata.Ecma335;

public class Video
{
string  _title; 
string  _author; 
int _length;
List<Comment> _comments;

public Video(string title, string author, int length)
    {

        _title = title; 
        _author = author; 
        _length = length; 

        _comments = new List<Comment>();

    }

    public void Display()
    {
        Console.WriteLine("title: " + _title);
        Console.WriteLine("author: " + _author);
        Console.WriteLine("length: " + _length);
        Console.WriteLine("comment: " + _comments.Count);

        foreach (Comment comment in _comments)
{
    comment.Display();
}
    }


public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

public int GetCommentCount()
{
    return _comments.Count;
}



}

