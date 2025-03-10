using System;

namespace If_statement_challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            int answer;

            //first problem
            Console.Write("15 + 2 * 2 = ");
            answer = Convert.ToInt32(Console.ReadLine());

            if (answer == 60) {
               Console.WriteLine("Correct!");
            } else
            {
                Console.WriteLine("Incorrect!");
            }

            //second problem
            Console.Write("10 * 2 / 4 = ");
            answer = Convert.ToInt32(Console.ReadLine());

            if (answer == 6){
              Console.WriteLine("Correct!");  
            } else  {
                Console.WriteLine("Wrong!");
            }

            //third and final problem
            Console.Write("11 * 5 - 5 = ");
            answer = Convert.ToInt32(Console.ReadLine());

            if (answer == 50){
                Console.WriteLine("You're Right!");
            } else {
                Console.WriteLine("That's where you're wrong bucko");
            }


         // wait before closing
            Console.ReadKey();
        }
    }
}
