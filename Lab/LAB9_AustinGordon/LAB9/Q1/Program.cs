/* AUTHOR: Austin Gordon
 * DATE: 4-5-18
 * PURPOSE: LAB9 Question 1
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arrA = new double[]{2.1,4.5,1.7,5.7};

            WriteLine(arrA[2]);

            arrA[arrA.Length - 1] = arrA[arrA.Length - 1] * 2;

            WriteLine(arrA[arrA.Length - 1]);

            ReadKey();

        }
    }
}
