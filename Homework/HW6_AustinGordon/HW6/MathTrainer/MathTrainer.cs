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
            //Declare variables
            string option = null;

            //Display instructions for Math Trainer
            DisplayInstructions();   //call external USD method

            //Display the main menu and handle menu option selected by user

            while (option != "5")  //keep on looping as long as option is not "5"
            {
                option = DrawMainMenu();  //Call external USD DrawMainMenu() method that drawsthe menu, and returns the menu option selected
                                          //By calling the DrawMainMenu module from within a loop can help user do multiple practices
                //Check the selected option and call appropriate method to do prcatice math
                switch (option)
                {
                    case "1":
                        Addition.Add();  //call the ADD method to practice integer addition
                        break;

                    case "2":
                        //Subtract();  //call the SUBTRACT method to practice integer subtraction
                        break;

                    case "3":
                        //Multiply();  //call the MULTIPLY method to practice integer multiplication 
                        break;

                    case "4":
                        //Division();  //call the DIVISION method to practice integer division
                        break;

                    case "5":
                        Environment.Exit(0);   //terminates the Console program
                        break;
                }//switch


            }//while
        }//Main()


        //************************************************************************************************
        public static void DisplayInstructions()
        //************************************************************************************************
        {
            /*This method displays important instructions for the Math Trainer
             *  PARAM: None
             *  RETURN: None 
             */

            Clear();  //clear screen
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

        }//DisplyInstructions


        //************************************************************************************************
        public static string DrawMainMenu()
        //************************************************************************************************
        {
            /*This method draws a main menu and asks for a valid menu choice, and returns the valid choice
             *  PARAM: None
             *  RETURN: A valid menu choice as a string 
             */

            string choice = null;
            bool valid;

            //Draw Main Menu
            //Keep the user in the loop until a valid choice is entered from menu
            valid = false;
           
            Clear();   //clear screen before drawing menu
            //Draw menu
            WriteLine("================================================================");
            WriteLine("====================INTEGER MATH TRAINER========================");
            WriteLine("=========================MAIN MENU==============================");
            WriteLine("================================================================");
            WriteLine();  //create a blank line under menu header

            WriteLine("1. ADD");
            WriteLine("2. SUBTRACT");
            WriteLine("3. MULTIPLY");
            WriteLine("4. DIVIDE");
            WriteLine("5. <QUIT>");  //always a good idea to give user a chance to quit menu loop

            do
            {
                //Ask user to select an option in aloop
                Write("\nPlease select an option [1-5], and press ENTER==> ");
                choice = ReadLine();

                //Test selected option
                switch (choice)
                {
                    case "1":
                        valid = true;  //stop the loop
                        break;  //break out of switch block
                    case "2":
                        valid = true;
                        break;  //break out of switch block
                    case "3":
                        valid = true;
                        break;  //break out of switch block
                    case "4":
                        valid = true;
                        break;
                    case "5":
                        valid = true;
                        break;

                    default:  //invalid choice
                        valid = false;
                        //Clear();
                        WriteLine("\nYou entered an invalid choice: {0} ", choice);
                        
                        break;
                }//switch
         
            }
            while (valid == false);

            //After the loop is over,return the selected choice to caller
            return choice;

        }//MainMenu()

        //************************************************************************************************
        public static string DifficultyLevelMenu(string item)
        //************************************************************************************************
        {
            /*This method allows user to select an option from 3 levels of difficulty
             * PARAM: None
             * RETURN: Menu selection as string 
             */


            string choice = null;
            bool valid;

            //Draw menu
            Clear();
            WriteLine();
            WriteLine("================================================================");
            WriteLine("=====================DIFFICULTY LEVEL MENU======================");
            WriteLine("================================================================");
            WriteLine();  //create a blank line under menu header

            WriteLine(item);
            WriteLine();
            WriteLine("1. EASY");
            WriteLine("2. MODERATE");
            WriteLine("3. HARD");
            WriteLine("4. <QUIT>");  //always a good idea to give user a chance to quit menu loop
            WriteLine();

            do
            {
                //Ask user to select an option
                Write("\nPlease select an option [1-4], and press ENTER==> ");
                choice = ReadLine();

                //Test selected option
                switch (choice)
                {
                    case "1":
                        valid = true;
                        

                        break;  //break out of switch block
                    case "2":
                        valid = true;
                        break;  //break out of switch block
                    case "3":
                        valid = true;
                        break;  //break out of switch block
                    case "4":
                        valid = true;
                        break;  //break out of switch block  

                    default:  //invalid choice
                        valid = false;
                        //Clear();
                        WriteLine("\nYou entered an invalid choice: {0} ", choice);

                        break;
                }//switch

            } while (valid == false);

            return (choice);

        }  //DifficultyLevelMenu()

        //************************************************************************************************************
        public static void DisplayStatistics(string item, string level, int counter, int totalCorrect, int totalWrong)
        //************************************************************************************************************
        {
            /*This method displays useful statistics on the output scree
             *  PARAM: item, level, counter, totalCorrect, totalWrong
             *  RETURN: None 
             */

            double percentCorrect = 0, percentWrong = 0;


            //Display useful statistics
            Clear();
            WriteLine("==================================================================");
            WriteLine("=========================STATISTICS===============================");
            WriteLine("==================================================================");
            WriteLine();
            WriteLine(item);
            WriteLine("LEVEL: " + level);
            WriteLine();
            
            //Calculate percentages
            percentCorrect = (double)totalCorrect / counter * 100.0;  //casting prevent integer division
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

        }
        


        }//class
    }//namespace

