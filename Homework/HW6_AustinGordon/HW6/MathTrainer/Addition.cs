﻿/*
 * AUTHOR: Austin Gordon
 * DATE: April 12, 2018
 * PURPOSE: Math Trainer Application Addition Methods
 */

using System;
using static System.Console;
using System.Windows.Forms;

namespace MathTrainer
{
    class Addition
    {
        public static void Add()
        {
            /*  This method allows user to practice integer addition in 3 levels of difficulty
             *  PARAM: None
             *  RETURN: None 
             */

            string selected = null;

            selected = MathTrainer.DifficultyLevelMenu("ADDITION");

            switch (selected)
            {
                case "1":
                    EasyAdd();
                    break;
                case "2":
                    ModerateAdd();
                    break;
                case "3":
                    HardAdd();
                    break;
                case "4":
                    break;
            }

            return;

        } //Add()

        public static void EasyAdd()
        {
            /*  This method allows user to practice "easy" integer addition using random single-digit numbers,
             *   and displays useful statistics at the end.
             *  PARAM: None
             *  RETURN: None 
             */

            bool moreData = true;
            string level = "Easy";
            string strAnswer = null;
            int intAnswer = 0, correctAnswer, count = 0, userCorrect = 0, userWrong = 0;

            Random objRandomNum = new Random();

            while (moreData == true)
            {

                int op1 = objRandomNum.Next(1, 10); //random operand between [1-9]
                int op2 = objRandomNum.Next(1, 10); //random operand between [1-9]
                correctAnswer = op1 + op2;

                Clear();

                //print header and question
                Helpers.printHeader("add", level);
                Helpers.printQuestion(op1, op2, ref count, "+");

                //get answer and parse it
                strAnswer = Helpers.getUserAnswer();
                int.TryParse(strAnswer, out intAnswer); //invalid data is converted to answer=zero              

                //check answer
                Helpers.checkAnswer(intAnswer, correctAnswer, ref userCorrect, ref userWrong);

                //ask user if they want another problem
                moreData = Helpers.checkProceed("addition", level);

            }

            MathTrainer.DisplayStatistics("ADDITION", level, count, userCorrect, userWrong);

            return;

        }  //EasyAdd()

        public static void ModerateAdd()
        {
            /*  This method allows user to practice "moderate" integer addition using one random single-digit number
             *   and one two-digit number, and displays useful statistics at the end.
             *  PARAM: None
             *  RETURN: None 
             */

            bool moreData = true;
            string level = "Moderate";
            string strAnswer = null;
            int intAnswer = 0, correctAnswer, count = 0, userCorrect = 0, userWrong = 0;

            Random objRandomNum = new Random();

            while (moreData == true)
            {
                
                int op1 = objRandomNum.Next(1, 10); //random operand between [1-9]
                int op2 = objRandomNum.Next(10, 100); //random operand between [10-99]
                correctAnswer = op1 + op2;

                Clear();

                //print header and question
                Helpers.printHeader("add", level);
                Helpers.printQuestion(op1, op2, ref count, "+");

                //get answer and parse it
                strAnswer = Helpers.getUserAnswer();
                int.TryParse(strAnswer, out intAnswer); //invalid data is converted to answer=zero

                //check answer
                Helpers.checkAnswer(intAnswer, correctAnswer, ref userCorrect, ref userWrong);

                //ask user if they want another problem
                moreData = Helpers.checkProceed("addition", level);

            }

            MathTrainer.DisplayStatistics("ADDITION", level, count, userCorrect, userWrong);

            return;

        } //ModerateAdd()

        public static void HardAdd()
        {
            /*  This method allows user to practice "hard" integer addition using two random two-digit numbers,
             *   and displays useful statistics at the end.
             *  PARAM: None
             *  RETURN: None 
             */

            bool moreData = true;
            string level = "Hard";
            string strAnswer = null;
            int intAnswer = 0, correctAnswer, count = 0, userCorrect = 0, userWrong = 0;

            Random objRandomNum = new Random();

            while (moreData == true)
            {

                int op1 = objRandomNum.Next(10, 100); //random operand between [10-99]
                int op2 = objRandomNum.Next(10, 100); //random operand between [10-99]
                correctAnswer = op1 + op2;

                Clear();

                //print header and question
                Helpers.printHeader("add", level);
                Helpers.printQuestion(op1, op2, ref count, "+");

                //get answer and parse it
                strAnswer = Helpers.getUserAnswer();
                int.TryParse(strAnswer, out intAnswer); //invalid data is converted to answer=zero

                //check answer
                Helpers.checkAnswer(intAnswer, correctAnswer, ref userCorrect, ref userWrong);

                //ask user if they want another problem
                moreData = Helpers.checkProceed("addition", level);

            }

            MathTrainer.DisplayStatistics("ADDITION", level, count, userCorrect, userWrong);

            return;

        } //HardAdd()
    } //class
} //namespace
