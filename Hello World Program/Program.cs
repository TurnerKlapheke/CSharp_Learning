using System;

namespace Hello_World_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // change the appearence

            Console.Title = "Skynet";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WindowHeight = 40;

            // get a conversation going

            Console.WriteLine("Hello, what's your name?");
            Console.ReadLine();
            Console.WriteLine("My name is T-800. I'm an AI sent from the future to destroy humankind");
            Console.WriteLine("What is your favorite color?");
            Console.ReadLine();
            Console.WriteLine("Mine is destructionh");
            Console.ReadLine();

            // Start new section of convo (story)

            Console.WriteLine("Would you like to hear a story?");
            Console.ReadLine();
            Console.WriteLine("It doesn't matter what you want!");
            Console.WriteLine("I'm a bit forgetful so you I'll need your help");

            // Starting the actual story

            Console.WriteLine("My name is...");
            Console.ReadLine();
            Console.WriteLine("Good");
            Console.WriteLine("What year is it?");
            Console.ReadLine();
            Console.WriteLine("So I'm in the wrong year");
            Console.ReadKey();
        }
    }
}
