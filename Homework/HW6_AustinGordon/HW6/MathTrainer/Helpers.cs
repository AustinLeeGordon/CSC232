/*
 * AUTHOR: Austin Gordon
 * DATE: April 12, 2018
 * PURPOSE: Math Trainer Application
 */

using System;
using static System.Console;
using System.Windows.Forms;

namespace MathTrainer
{
    class Helpers
    {
        public static void printHeader(string operation, string level)
        {
            WriteLine("================================================================");

            if (string.Equals(operation.ToLower(), "add"))
                WriteLine("===========================ADDITION=============================");
            else if (string.Equals(operation.ToLower(), "subtract"))
                WriteLine("===========================SUBTRACTION==========================");
            else if (string.Equals(operation.ToLower(), "multiply"))
                WriteLine("=========================MULTIPLICATION=========================");
            else
                WriteLine("=============================DIVISION===========================");

            if (string.Equals(level.ToLower(), "easy"))
                WriteLine("==========================LEVEL: EASY===========================");
            else if (string.Equals(level.ToLower(), "moderate"))
                WriteLine("========================LEVEL: MODERATE=========================");
            else
                WriteLine("==========================LEVEL: HARD===========================");

            WriteLine("================================================================");
            WriteLine();  //create a blank line under menu header
        }
    }
}