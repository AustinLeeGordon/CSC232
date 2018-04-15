/*
 * AUTHOR: Austin Gordon
 * DATE: April 12, 2018
 * PURPOSE: Math Trainer Application Division Methods
 */

using System;
using static System.Console;
using System.Windows.Forms;

namespace MathTrainer
{
    class Division
    {
        public static void Divide()
        {
            /*  This method allows user to practice integer division in 3 levels of difficulty
             *  PARAM: None
             *  RETURN: None 
             */

            string selected = null;

            selected = MathTrainer.DifficultyLevelMenu("DIVISION");

            switch (selected)
            {
                case "1":
                    EasyDivide();
                    break;
                case "2":
                    ModerateDivide();
                    break;
                case "3":
                    HardDivide();
                    break;
                case "4":
                    break;
            }

            return;

        } //Divide()

        public static void EasyDivide()
        {
            /*  This method allows user to practice "easy" integer division using random single-digit numbers,
             *   and displays useful statistics at the end.
             *  PARAM: None
             *  RETURN: None 
             */

            bool moreData = true;
            string level = "Easy";
            string strQuotientAnswer = null, strRemainderAnswer = null;
            int intQuotientAnswer = 0, intRemainderAnswer = 0, correctRemainderAnswer, correctQuotientAnswer, count = 0, userCorrect = 0, userWrong = 0;

            Random objRandomNum = new Random();

            while (moreData == true)
            {

                int op1 = objRandomNum.Next(1, 10); //random operand between [1-9]
                int op2 = objRandomNum.Next(1, 10); //random operand between [1-9]

                trySwapNumbers(ref op1, ref op2); //check if op1 < op2 and if so, swap them

                correctRemainderAnswer = op1 % op2;
                correctQuotientAnswer = (op1 - correctRemainderAnswer) / op2;

                Clear();

                //print header and question
                Helpers.printHeader("divide", level);
                Helpers.printQuestion(op1, op2, ref count, "/");

                //get quotient answer and parse it
                strQuotientAnswer = getQuotientAnswer();
                int.TryParse(strQuotientAnswer, out intQuotientAnswer);  //invalid data is converted to answer=zero

                //get remainder answer and parse it
                strRemainderAnswer = getRemainderAnswer();
                int.TryParse(strRemainderAnswer, out intRemainderAnswer);  //invalid data is converted to answer=zero

                //check answer
                checkAnswer(intQuotientAnswer, intRemainderAnswer, correctQuotientAnswer, correctRemainderAnswer, ref userCorrect, ref userWrong);

                //ask user if they want another problem
                moreData = Helpers.checkProceed("division", level);

            }

            MathTrainer.DisplayStatistics("DIVISION", level, count, userCorrect, userWrong);

            return;

        } //EasyDivide()

        public static void ModerateDivide()
        {
            /*  This method allows user to practice "moderate" integer division using one random single-digit number
             *   and one two-digit number, and displays useful statistics at the end.
             *  PARAM: None
             *  RETURN: None 
             */

            bool moreData = true;
            string level = "Moderate";
            string strQuotientAnswer = null, strRemainderAnswer = null;
            int intQuotientAnswer = 0, intRemainderAnswer = 0, correctRemainderAnswer, correctQuotientAnswer, count = 0, userCorrect = 0, userWrong = 0;

            Random objRandomNum = new Random();

            while (moreData == true)
            {

                int op1 = objRandomNum.Next(1, 10); //random operand between [1-9]
                int op2 = objRandomNum.Next(10, 100); //random operand between [10-99]

                trySwapNumbers(ref op1, ref op2); //check if op1 < op2 and if so, swap them

                correctRemainderAnswer = op1 % op2;
                correctQuotientAnswer = (op1 - correctRemainderAnswer) / op2;

                Clear();

                //print header and question
                Helpers.printHeader("divide", level);
                Helpers.printQuestion(op1, op2, ref count, "/");

                //get quotient answer and parse it
                strQuotientAnswer = getQuotientAnswer();
                int.TryParse(strQuotientAnswer, out intQuotientAnswer);  //invalid data is converted to answer=zero

                //get remainder answer and parse it
                strRemainderAnswer = getRemainderAnswer();
                int.TryParse(strRemainderAnswer, out intRemainderAnswer);  //invalid data is converted to answer=zero

                //check answer
                checkAnswer(intQuotientAnswer, intRemainderAnswer, correctQuotientAnswer, correctRemainderAnswer, ref userCorrect, ref userWrong);

                //ask user if they want another problem
                moreData = Helpers.checkProceed("division", level);

            }

            MathTrainer.DisplayStatistics("DIVISION", level, count, userCorrect, userWrong);

            return;

        } //ModerateDivide()

        public static void HardDivide()
        {
            /*  This method allows user to practice "hard" integer division using two random two-digit numbers,
             *   and displays useful statistics at the end.
             *  PARAM: None
             *  RETURN: None 
             */

            bool moreData = true;
            string level = "Hard";
            string strQuotientAnswer = null, strRemainderAnswer = null;
            int intQuotientAnswer = 0, intRemainderAnswer = 0, correctRemainderAnswer, correctQuotientAnswer, count = 0, userCorrect = 0, userWrong = 0;

            Random objRandomNum = new Random();

            while (moreData == true)
            {

                int op1 = objRandomNum.Next(10, 100); //random operand between [10-99]
                int op2 = objRandomNum.Next(10, 100); //random operand between [10-99]

                trySwapNumbers(ref op1, ref op2); //check if op1 < op2 and if so, swap them

                correctRemainderAnswer = op1 % op2;
                correctQuotientAnswer = (op1 - correctRemainderAnswer) / op2;

                Clear();

                //print header and question
                Helpers.printHeader("divide", level);
                Helpers.printQuestion(op1, op2, ref count, "/");

                //get quotient answer and parse it
                strQuotientAnswer = getQuotientAnswer();
                int.TryParse(strQuotientAnswer, out intQuotientAnswer);  //invalid data is converted to answer=zero

                //get remainder answer and parse it
                strRemainderAnswer = getRemainderAnswer();
                int.TryParse(strRemainderAnswer, out intRemainderAnswer);  //invalid data is converted to answer=zero

                //check answer
                checkAnswer(intQuotientAnswer, intRemainderAnswer, correctQuotientAnswer, correctRemainderAnswer, ref userCorrect, ref userWrong);

                //ask user if they want another problem
                moreData = Helpers.checkProceed("division", level);

            }

            MathTrainer.DisplayStatistics("DIVISION", level, count, userCorrect, userWrong);

            return;

        } //HardDivide()

        public static void trySwapNumbers(ref int op1, ref int op2)
        {
            /*  This method swaps op1 and op2 if op2 is larger
             *  PARAM: op1, op2
             *  RETURN: None
             */

            if (op1 < op2)
            {
                int temp = op2;
                op2 = op1;
                op1 = temp;
            }

        } //trySwapNumbers()

        public static string getQuotientAnswer()
        {
            /*  This method prints text asking for the quotient answer and returns their answer
             *  PARAM: None
             *  RETURN: User quotient answer as a string 
             */

            Write("Enter the answer for quotient and hit ENTER ==>  ");
            return ReadLine();

        } //getQuotientAnswer()

        public static string getRemainderAnswer()
        {
            /*  This method prints text asking for the remainder answer and returns their answer
             *  PARAM: None
             *  RETURN: User remainder answer as a string 
             */

            Write("Enter the answer for remainder and hit ENTER ==>  ");
            return ReadLine();

        } //getRemainderAnswer()

        public static void checkAnswer(int quotientAnswer, int remainderAnswer, int correctQuotient, int correctRemainder, ref int userCorrect, ref int userWrong)
        {
            /*  This method checks the answer and prints a message for correct or incorrect answers
             *  PARAM: quotientAnswer, remainderAnswer, correctQuotient, correctRemainder, userCorrect, userWrong
             *  RETURN: None
             */

            if (quotientAnswer == correctQuotient && remainderAnswer == correctRemainder)
            {
                userCorrect++; //update user correct count
                Write("\nGood Job!");
            }
            else
            {
                userWrong++; //update user incorrect count
                Write("\nSorry! The correct answer is:  {0}  R: {1}", correctQuotient, correctRemainder);
            }

        } //checkAnswer()
    } //class
} //namespace
