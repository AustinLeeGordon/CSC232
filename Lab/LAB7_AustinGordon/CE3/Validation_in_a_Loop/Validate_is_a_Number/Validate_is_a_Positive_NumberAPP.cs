using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Windows.Forms;

namespace Validate_is_a_Number
{
    class Validate_is_a_Positive_NumberAPP
    {
        static void Main(string[] args)
        {
            double num;
            string kbInput;
            bool valid = false; 

            do
            {

                Write("Please enter <a positive number> and press ENTER==> ");
                kbInput = ReadLine();
                valid = double.TryParse(kbInput, out num);

                if (valid == false || num < 0)
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

        } //main

        


    } //class
} //namespace
