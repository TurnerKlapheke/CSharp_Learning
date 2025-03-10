using System;
using System.Collections.Generic;

namespace arrays_learning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> ShoppingList = new List<string>();

            ShoppingList.Add("Dreams");
            ShoppingList.Add("Miracles");
            ShoppingList.Add("Rainbows");
            ShoppingList.Add("Pony");

            for (int i = 0; i < ShoppingList.Count; i++)
            {
                Console.WriteLine(ShoppingList[i]);
            }

            ShoppingList.RemoveAt(1);

            Console.WriteLine("\n");

            for (int i = 0; i < ShoppingList.Count; i++)
            {
                Console.WriteLine(ShoppingList[i]);
            }

            // wait before closing
            Console.ReadKey();
        }
    }
}
