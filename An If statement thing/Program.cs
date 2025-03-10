using System;

namespace An_If_statement_thing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the quiz! Tickets are 5$ please insert cash");

            double cash = Convert.ToDouble(Console.ReadLine());

            if ( cash < 5 )
            {
              Console.WriteLine("That isn't enough money");  
            }

            else if ( cash == 5) 
            {
                Console.WriteLine("Here is your ticket");
            }

            else
            {
                Double change = cash-5;
                Console.WriteLine("Here is your ticket and  " + change + "  in change");
            }

           // wait before closing
           Console.ReadKey();
        }
    }
}