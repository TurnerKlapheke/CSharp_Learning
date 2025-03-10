using System;

namespace Loops_thing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many times would you like to see 2 to the power of x? ");
            int count = Convert.ToInt32(Console.ReadLine());
            
            //for statement
            for (int i = 1; i <=count; i++)             
            {
                double result = Math.Pow(2, i);
                Console.WriteLine(result);
            }

            Console.WriteLine("Now that you've seen some intriguing numbers, lets roll the dice");


            // dice roll

            Random numberGen = new Random();

            int roll = 0;
            int roll2 = 1;
            int attempts = 0;

            while (roll != roll2)
            {
                Console.ReadKey();
                roll = numberGen.Next(1, 7);
                Console.WriteLine("Dice 1 : " + roll);
                roll2 = numberGen.Next(1, 7);
                Console.WriteLine("Dice 2 : " + roll2);
                attempts++;
            }

            Console.WriteLine("It took you " + attempts + " attempts to roll doubles");

            // end program
            Console.ReadKey();
        }
    }
}
