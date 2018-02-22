/* AUTHOR: Austin Gordon
 * DATE: 2-15-18
 * PURPOSE: Helps determine property tax for current year
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace HW3
{
    class PropertyTaxApp
    {
        static void Main(string[] args)
        {

            const double MILEAGE_RATE = 10.03;
            const int HOMEOWNERS_EXEMPTION = 25000;

            string address, userInput;
            double previousValue, currentValue, taxableValue, taxesDue;
            double assessedValueIncrease = 0.027; // not constant becuase it may change next year

            WriteLine("PROPERTY TAX APP");

            // Capture address input from user
            Write("Please enter your address: ");
            userInput = ReadLine();

            // Assign input value to address
            address = userInput;

            // Capture previous value input from user
            Write("Please enter your property's assessed value from last year: ");
            userInput = ReadLine();

            // Convert input to double and assign value to previousValue
            previousValue = Convert.ToDouble(userInput);

            // Calculate current assessed value
            currentValue = previousValue * (1 + assessedValueIncrease);

            // Calculate taxable value
            taxableValue = currentValue - HOMEOWNERS_EXEMPTION;

            // Calculate taxes due
            taxesDue = taxableValue * (MILEAGE_RATE / 1000);

            // Display results
            WriteLine();
            WriteLine("RESULTS\n");

            WriteLine("Street Address: " + address);

            WriteLine("\nLast Year Assessed Value: " + previousValue.ToString("#,###.00"));

            WriteLine("\nCurrent Assessed Value: " + currentValue.ToString("#,###.00"));
            WriteLine("Exemption:\t\t" + HOMEOWNERS_EXEMPTION);
            WriteLine("Taxable Value:\t\t" + taxableValue.ToString("#,###.00"));

            WriteLine("\nMileage Rate (per $1000): " + MILEAGE_RATE);

            WriteLine("\nTaxes Due:\t\t" + taxesDue.ToString("#,###.00"));

            WriteLine("\nPress any key to quit...");
            ReadKey();

        }
    }
}