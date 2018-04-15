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
    class Helpers
    {
        public static void printHeader(string operation, string level)
        {
            /*  This method prints the header for a problem
             *  PARAM: operation, level
             *  RETURN: None 
             */

            WriteLine("================================================================");

            if (string.Equals(operation.ToLower(), "add"))
                WriteLine("===========================ADDITION=============================");
            else if (string.Equals(operation.ToLower(), "subtract"))
                WriteLine("===========================SUBTRACTION==========================");
            else if (string.Equals(operation.ToLower(), "multiply"))
                WriteLine("=========================MULTIPLICATION=========================");
            else
                WriteLine("=============================DIVISION===========================");

            if (string.Equals(level.ToLower(), "easy"))
                WriteLine("==========================LEVEL: EASY===========================");
            else if (string.Equals(level.ToLower(), "moderate"))
                WriteLine("========================LEVEL: MODERATE=========================");
            else
                WriteLine("==========================LEVEL: HARD===========================");

            WriteLine("================================================================");
            WriteLine();
        } //printHeader()

        public static void printQuestion(int n1, int n2, ref int count, string operationSign)
        {
            /*  This method prints out the current question
             *  PARAM: n1, n2, count, operationSign
             *  RETURN: None 
             */

            WriteLine("\nPROBLEM NUMBER: {0}\n", ++count);
            WriteLine("--------------------\n");
            WriteLine("What is the correct answer for: ");
            WriteLine("{0, 10}", n1);
            WriteLine("{0, 10}", operationSign);
            WriteLine("{0, 10}", n2);
            WriteLine("--------------------\n");
        } //printQuestion()

        public static string getUserAnswer()
        {
            /*  This method prints text asking for an answer and returns their answer
             *  PARAM: None
             *  RETURN: User answer as a string 
             */

            Write("Enter your answer and hit ENTER ==>  ");
            return ReadLine();
        } //getUserAnswer()

        public static void checkAnswer(int answer, int correct, ref int userCorrect, ref int userWrong)
        {
            /*  This method checks the answer and prints a message for correct or incorrect answers
             *  PARAM: answer, correct, userCorrect, userWrong
             *  RETURN: None
             */

            if (answer == correct)
            {
                userCorrect++; //update user correct count
                Write("\nGood Job!");
            }
            else
            {
                userWrong++; //update user incorrect count
                Write("\nSorry! The correct answer is:  {0}", correct);
            }
        } //checkAnswer()

        public static bool checkProceed(string operation, string level)
        {
            /*  This method displays a dialog box asking if the user wants another question, then returns
             *   a boolean representing their response
             *  PARAM: operation, level
             *  RETURN: User selection as a boolean
             */

            DialogResult proceed = DialogResult.Yes; //define a var to capture button values of messagebox

            //ask if user wants to continue
            proceed = MessageBox.Show("Do you want to do another problem?", operation.ToUpper() + "-" + level.ToUpper(),
                                       MessageBoxButtons.YesNo,
                                       MessageBoxIcon.Question);

            if (proceed == DialogResult.No) return false;

            return true;
        } //checkProceed()
    }
}