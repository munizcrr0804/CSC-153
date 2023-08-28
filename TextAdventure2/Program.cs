/**
* 2/28/2021
* CSC 153
* Ramon Muniz
* text Adventure2
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure
{
    class TextAdventureloop
    {
        static void Main(string[] args)
        {
            gameTitle();
            first();

        }
        /* this section will demonstrate the game 6/11*/
        public static void gameTitle()
        {
            Console.WriteLine("This in the beginning of the second iteration the text adventure.");
            Console.WriteLine("Press 'Enter' to begin.");
            Console.ReadLine();
            Console.Clear();
            first();

        }
        /* this section will demonstrate switches 6/11*/
        public static void first()
        {
            string choice;

            Console.WriteLine("You're at the Main Menu");
            Console.WriteLine("What do you do?");
            Console.WriteLine("1. Move North");
            Console.WriteLine("2. Move South");
            Console.WriteLine("3. Attack");
            Console.WriteLine("4. Exit");
            Console.Write("Choice: ");
            choice = Console.ReadLine().ToLower();
            Console.Clear();

            switch (choice)
            {
                case "1":
                case "Display Move North":
                case "Display":
                    {
                        Console.WriteLine("Display the new room to the user in numeric value.");
                        Console.ReadLine();
                        gameOver();
                        break;
                    }
                case "2":
                case "Display Move South":
                    {
                        Console.WriteLine("Display the new room to the user in numeric value however in reverse.");
                        Console.ReadLine();
                        break;
                    }
                case "3":
                case "Attack":
                case "display Attack":
                    {
                        Console.WriteLine("Display random number from 1 to 20 than take awaya simulated Hit point count and then returned to display to the user..");
                        Console.ReadLine();
                        break;
                    }
                case "4":
                case "Exit":
                    {

                        Console.WriteLine("Command to exit.");
                        Console.WriteLine("Press 'Enter' to exit.");
                        Console.ReadLine();
                        first();
                        break;
                    }
            }
        }
        

        public static void gameOver()
        {
            Console.Clear();
            Console.WriteLine("The End?");
            Console.ReadLine();
            Console.Clear();
            gameTitle();
        }

        public static void youWin()
        {
            Console.Clear();
            Console.WriteLine("You are saved.");
            Console.ReadLine();
            Console.Clear();
            gameTitle();
        }


    }
}
