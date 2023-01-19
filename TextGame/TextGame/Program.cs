using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void gameOpening()
            {
                Console.WriteLine("Welcome to the text-based adventure game!");
                Console.WriteLine("A game by: Jesse Gerritsen\n");

                Console.WriteLine("press any key to get started!");
                Console.ReadKey();
                Console.Clear();
            }

            gameOpening();

            void gameExplain()
            {
                Console.WriteLine("You find yourself in a maze full of rooms. Each room contains a door on each side (unless you're at the border), follow the correct doors for your escape.");
                Console.WriteLine("But beware! You're not the only thing to lurk in the maze.\n");
                Console.WriteLine("If at any moment you need help with commands, simply type 'help' and a list of commands will pop up. Goodluck on your journey travelers!\n");
                Console.WriteLine("Press any key to start the game");
                Console.WriteLine();

                Console.ReadKey();
                Console.Clear();
            }

            gameExplain();

            void MapPosition()
            {
                foreach (int position in Map.Location)
                {
                    Console.WriteLine(position);
                }
            }


            void theGame()
            {
                Console.WriteLine("Where would you like to go?");
                Console.WriteLine(@"
                     N
                     ⌃
                 W <   > E
                     v
                     S
                ");
                string direction = Console.ReadLine().ToLower();

                switch (direction)
                {
                    case "north":
                        Console.Clear();
                        Console.WriteLine("You went North");
                        if (Map.Location[0] <= 5)
                        {
                            Map.Location[0] += 1;

                        }
                        if (Map.Location[0] >= 5)
                        {
                            Console.WriteLine("There is a wall in front of you, try a different direction.");
                        }
                        MapPosition();
                        theGame();
                        break;
                    case "east":
                        Console.Clear();
                        Console.WriteLine("You went East");
                        if (Map.Location[1] <= 5)
                        {
                            Map.Location[1] += 1;
                        }
                        if (Map.Location[1] >= 5)
                        {
                            Console.WriteLine("There is a wall in front of you, try a different direction.");
                        }
                        MapPosition();
                        theGame();
                        break;
                    case "south":
                        Console.Clear();
                        Console.WriteLine("You went South");
                        if (Map.Location[0] <= 5 && Map.Location[0] > 1)
                        {
                            Map.Location[0] -= 1;
                        }
                        if (Map.Location[0] == 1)
                        {
                            Console.WriteLine("There is a wall in front of you, try a different direction.");
                        }
                        MapPosition();
                        theGame();
                        break;
                    case "west":
                        Console.Clear();
                        Console.WriteLine("You went West");
                        if (Map.Location[1] <= 5 && Map.Location[0] > 1)
                        {
                            Map.Location[1] -= 1;
                        }
                        if (Map.Location[1] == 1)
                        {
                            Console.WriteLine("There is a wall in front of you, try a different direction.");
                        }
                        MapPosition();
                        theGame();
                        break;
                    case "help":
                        Console.WriteLine("List of commands: North ↑, South ↓, East →, West ←");
                        Console.ReadKey();
                        Console.Clear();
                        theGame();
                        break;
                    default:
                        Console.WriteLine("Incorrect input, try again!");
                        Console.ReadKey();
                        Console.Clear();
                        theGame();
                        break;
                }

                Console.ReadKey();
            }

            theGame();
        }
    }
}
