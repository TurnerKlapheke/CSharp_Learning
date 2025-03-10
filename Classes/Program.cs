using System;

namespace Loops_thing
{
    class wizard
    {
        public string name;
        public string favoritespell;
        private int spellslots;
        private float experience;

        public static int Count;

        public wizard(string _name, string _favoritespell)
        {
            name = _name;
            favoritespell = _favoritespell;
            spellslots = 2;
            experience = 0f;

            Count++;
        }

        public void CastSpell()
        {
            if (spellslots > 0)
            {
                 Console.WriteLine(name + " casts " + favoritespell);
            spellslots--;
            experience+= 0.3f;
            } else
            {
                Console.WriteLine(name + " is out of spell slots");
            }
           
        }
        public void meditate()
        {
            spellslots++;
            Console.WriteLine(name + " Meditated for 1 hour and now has " + spellslots + " spellslots");
        }
    }
    class Program
    { 
        static void Main(string[] args)
        {
               wizard wizard01 = new wizard("Dein Mutares Shvul", "English Translation");

               wizard01.CastSpell();

               wizard wizard02 = new wizard("A regular guy", "Regular stuff");
             
               wizard02.CastSpell();

               Console.WriteLine(wizard.Count);

            // end program
            Console.ReadKey();
            Console.ReadKey();
        }
     
    }

}