/*
 * AUTHOR: Austin Gordon
 * DATE: April 15, 2018
 * PURPOSE: Math Trainer Application Subtraction Methods
 */

using System;
using static System.Console;
using System.Windows.Forms;

namespace MathTrainer
{
    class Subtraction
    {
        public static void Subtract()
        {
            /*  This method allows user to practice integer subtraction in 3 levels of difficulty
             *  PARAM: None
             *  RETURN: None 
             */

            string selected = null;

            selected = MathTrainer.DifficultyLevelMenu("SUBTRACTION");

            switch (selected)
            {
                case "1":
                    EasySubtract();
                    break;
                case "2":
                    ModerateSubtract();
                    break;
                case "3":
                    HardSubtract();
                    break;
                case "4":
                    break;
            }

            return;

        } //Subtract()

        public static void EasySubtract()
        {
            /*  This method allows user to practice "easy" integer subtraction using random single-digit numbers,
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
                correctAnswer = op1 - op2;

                Clear();

                //print header and question
                Helpers.printHeader("subtract", level);
                Helpers.printQuestion(op1, op2, ref count, "-");

                //get answer and parse it
                strAnswer = Helpers.getUserAnswer();
                int.TryParse(strAnswer, out intAnswer);  //invalid data is converted to answer=zero

                //check answer
                Helpers.checkAnswer(intAnswer, correctAnswer, ref userCorrect, ref userWrong);

                //ask user if they want another problem
                moreData = Helpers.checkProceed("subtraction", level);

            }

            MathTrainer.DisplayStatistics("SUBTRACTION", level, count, userCorrect, userWrong);

            return;

        } //EasySubtract()

        public static void ModerateSubtract()
        {
            /*  This method allows user to practice "moderate" integer subtraction using one random single-digit number
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
                correctAnswer = op1 - op2;

                Clear();

                //print header and question
                Helpers.printHeader("subtract", level);
                Helpers.printQuestion(op1, op2, ref count, "-");

                //get answer and parse it
                strAnswer = Helpers.getUserAnswer();
                int.TryParse(strAnswer, out intAnswer); //invalid data is converted to answer=zero

                //check answer
                Helpers.checkAnswer(intAnswer, correctAnswer, ref userCorrect, ref userWrong);

                //ask user if they want another problem
                moreData = Helpers.checkProceed("subtraction", level);

            }

            MathTrainer.DisplayStatistics("SUBTRACTION", level, count, userCorrect, userWrong);

            return;

        } //ModerateSubtract()

        public static void HardSubtract()
        {
            /*  This method allows user to practice "hard" integer subtraction using two random two-digit numbers,
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
                correctAnswer = op1 - op2;

                Clear();

                //print header and question
                Helpers.printHeader("subtract", level);
                Helpers.printQuestion(op1, op2, ref count, "-");

                //get answer and parse it
                strAnswer = Helpers.getUserAnswer();
                int.TryParse(strAnswer, out intAnswer); //invalid data is converted to answer=zero

                //check answer
                Helpers.checkAnswer(intAnswer, correctAnswer, ref userCorrect, ref userWrong);

                //ask user if they want another problem
                moreData = Helpers.checkProceed("subtraction", level);

            }

            MathTrainer.DisplayStatistics("SUBTRACTION", level, count, userCorrect, userWrong);

            return;

        } //HardSubtract()
    } //class
} //namespace
