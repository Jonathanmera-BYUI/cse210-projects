using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Videos: ");
        Video video1 = new Video("Introduction to Programming", "Jonathan", 300);

        Comment comments1 = new Comment("Giulia", "Thats amazing!");
        Comment comments2 = new Comment("Alvaro", "Good job!");
        Comment comments3 = new Comment("Clara", "Very Helpful");

        video1.AddComment(comments1);
        video1.AddComment(comments2);
        video1.AddComment(comments3);

        video1.Display();

        Console.WriteLine();
        
        Video video2 = new Video("C# Basics", "Maria", 450);

        Comment comment3 = new Comment("Lucas", "Wow!");
        Comment comment4 = new Comment("Anna", "I learned a lot!");

       video2.AddComment(comment3);
       video2.AddComment(comment4);

video2.Display();

Console.WriteLine();

 Video video3 = new Video("Python", "Clark", 1000);

        Comment comments4 = new Comment("Jhon", "Thats amazing!");
        Comment comments5 = new Comment("Joshua", "So cool");
        Comment comments6 = new Comment("Abbeg", "Super fun to learn");

        video3.AddComment(comments4);
        video3.AddComment(comments5);
        video3.AddComment(comments6);

        video3.Display();

        Console.WriteLine();

 Video video4 = new Video("C# Abstraction", "Rehns", 5000);

        Comment comments7 = new Comment("Hauth", "Great to use!");
        Comment comments8 = new Comment("Kollin", "Perfect");
        Comment comments9 = new Comment("Moore", "I love it");

        video4.AddComment(comments7);
        video4.AddComment(comments8);
        video4.AddComment(comments9);

        video4.Display();
        
    }
        
    
}