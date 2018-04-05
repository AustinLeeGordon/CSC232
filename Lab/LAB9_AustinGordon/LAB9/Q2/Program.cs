/* AUTHOR: Austin Gordon
 * DATE: 4-5-18
 * PURPOSE: LAB9 Question 2
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrNum = new int[100];

            for(int i = 1; i < 6; i++)
            {
                arrNum[i] = (int)Math.Pow(i, 2.0);

                WriteLine(i + " squared = " + arrNum[i]);
            }

            ReadKey();

        }
    }
}
