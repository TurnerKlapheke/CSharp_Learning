using System;

namespace Loops_thing
{
    class Program
    { 
        static void Main(string[] args)
        {
                Console.WriteLine("Write a Sentence.");
                String sentence = Console.ReadLine();

                int wordcount = CountWords(sentence);

                Console.WriteLine("The sentence you wrote had " + wordcount + " words in it");

            // end program
            Console.ReadKey();
            Console.ReadKey();
        }
        static int CountWords (string sentence) 
        {
          int wordcount = sentence.Split(' ').Length;
          return wordcount;
        }
     
    }
}