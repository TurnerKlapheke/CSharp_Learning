﻿using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double num01;
            double num02;
            double num03;
            Console.Write("Input a number to average with two others: ");

            num01 = Convert.ToDouble( Console.ReadLine() );

            Console.Write("Input a second number: ");

            num02 = Convert.ToDouble( Console.ReadLine() );

            Console.Write("Input a third number: ");

            num03 = Convert.ToDouble( Console.ReadLine() );
            
            double average = num01 + num02 + num03;
            double result = average / 3;

            Console.WriteLine("The result of your average is " + result);
            Console.ReadKey(); 
        }
    }
}
