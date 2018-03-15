/* AUTHOR: Austin Gordon
 * DATE: 3-14-18
 * PURPOSE: HW5 - Takes number input 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SentinelLoop
{
    class SentinelLoopApp
    {
        static void Main(string[] args)
        {

            int count = 0, minimum = 999999, sum = 0, num;
            double average;
            string kbEntry;
            bool finished = false;

            do
            {

                Write("Enter an intiger ('exit' to exit): ");

                kbEntry = ReadLine();

                if(Int32.TryParse(kbEntry, out num))
                {

                    count++;
                    sum += num;
                    if(minimum > num)
                    {

                        minimum = num;

                    }

                }else if(kbEntry.ToLower() == "exit") {

                    finished = true;

                }
                else
                {
                    WriteLine("Please enter a valid intiger.");
                }

            } while (!finished);

            Clear();

            average = (double)sum / count;

            // Display results
            WriteLine("RESULTS\n");

            WriteLine("Sum: {0, 22}", sum);
            WriteLine("Count: {0,20}", count);
            WriteLine("Average: {0, 18}", average);
            WriteLine("Minimum: {0, 18}", minimum);

            WriteLine("\nPress any key to exit...");
            ReadKey();

        }
    }
}
