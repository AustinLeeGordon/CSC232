using System;
using static System.Console;


namespace PRACTICE_6
{
    class FOR_Nested
    {
        static void Main(string[] args)
        {
            /*
             * The FOR is another pretest loop just like the WHILE counter-controlled loop.
             * It is considered a specialized for of the WHILE loop
             * We can nest a FOR loop within another FOR loop to do come cool things.
             */

            for (int i = 5 ; i <= 5; i++)
            {

                for (int j = 1; j <= i; j++)
                {
                    Write('*');
                }

                WriteLine();

            }

            WriteLine("The current value of variable i: {0}", i);

            ReadKey();
        }
    }
}
