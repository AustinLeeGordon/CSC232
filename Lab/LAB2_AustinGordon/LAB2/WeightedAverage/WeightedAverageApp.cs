/* AUTHOR: Austin Gordon
 * DATE: 2-1-18
 * PURPOSE: Calculate a weighted average
 */
 
 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace WeightedAverage
{
    class WeightedAverageApp
    {
        static void Main(string[] args)
        {

            // declare constants
            const double HW_WT = 0.35;
            const double LAB_WT = 0.15;
            const double EXAM_WT = 0.5;

            // declare i/o variables
            double homeworkAvg, labAvg, examAvg, overallAvg;

            // get input values
            homeworkAvg = 97;
            labAvg = 82;
            examAvg = 75;

            // processing
            overallAvg = homeworkAvg * HW_WT + labAvg * LAB_WT + examAvg * EXAM_WT;

            // dsplay results
            WriteLine("\tWEIGHTED AVERAGE APPLICATION\n");

            Write("Homework Average:\t");
            Write(homeworkAvg);
            Write("\tWeight: ");
            Write(HW_WT * 100);
            WriteLine("%");

            Write("Lab Average:\t\t");
            Write(labAvg);
            Write("\tWeight: ");
            Write(LAB_WT * 100);
            WriteLine("%");

            Write("Exam Average:\t\t");
            Write(examAvg);
            Write("\tWeight: ");
            Write(EXAM_WT * 100);
            WriteLine("%");

            WriteLine("\n\n");

            Write("Weighted Average:\t");
            WriteLine(overallAvg);
            Write("Press any key to exit...");

            ReadKey(); // freeze the screen

        }
    }
}
