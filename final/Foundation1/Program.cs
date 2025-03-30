using System;
using System.Collections.Concurrent;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        GatherVideos();
    }

    private static void GatherVideos()
    {
        List<Video> videos = new List<Video>()
        {
            new Video("Psych", "Shaun Spencer", 120, new List<Comment>
            {
                new Comment("Frankie", "Shaun and Gus are the best duo on any tv show ever!"),
                new Comment("Janice", "Love all the nicknames.")
            }),
            new Video("C# Fundamentals", "Chris West", 900, new List<Comment>
            {
                new Comment("Jack", "He is able to explain very well"),
                new Comment("Paul", "Best Intro Video on C#"),
                new Comment("Jessica", "Chris is the best!")
            }),
            new Video("Print your own RC Plane", "PrintVerse", 200, new List<Comment>
            {
                new Comment("Axyl", "I wanna print this tomorrow, let yall know how it goes."),
                new Comment("Brick", "Printed, great instructions, flies well."),
                new Comment("Sue", "I need to get myself a 3D printer just for this project.")
            })
        };
    
        foreach(Video video in videos)
        {
            Console.WriteLine($"\nTitle: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._length}");
            Console.WriteLine("Comments: ");
        
            foreach(Comment comments in video._comments)
            {
            Console.WriteLine($"   Name: {comments._name}");
            Console.WriteLine($"   Comment: {comments._comment}");
            }
        }
    }
};
