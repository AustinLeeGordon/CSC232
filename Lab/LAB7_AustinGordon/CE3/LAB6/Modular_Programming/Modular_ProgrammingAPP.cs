using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Modular_Programming
{
    class Modular_ProgrammingAPP
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            double result = 0;

            //Capture a "valid" value of "num1" in a validation loop till user gets it right
            //"num1" must be any positive integer


            //Capture a "valid" value of "num2" in a validation loop till user gets it right
            //"num2" must be any positive integer


            //Call "external" or "user-defined" Method to add the two numbers
            //The answer is returned by the US Method and assigned to "result"
            result = Add(num1, num2);

            //Display result
            WriteLine("Addition Result: " + result);




            ReadKey();

        } //main

        //*************************************************
        static int Add(int n1, int n2)
        {
            int ans = 0;

            ans = n1 + n2;

            return ans;  //return answer to caller
        } //Add
        //*************************************************



    } //class
} //namespace
