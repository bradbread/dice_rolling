using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRolling
{
    class Program
    {
        static void Main(string[] args)
        {
            bool play = true;
            string option;
            int min, max, numR;
            dice d = new dice();
            

            Console.WriteLine("Welcome to the Caves & Lizards Club dice rolling program");
            Console.WriteLine("Press r to roll the dice");
            Console.WriteLine("Press x to roll a custom dice multiple times");
            Console.WriteLine("Press d to roll a custom dice");
            Console.WriteLine("Press a to get the average of your rolls");
            Console.WriteLine("Press t to get the total of your rolls");
            Console.WriteLine("Press h to get your rolls");
            Console.WriteLine("Press c to clear your rolls");
            Console.WriteLine("Press q to quit");
            while (play) {
                Console.WriteLine("Please select an option");
                option = Console.ReadLine();
                switch (option) {
                    case "r":
                        d.RollDice();
                        break;
                    case "d":
                        Console.WriteLine("please enter the min then the max number of the dice");
                        min = Convert.ToInt32(Console.ReadLine());
                        max = Convert.ToInt32(Console.ReadLine()) + 1;
                        d.RollDice(min, max);
                        break;
                    case "x":
                        Console.WriteLine("please enter the number of rolls you wish to perform");
                        numR = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("please enter the min then the max number of the dice");
                        min = Convert.ToInt32(Console.ReadLine());
                        max = Convert.ToInt32(Console.ReadLine()) + 1;
                        for (int i = 0; i < numR; i++) {
                            d.RollDice(min, max);
                        }
                        break;
                    case "a":
                        Console.WriteLine("please enter the number of rolls you wish to average");
                        max = Convert.ToInt32(Console.ReadLine());
                        d.PrintAverage(max);
                        break;
                    case "t":
                        Console.WriteLine("please enter the number of rolls you wish to add to the total");
                        max = Convert.ToInt32(Console.ReadLine());
                        d.PrintTotal(max);
                        break;
                    case "h":
                        Console.WriteLine("please enter the number of rolls you wish to display");
                        max = Convert.ToInt32(Console.ReadLine());
                        d.PrintRolls(max);
                        break;
                    case "c":
                        d.ClearRolls();
                        break;
                    case "q":
                        play = false;
                        break;
                    default:
                        Console.WriteLine("invalid input");
                        break;
                }
            }

            Console.WriteLine("exiting program press any key to continue");
            Console.ReadKey();
        }
    }
}
