using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Windows.Forms;

namespace Validate_Menu
{
    class Validate_MenuAPP
    {
        static void Main(string[] args)
        {
            //********** VARIABLE DECLARATION **********
            string kbEntry = null;
            bool valid = false;

            //********** INPUT ************************

            //Ask user to select a menu option inside a LOOP

            do
            {  //This 1st Do Loop draws the menu again and again till you quit with option "7"

                DrawMenu();  //call external method to draw menu

                do
                {

                    Write("\nPlease select an option [1-7], and press ENTER==> ");
                    kbEntry = ReadLine();

                    //Validate input and call methods
                    switch (kbEntry)
                    {
                        //Determine specific menu option and call method to perform that option
                        case "1": 
                            MenuOption1();  //Call module to do option 1
                            valid = true;  //so that validating LOOP stops
                            break;  //break out of switch block

                        case "2":
                            //;  //Call module to do option 2
                            valid = true;  //so that validating LOOP stops
                            break;  //break out of switch block
                        case "3":
                            //;  //Call module to do option 3
                            valid = true;  //so that validating LOOP stops
                            break;  //break out of switch block

                        case "4":
                            //;  //Call module to do option 4
                            valid = true;  //so that validating LOOP stops
                            break;  //break out of switch block
                        case "5":
                            //;  //Call module to do option 5
                            valid = true;  //so that validating LOOP stops
                            break;  //break out of switch block
                        case "6":
                            //;  //Call module to do option 6
                            valid = true;  //so that validating LOOP stops
                            break;  //break out of switch block
                        case "7":
                            valid = true;  //so that validating LOOP stops
                            break;  //break out of switch and display "Thank You" message

                        default:  //invalid choice
                            valid = false;  //so that validating LOOP continues for more data entry chances
                            WriteLine("\nYou entered an invalid choice. Try again.: {0}\n\n", kbEntry);
                            break;
                    }//switch

                } while (valid == false);  //stop loop when condition becomes FALSE

            } while (kbEntry != "7");

            WriteLine();
            WriteLine("Thanks for using our Application. Press Enter to stop the App.");
            ReadKey();


        } //Main()

        //mmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmm
        static void DrawMenu()
        {
            //Draw menu
            Clear();   //clear screen before drawing menu
            WriteLine("================================================================");
            WriteLine("=========================MAIN MENU==============================");
            WriteLine("==============+++A MENU_DRIVEN APPLICATION===+++================");
            WriteLine("================================================================");
            WriteLine();  //create a blank line under menu header

            WriteLine();
            WriteLine("1. Menu Option 1");
            WriteLine("2. Menu Option 2");
            WriteLine("3. Menu Option 3");
            WriteLine("4. Menu Option 4");
            WriteLine("5. Menu Option 5");
            WriteLine("6. Menu Option 6");
            WriteLine("7. <QUIT>");
            WriteLine();

            return;  //return to caller

        } //DrawMenu

        static void MenuOption1()
        {
            WriteLine();
            WriteLine();
            WriteLine("Hello, I am menu option 1. Nice to meet you.");
            
            ReadKey();

            return;  //return to caller

        }

        } //class
} //namespace

