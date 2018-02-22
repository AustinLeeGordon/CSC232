/* AUTHOR: Austin Gordon
 * DATE: 2-1-18
 * PURPOSE: Convert miles into feet and its equivalent metric kilometer measurements
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Conversion
{
    class ConversionApp
    {
        static void Main(string[] args)
        {

            // declare constants
            const int FEET_PER_MILE = 5280;
            const double KILO_PER_MILE = 1.6;

            // declare i/o variables
            double miles, feet, kilometers;

            // get input values
            miles = 4.5; // compile time initialize

            // processing
            feet = FEET_PER_MILE * miles;
            kilometers = KILO_PER_MILE * miles;

            // display result
            WriteLine("\tDISTANCE CONVERTER APP\n");

            Write("Miles Input:\t");
            WriteLine(miles);
            WriteLine("\n\n\tEQUIVALENT VALUES\n");
            Write("Feet:\t\t");
            WriteLine(feet);
            Write("Kilometers\t");
            WriteLine(kilometers);

            Write("\nPress any key to quit...");

            ReadKey(); // freeze the screen

        }
    }
}
