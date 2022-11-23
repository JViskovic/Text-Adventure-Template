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

            Action();

            Console.ReadKey();

        }

        //Encounter Tools
        public static void Action()
        {

            Console.WriteLine("==========================");
            Console.WriteLine("| (A) action A | (B) action B |");
            Console.WriteLine("==========================");

            string input = Console.ReadLine();
            if (input.ToLower() == "a" )
            {
                Console.WriteLine("action A storyline");
            }

            else if (input.ToLower() == "b" )
            {
                Console.WriteLine("action B storyline");
            }

            Console.ReadKey();

            Console.WriteLine("the story continues or ends");

        }
    }
}
