using System;
using static System.Console;

namespace PRACTICE_3
{
    class While_Pssword_Input_Validate
    {
        static void Main(string[] args)
        {
            /* User entered PASSWORD is validated in a WHILE loop.
•	         * User is locked out after three unsuccessful attempts.
            */

            string password = "Bond_007", strValue;
            int count = 0;
           
            Write("Please enter the Password. ");
            strValue = ReadLine();         //initial value

            count++;                      //attempt = 1

            while (strValue != password)
            {
                WriteLine("Invalid input");

                if (count >= 3)
                {
                    WriteLine();
                    WriteLine("Sorry! Exceeded allowed number of attempts. You are locked out!");
                    break;   
                }
                else
                {
                    Write("Please re-enter the Password. ");
                    strValue = ReadLine();     //new value
                    count++;
                }

            }

            WriteLine();
            WriteLine("Password entered: {0}\nNo. of Attempts: {1}", strValue, count);

            ReadKey();
        }
    }
}
