using System;
using static System.Console;


namespace PRACTICE_8
{
    class FOR_with_Break
    {
        static void Main(string[] args)
        {
            /*
             * C# provides the break; statement to alter the flow of a loop control in a program.
             * You can place a break; statement in the body of a loop (any loop such as WHILE, FOR) to provide an immediate exit from the loop.
             * When the break; statement is reached, the control immediately transfers to the statement that is located on the outside of and below the loop. 
             */

            int total = 0, nValue = 0;

            WriteLine("The actually evaluated N values in FOR loop are:\n");
            for (nValue = 0; nValue < 10; nValue++)
            {
                if (nValue == 5)
                {
                    break;  //break out of FOR loop when nValue reaches 5
                }
                total += nValue;
                Write(nValue + "\t");
            }

            WriteLine("\n\nThe N Value not evaluated in loop is: {0}", nValue);
            WriteLine("\nTotal is equal to {0}.", total);

            ReadKey();

        }
    }
}
