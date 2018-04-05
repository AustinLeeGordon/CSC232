/* AUTHOR: Austin Gordon
 * DATE: 4-5-18
 * PURPOSE: LAB9 Question 4
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Q4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrNum = new int[100];
            int arrSize = 0, currentNum;
            bool running = true;
            string kbEntry;

            while (running)
            {

                WriteLine("Enter an intiger (x to exit): ");

                kbEntry = ReadLine();

                if (kbEntry == "x")
                {
                    running = false;
                }
                else if (Int32.TryParse(kbEntry, out currentNum))
                {

                    arrNum[arrSize] = currentNum;

                    WriteLine("Added " + currentNum + " to array.");

                    arrSize++;

                }
                else
                {
                    WriteLine("Please enter a whole number.");
                }

            }

            Clear();

            printArray(arrNum, arrSize);

            WriteLine("Array length: " + arrSize);

            ReadKey();

        }

        static void printArray(int[] arr, int size)
        {
            Write("Array: ");

            for (int i = 0; i < size; i++)
            {
                Write(arr[i] + (i == size - 1 ? "" : ", "));
            }

            WriteLine();
        }
    }
}
