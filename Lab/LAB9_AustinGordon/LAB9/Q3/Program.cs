/* AUTHOR: Austin Gordon
 * DATE: 4-5-18
 * PURPOSE: LAB9 Question 3
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arrExamScore = new double[] { 89, 92, 78, 83.5, 57 };

            WriteLine("Sum of exam scores: " + sumScores(arrExamScore));

            WriteLine("Average of exam scores: " + avgScores(arrExamScore));

            ReadKey();

        }

        static double sumScores(double[] scores)
        {
            double sum = 0;

            for(int i = 0; i < scores.Length; i++)
            {
                sum += scores[i];
            }

            return sum;
        }

        static double avgScores(double[] scores)
        {
            return sumScores(scores) / scores.Length;
        }
    }
}
