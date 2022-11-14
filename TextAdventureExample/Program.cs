using System;

namespace TextAdventureExample
{
    class Program
    {
        public static Player currentPlayer = new Player();
        static void Main(string[] args)
        {
            Start();
            Encounters.FirstEncounter();
        }

        static void Start()
        {
            Console.WriteLine("This is a Text Adventure Game Template! welcome to.. game name");
            Console.WriteLine("Your Name: ");

            currentPlayer.name = Console.ReadLine();

            Console.WriteLine("Introduction to the plot");
            Console.WriteLine("continue the plot");


            if (currentPlayer.name == "")
            {
                Console.WriteLine("I didn't catch your name!");
                currentPlayer.name = Console.ReadLine();
                Console.WriteLine("Your Name: " + currentPlayer.name);
            }
            else
            { 
                Console.WriteLine("Hi " + currentPlayer.name + "!");


            }

            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Next phase of story begins");
        }
    }
}
