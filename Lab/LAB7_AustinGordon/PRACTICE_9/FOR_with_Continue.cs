using System;
using static System.Console;

namespace PRACTICE_9
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * C# provides the continue; statement to alter the flow of a loop control in a program.
             * You can place a continue; statement in the body of a loop (any loop such as WHILE, DO…WHILE, FOR) to provide an immediate restart of the loop iteration.
             * When the continue; statement is reached, the control immediately restarts the loop (at the top for the FOR and WHILE loops; and at the bottom for DO…WHILE loops).
             */

            int total = 0, nValue = 0;

            WriteLine("The actually evaluated N values in FOR loop are:\n");
            for (nValue = 0; nValue < 10; nValue++)
            {
                if (nValue % 2 == 0)
                {
                    continue;   //when nvalue is "even", bypass the following statements and go back to top and continue with next iteration
                }
                total += nValue;   //do this sum for "odd" numbers only
                Write(nValue + "\t");
            }
            WriteLine("\n\nThe final nValue is equal to {0}.", nValue);
            WriteLine("\nTotal is equal to {0}.", total);

            ReadKey();

        }
    }
}
