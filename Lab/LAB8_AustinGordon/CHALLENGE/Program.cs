/* AUTHOR: Austin Gordon
 * DATE: 3-29-18
 * PURPOSE: LAB8 CHALLENGE
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CHALLENGE
{
    class Program
    {
        static void Main(string[] args)
        {
            int numRolls = 1000;

            Dice_Roll_Experiment(numRolls);

            ReadKey();
        }

        static void Dice_Roll_Experiment(int rollCount)
        {

            Random objRandom = new Random();

            int[] resultCount = new int[6] { 0, 0, 0, 0, 0, 0 };
            double[] resultPercentage = new double[6];

            for (int i = 1; i <= rollCount; i++)
            {

                int randNumber = objRandom.Next(0, 6);

                resultCount[randNumber]++;

            }

            Console.WriteLine("Number of rolls: " + rollCount);

            for(int i = 0; i <= 5; i++)
            {
                resultPercentage[i] = (double)resultCount[i] / rollCount * 100;

                Console.WriteLine("Side " + (i + 1) + ": " + resultCount[i] + " rolls (" + resultPercentage[i] + "%)");
            }

        }
    }
}
