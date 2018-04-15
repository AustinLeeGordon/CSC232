/*
 * AUTHOR: Austin Gordon
 * DATE: April 12, 2018
 * PURPOSE: Math Trainer Application
 */

using System;
using static System.Console;
using System.Windows.Forms;

namespace MathTrainer
{
    class MathTrainer
    {
               
        static void Main(string[] args)
        {
            string option = null;

            DisplayInstructions();

            //display the main menu and handle menu option selected by user
            while (option != "5")
            {
                option = DrawMainMenu();

                //check the selected option and call appropriate method to do prcatice math
                switch (option)
                {
                    case "1":
                        Addition.Add();
                        break;
                    case "2":
                        Subtraction.Subtract();
                        break;
                    case "3":
                        Multiplication.Multiply(); 
                        break;
                    case "4":
                        Division.Divide();
                        break;
                    case "5":
                        Environment.Exit(0);
                        break;
                }

            }

        } //Main()

        public static void DisplayInstructions()
        {
            /*  This method displays important instructions for the Math Trainer
             *  PARAM: None
             *  RETURN: None 
             */

            Clear();
            WriteLine("\n==================================================================");
            WriteLine("====================INTEGER MATH TRAINER==========================");
            WriteLine("=========================INSTRUCTIONS=============================");
            WriteLine("==================================================================");
            WriteLine();

            WriteLine("Welcome to Integer Math Trainer App!");
            WriteLine("This interactive menu-driven App will train you in two-operand Integer:");
            WriteLine("\n1. Addition  \n2. Subtration  \n3. Multiplication and \n4. Division\n");
            WriteLine("at your own pace with randomly-generated exercises with only 2 operands.");

            WriteLine("There are 3 levels of difficulty for each selected category of Integer Math:");
            WriteLine("\n1. Easy (All one-digit operands) \n2. Moderate (Two-Digit and One-Digit Operands) and \n3. Hard (All Two-Digit Operands)\n");

            WriteLine("At the end of the training, the App will display useful statistics.\n");
            Write("Press any key to continue...  ");
            ReadKey();

        } //DisplyInstructions


        public static string DrawMainMenu()
        {
            /*  This method draws a main menu and asks for a valid menu choice, and returns the valid choice
             *  PARAM: None
             *  RETURN: A valid menu choice as a string 
             */

            string choice = null;
            bool valid = false;
           
            Clear();
            WriteLine("================================================================");
            WriteLine("====================INTEGER MATH TRAINER========================");
            WriteLine("=========================MAIN MENU==============================");
            WriteLine("================================================================");
            WriteLine();

            WriteLine("1. ADD");
            WriteLine("2. SUBTRACT");
            WriteLine("3. MULTIPLY");
            WriteLine("4. DIVIDE");
            WriteLine("5. <QUIT>");

            do
            {
                Write("\nPlease select an option [1-5], and press ENTER==> ");
                choice = ReadLine();

                switch (choice)
                {
                    case "1":
                        valid = true;
                        break;
                    case "2":
                        valid = true;
                        break;
                    case "3":
                        valid = true;
                        break;
                    case "4":
                        valid = true;
                        break;
                    case "5":
                        valid = true;
                        break;
                    default:
                        valid = false;
                        WriteLine("\nYou entered an invalid choice: {0} ", choice);
                        break;
                }
            }
            while (valid == false);

            return choice;

        } //MainMenu()

        public static string DifficultyLevelMenu(string item)
        {
            /*  This method allows user to select an option from 3 levels of difficulty
             *  PARAM: None
             *  RETURN: Menu selection as string 
             */

            string choice = null;
            bool valid = false;

            Clear();
            WriteLine();
            WriteLine("================================================================");
            WriteLine("=====================DIFFICULTY LEVEL MENU======================");
            WriteLine("================================================================");
            WriteLine();

            WriteLine(item);
            WriteLine();
            WriteLine("1. EASY");
            WriteLine("2. MODERATE");
            WriteLine("3. HARD");
            WriteLine("4. <QUIT>");
            WriteLine();

            do
            {
                Write("\nPlease select an option [1-4], and press ENTER==> ");
                choice = ReadLine();

                switch (choice)
                {
                    case "1":
                        valid = true;
                        break;
                    case "2":
                        valid = true;
                        break;
                    case "3":
                        valid = true;
                        break;
                    case "4":
                        valid = true;
                        break;
                    default:
                        valid = false;
                        WriteLine("\nYou entered an invalid choice: {0} ", choice);
                        break;
                }

            } while (valid == false);

            return (choice);

        } //DifficultyLevelMenu()

        public static void DisplayStatistics(string item, string level, int counter, int totalCorrect, int totalWrong)
        {
            /*  This method displays useful statistics on the output screen
             *  PARAM: item, level, counter, totalCorrect, totalWrong
             *  RETURN: None 
             */
            
            double percentCorrect = 0, percentWrong = 0;

            Clear();
            WriteLine("==================================================================");
            WriteLine("=========================STATISTICS===============================");
            WriteLine("==================================================================");
            WriteLine();
            WriteLine(item);
            WriteLine("LEVEL: " + level);
            WriteLine();
            
            //calculate percentages
            percentCorrect = (double)totalCorrect / counter * 100.0;
            percentWrong = 100.0 - percentCorrect;

            WriteLine("{0, -30}{1, 10}", "Total Problems Attempted:", counter);
            WriteLine("{0, -30}{1, 10}{2,10:N1}%", "Total Correct Answer(s):", totalCorrect, percentCorrect);
            WriteLine("{0, -30}{1, 10}{2,10:N1}%", "Total Wrong Answer(s):", totalWrong, percentWrong);
            WriteLine();

            if (percentCorrect >= 90.0)
               WriteLine("Congratulations! You passed with flying colors.");
            else if (percentCorrect >= 80)
                WriteLine("Good Job! You did well.");
            else if (percentCorrect >= 70)
                WriteLine("Average Job! You did okay.");
            else
                WriteLine("You need more practice. Never give up!");

            Write("\n\nPress any key to continue... ");
            ReadKey();

            return;

        } //DisplayStatistics()
    } //class
} //namespace

