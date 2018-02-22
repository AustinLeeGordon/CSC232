/* AUTHOR: Austin Gordon
 * DATE: 2-21-18
 * PURPOSE: HW4 - Calculates and displays BMI and weight status
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace BMI
{
    class BMIApp
    {
        static void Main(string[] args)
        {

            string input, weightStatus;
            double weight, bmi;
            int heightFeet, heightInches;

            Write("Enter your weight: ");
            input = ReadLine();

            weight = Convert.ToDouble(input);

            if (weight <= 0)
            {
                Environment.Exit(0);
                Write("\nInvalid input. Press any key to exit the program...");

            }

            Write("\nEnter your height in feet: ");
            input = ReadLine();

            heightFeet = Convert.ToInt16(input);

            if (heightFeet < 3 && heightFeet > 8)
            {
                Environment.Exit(0);
                Write("\nInvalid input. Press any key to exit the program...");

            }

            Write("\nEnter your height in inches: ");
            input = ReadLine();

            heightInches = Convert.ToInt16(input);

            if (heightInches < 0 && heightInches > 11)
            {
                Environment.Exit(0);
                Write("\nInvalid input. Press any key to exit the program...");

            }

            bmi = weight / Math.Pow((heightFeet * 12 + heightInches), 2) * 703;

            if(bmi < 18.5)
            {
                weightStatus = "Underweight";

            }else if(bmi >= 18.5 && bmi <= 24.9)
            {
                weightStatus = "Normal";

            }else if(bmi >= 25.0 && bmi <= 29.9)
            {
                weightStatus = "Overweight";

            }else
            {
                weightStatus = "Obese";
            }

            WriteLine("\nBMI APP\n");

            WriteLine("Height: " + heightFeet + " ft " + heightInches + " in");
            Write("Weight: "); Write("{0:N1}", weight);
            Write("BMI: "); Write("{0:N1}", bmi);
            Write("Weight Status: " + weightStatus);
            WriteLine();
            Write("Press any key to exit...");
            ReadKey();

        }
    }
}
