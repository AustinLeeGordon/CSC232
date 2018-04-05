/* AUTHOR: Austin Gordon
 * DATE: 4-5-18
 * PURPOSE: LAB9 Question 5
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Q5
{
    class Program
    {
        static void Main(string[] args)
        {

            string str = "Joe, M, 32, 123 Rose Streer, Murray, Ky, 42071";
            string[] arrItem = new string[] { };

            arrItem = str.Split(',');

            WriteLine("Array Size: " + arrItem.Length);

            for(int i = 0; i < arrItem.Length; i++)
            {
                WriteLine(i + ": " + arrItem[i]);
            }

            ReadKey();

        }
    }
}
