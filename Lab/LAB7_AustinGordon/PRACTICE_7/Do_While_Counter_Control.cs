using System;
using static System.Console;


namespace PRACTICE_7
{
    class Do_While_Counter_Control
    {
        static void Main(string[] args)
        {
            /*
             * The DO…WHILE is the only posttest loop structure available in C#
             * With a posttest, the statements in the loop body are executed once before the conditional expression is tested at the bottom.
             * It guarantees that that the loop body is always executed at least once regardless of the value of the conditional expression written.
             */

            int counter = 1;

            WriteLine("COUNTER" + "\t" + "SQUARED");   //write heading before loop so that it does not repeat
            do                  // No semicolon on this line
            {
                WriteLine(counter + "\t\t" + Math.Pow(counter, 2));
                counter--;  //decrease counter by one
            }
            while (counter > 6);  //keep on looping as long as condition TRUE; stop when FALSE

            ReadKey();
            
        }
    }
}
