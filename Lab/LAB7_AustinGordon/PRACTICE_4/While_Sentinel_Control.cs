using System;
using static System.Console;

namespace PRACTICE_4
{
    class While_Sentinel_Control
    {
        static void Main(string[] args)
        {
            /* There are situations you may not know in advance how many iterations are needed.
             * In these situations, we nay use a SENTINEL-CONTROLLED loop (also known as Open-Ended loop).
             * A Sentinel value must be an extreme or dummy value far different from the actual data used.
             */

            string inValue = "";
            int sum = 0, examScore = 0, num = 0;

            Write("This program will let you enter");
            Write(" exam score after score. To Stop, enter");
            WriteLine(" -999");

            Write("Enter exam score (-999 to exit): ");
            inValue = ReadLine();       //initilaize

            //Exam scores loop
            while (inValue != "-999")
            {
                //Validate each entered exam score loop
                while (int.TryParse(inValue, out examScore) == false)
                {
                    WriteLine("Invalid input - Re-enter valid exam score.");
                    Write("Enter exam score (-999 to exit): ");
                    inValue = ReadLine();   //update invalid data
                }
                //Process data
                if (inValue != "-999")
                {
                    num++;
                    sum += examScore;     //Keep running total scores
                }

                Write("Enter exam score (-999 to exit): ");
                inValue = ReadLine();       //update
            }
            WriteLine();
            WriteLine("The number of exam scores: {0}", num);
            WriteLine("Sum of exam scores: {0}", sum);

            ReadKey();
        }
    }
}
