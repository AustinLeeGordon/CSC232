/* AUTHOR: Austin Gordon
 * DATE: 3-29-18
 * PURPOSE: LAB8 PROJECT1
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace PROJECT1
{
    class Program
    {
        static void Main(string[] args)
        {

            double number1 = 12.7, 
                   result;
            int number2 = 17;

            // Part 1
            //DisplayInstructions();

            // Part 2
            //Add_and_Display(number1, number2);

            // Part 3
            //result = Add_and_Return_Result(number1, number2);
            //Console.WriteLine("The sum of " + number1 + " and " + number2 + " is: " + result);

            // Part 4
            //DoSomething("Joe", 21);
            //DoSomething("Austin", 21, true, "GCM");
            //DoSomething("Bill", 22, false);
            //DoSomething("Jane", 19, true, "TSM");

            // Part 5
            //Console.WriteLine("Original values of the two number: " + number1 + " and " + number2);
            //Two_Parameter_Passing_Types(number1, ref number2);
            //Console.WriteLine("New changed values of the two number: " + number1 + " and " + number2);

            // Part 6


            ReadKey();
        }

        static void Two_Parameter_Passing_Types(double n1, ref int n2)
        {
            n1 = 100;
            n2 = 100;
        }

        static void DoSomething(string name, int age, bool currentStudent = true, string major = "CS")
        {
            WriteLine("***** OUTPUT *****\n");
            WriteLine("Name: {0}", name);
            WriteLine("Age: {0}", age.ToString());
            WriteLine("Currently Enrolled? {0}", currentStudent.ToString());
            WriteLine("Major: {0}", major);
            WriteLine();

            return;
        }

        static double Add_and_Return_Result(double num1, int num2)
        {
            return num1 + num2;
        }

        static void Add_and_Display(double num1, int num2)
        {
            WriteLine("The sum of " + num1 + " and " + num2 + " is: " + (num1 + num2));

            return;
        }

        static void DisplayInstructions()
        {
            WriteLine("==================================================");
            WriteLine("===============INTIGER MATH TRAINER===============");
            WriteLine("===================INSTRUCTIONS===================");
            WriteLine("==================================================\n");

            WriteLine("Welcome to Intiger Math Trainer App!");
            WriteLine("This interactive menu-driven App will train you in two-operand Integer:\n");

            WriteLine("1. Addition");
            WriteLine("2. Subtraction");
            WriteLine("3. Multiplication and");
            WriteLine("4. Division");

            return;
        }
    }
}
