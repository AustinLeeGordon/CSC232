﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Windows.Forms;

namespace Validate_Name
{
    class Validate_NameAPP
    {
        static void Main(string[] args)
        {
            string kbInput;
            bool empty = true;  //flag to determine empty string

            do  //keep on looping as long as condition is TRUE
            {

                Write("Please enter your name and press ENTER==> ");
                
                kbInput = ReadLine();

                //Use Class String's method to determine if string is null
                empty = String.IsNullOrWhiteSpace(kbInput);  //returns true if string is null or empty

                //Evaluate data entry
                if (empty == true)
                {  //no name entered
                    
                    WriteLine("\n\n***No data input. Please Try Again. \n ***Press any key.");
                    WriteLine();
                    ReadKey();

                }
                else
                { //name is entered

                    empty = false;  //change flag so that validation LOOP stops
                }

            } while (empty == true);  //stop LOOP when condition becomes FALSE

            WriteLine();
            WriteLine("Congrats! The name you entered is: " + kbInput);
            ReadKey();


        } //main
        
    } //class
} //namespace
