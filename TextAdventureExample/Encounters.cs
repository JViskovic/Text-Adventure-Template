using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventureExample
{
    class Encounters
    {

        //Encounters
        public static void FirstEncounter()
        {
            //example action intro
            Console.WriteLine("As you pass by the awkward passageway near the park, you see three strange coins lying on the street");
            Console.WriteLine("...");

            Action(4, 2);

            Console.ReadKey();

        }

        //Encounter Tools
        public static void Action(int param1, int param2)
        {

            Console.WriteLine("==========================");
            Console.WriteLine("| (A) action A | (B) action B |");
            Console.WriteLine("| (C) action C | (D) action D |");
            Console.WriteLine("==========================");

            string input = Console.ReadLine();
            if (input.ToLower() == "a" || input.ToLower() == "do action A")
            {
                Console.WriteLine("action A storyline");

                // impact player variable with parameter
                Program.currentPlayer.mood += param1;

                // display player variable

                Console.WriteLine("player's mood parameter is: " + Program.currentPlayer.mood);
            }
            else if (input.ToLower() == "b" || input.ToLower() == "do action B")
            {
                Console.WriteLine("action B storyline");

            }
            else if (input.ToLower() == "c" || input.ToLower() == "do action C")
            {
                Console.WriteLine("action C storyline");

            }
            else if (input.ToLower() == "d" || input.ToLower() == "do action D")
            {
                Console.WriteLine("action D storyline");

            }
            Console.ReadKey();

            Console.WriteLine("the story continues");

        }
    }
}
