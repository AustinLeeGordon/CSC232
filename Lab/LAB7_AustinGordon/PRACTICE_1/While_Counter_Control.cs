using System;
using static System.Console;

namespace PRACTICE_1

{
    class While_Counter_Control
    {
        static void Main(string[] args)
        {
            /* COUNTER-CONTROLLED LOOP
             * Loop to add 10 integers. Display the total after the loop body is completed 
             */

            int sum = 0;            //initialize to zero
            int counter = 1;         //initialize counter variable                                    

            //Loop as long as number is "less than" 5
            //Exit loop when number >= 5

            while (counter < 5)     //test counter variable to enter loop body or not                                 
            {
                sum = sum + counter;
                counter++;           //increment counter variable for next round                                            
            }

            WriteLine("Counter Value: " + counter + "     " + "Sum of Values: " + sum  );


            ReadKey();
        }
    }
}
