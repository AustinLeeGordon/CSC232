using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Validate_Number_in_a_Given_Range
{
    class Validate_Number_in_a_Given_RangeAPP
    {
        static void Main(string[] args)
        {
            double num;
            string kbInput;
            bool valid = false;

            do
            {
                Write("Enter <a number between 5 and 8 both inclusive> and press ENTER==> ");
                kbInput = ReadLine();
                valid = double.TryParse(kbInput, out num);

                if (valid == false || num < 5 || num > 8)
                {  //parsing failed since invalid data entered
                    valid = false;  //so that validation LOOP continues for more data entry chances

                    Write("***Invalid data input. Try again. *** Press any key. \n\n");
                    WriteLine();
                    ReadKey();
                }

                else
                { //valid data entered; change flag to stop the LOOP
                    valid = true;  //so that validation LOOP stops
                }

            } while (valid == false);  //stop LOOP when condition becomes FALSE

            WriteLine();
            WriteLine("Congrats! The number you entered is: " + kbInput);
            ReadKey();
        }
    }
}
