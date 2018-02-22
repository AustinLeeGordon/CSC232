/* AUTHOR: Austin Gordon
 * DATE: 2-15-18
 * PURPOSE: Calculates the area and perimeter of a rectangle
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace HW3
{
    class RectangleApp
    {
        static void Main(string[] args)
        {

            double height, width, area, perimeter;
            string userInput;

            WriteLine("RECTANGLE APP");

            // Capture width input from user
            Write("Please enter a width: ");
            userInput = ReadLine();

            // Convert input to double and assign value to width
            width = Convert.ToDouble(userInput);

            // Capture height input from user
            Write("Please enter a height: ");
            userInput = ReadLine();

            // Convert input to double and assign value to width
            height = Convert.ToDouble(userInput);

            // Calculate area and perimeter
            area = width * height;
            perimeter = (width * 2) + (height * 2);

            // Display results
            WriteLine();
            WriteLine("RESULTS\n");

            WriteLine("Width Entered: " + width.ToString("#,###.0"));
            WriteLine("Height Entered: " + height.ToString("#,###.0"));
            WriteLine("Area: " + area.ToString("#,###.0"));
            WriteLine("Perimeter: " + perimeter.ToString("#,###.0"));

            WriteLine("\nPress any key to quit...");
            ReadKey();

        }
    }
}