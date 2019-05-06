using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRolling
{
    class dice
    {
        List<int> rolls = new List<int>();
        Random rnd = new Random();

        public void RollDice(int min = 1, int max = 7) {
            rolls.Add(rnd.Next(min, max));
            Console.WriteLine("you rolled a " + rolls.Last());
        }

        //should have made these without the console.writeline and just made them return an int with the average/total so i could reuse the code in total by calling it in the average method
        public void PrintAverage(int length) {
            if (length <= rolls.Capacity)
            {

                int sum = 0;
                for (int i = 0; i < length; i++)
                {
                    sum += rolls[i];
                }
                sum /= length;
                Console.WriteLine("the average of your dice rolls was " + sum);
            } else {
                Console.WriteLine("your entered number exceedes the number of rolls the average of all rolls is " + rolls.Average());
            }
        }

        public void PrintTotal(int length) {

            if (length <= rolls.Capacity) {

                int sum = 0;
                for (int i = 0; i < length; i++)
                {
                    sum += rolls[i];
                }
                Console.WriteLine("the total of your dice rolls was " + sum);
            } else {
                Console.WriteLine("your entered number exceedes the number of rolls the total of all rolls is " + rolls.Sum());
            }
        }

        public void PrintRolls(int length) {
            if (length <= rolls.Capacity)
            {

                Console.WriteLine("you rolled");
                for (int i = 0; i < length; i++)
                {
                    Console.WriteLine(rolls[i]);
                }
            } else {
                Console.WriteLine("your entered number exceedes the number of rolls");
            }
        }

        public void ClearRolls() {
            rolls.Clear();
            Console.WriteLine("your rolls have been cleared");
        }

    }
}
