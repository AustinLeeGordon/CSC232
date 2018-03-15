/* AUTHOR: Austin Gordon
 * DATE: 3-14-18
 * PURPOSE: HW5 - Calculates and displays BMI and weight status
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

            double weight, bmi;
            int heightInches, heightFeet;
            bool valid = false;
            string kbEntry, weightStatus;

            Write("Please enter your weight in pounds: ");

            // Get weight
            do
            {

                kbEntry = ReadLine();

                if (Double.TryParse(kbEntry, out weight))
                {

                    if (weight > 0.0)
                    {

                        valid = true;

                        WriteLine("Set weight to " + weight + "lbs\n");

                    }
                    else
                    {

                        WriteLine("Please enter a number greater than 0.");

                    }

                }else
                {
                    WriteLine("Please enter a number greater than 0.");
                }

            } while (!valid);

            valid = false;

            Write("Please enter your height in feet: ");

            // Get height in feet
            do
            {

                kbEntry = ReadLine();

                if (Int32.TryParse(kbEntry, out heightFeet))
                {

                    if (heightFeet >= 3 && heightFeet <= 8)
                    {

                        valid = true;

                        WriteLine("Set height (feet) to " + heightFeet + "ft\n");

                    }
                    else
                    {

                        WriteLine("Please enter an intiger between 3 and 8.");

                    }

                }else
                {

                    WriteLine("Please enter an intiger between 3 and 8.");

                }

            } while (!valid);

            valid = false;

            Write("Please enter your height in inches: ");

            // Get height in inches
            do
            {

                kbEntry = ReadLine();

                if (Int32.TryParse(kbEntry, out heightInches))
                {

                    if (heightInches >= 0 && heightInches <= 11)
                    {

                        valid = true;

                        WriteLine("Set height (inches) to " + heightInches + "in\n");

                    }
                    else
                    {

                        WriteLine("Please enter an intiger between 0 and 11.");

                    }
                }else
                {

                    WriteLine("Please enter an intiger between 0 and 11.");

                }

            } while (!valid);

            Clear();

            // Calculate BMI
            bmi = weight / Math.Pow((heightFeet * 12 + heightInches), 2) * 703;

            if(bmi < 18.5)
            {

                weightStatus = "Underweight";

            }else if(bmi < 25.0)
            {

                weightStatus = "Normal";

            }else if(bmi < 30)
            {

                weightStatus = "Overweight";

            }else
            {

                weightStatus = "Obese";

            }

            // Display results
            WriteLine("BMI RESULTS\n");

            WriteLine("Weight (lbs): {0,15}", weight);
            WriteLine("Height (in): {0,16}", heightFeet);
            WriteLine("Height (ft): {0,16}", heightInches);
            WriteLine("BMI: {0,24:N1}", bmi);
            WriteLine("Weight Status: {0,14}", weightStatus);

            WriteLine("\nPress any key to exit...");
            ReadKey();

        }
    }
}
