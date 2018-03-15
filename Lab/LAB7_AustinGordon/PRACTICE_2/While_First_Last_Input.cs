using System;
using static System.Console;

namespace PRACTICE_2
{
    class While_First_Last_Input
    {
        static void Main(string[] args)
        {
            /* COUNTER_CONTROLLED LOOP
             * Add any range of values
             * User enteres START and STOP values
             */

            int sum = 0;
            int startValue, endValue;
            string inValue;
            int count = 0;

            Write("Enter the beginning range value: ");
            inValue = ReadLine();
            if (int.TryParse(inValue, out startValue) == false)
                WriteLine("Invalid input - 0 recorded for start value");

            Write("Enter the last range value: ");
            inValue = ReadLine();
            if (int.TryParse(inValue, out endValue) == false)
                WriteLine("Invalid input - 0 recorded for end value");

            while (startValue < endValue + 1)
            {
                count++;
                sum = sum + startValue;
                startValue++;
            }
            WriteLine();
            WriteLine("Sum of Values: {0}\nNumber of Summed Values: {1}", sum, count);

            ReadKey();

        }
    }
}
