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
    class Addition
    {
        //************************************************************************************************
        public static void Add()
        //************************************************************************************************
        {
            /*This method allows user to practice integer addition in 3 levels of difficulty, 
             *  PARAM: None
             *  RETURN: None 
             */
            string selected = null;

            selected = MathTrainer.DifficultyLevelMenu("ADDITION");  //Call external module to get difficulty level

            switch (selected)
            {
                case "1":
                    EasyAdd();  //call external method to carry out easy add
                    break;
                case "2":
                    ModerateAdd();  //call external method to carry out moderate add
                    break;
                case "3":
                    HardAdd();  //call external method to carry out hard add
                    break;
                case "4":

                    break;


            }   //switch

            return;

        }  //Add()

        //************************************************************************************************
        public static void EasyAdd()
        //************************************************************************************************
        {
            /*This method allows user to practice "easy" integer addition using random single-digit numbers,
             * and displays  useful statistics at the end.
             *  PARAM: None
             *  RETURN: None 
             */

            DialogResult proceed = DialogResult.Yes;   //define a var to capture button values of messagebox

            bool moreData = true;   //initialize flag to stop loop

            string strAnswer = null;   //user's input math answer as string
            int intAnswer = 0, correctAnswer = 0, count = 0, userCorrect = 0, userWrong = 0;

            Random objRandomNum = new Random();  //create a random object (not random number yet)


            //Do additions inside a loop as long as user wants

            while (moreData == true)
            {

                int op1 = objRandomNum.Next(1, 10);  //generate first random operand between [1-9]
                int op2 = objRandomNum.Next(1, 10);  //generate second random operand between [1-9]

                Clear();
                Helpers.printHeader("add", "easy");

                WriteLine("\nPROBLEM NUMBER: {0}\n", ++count);
                WriteLine("--------------------\n");
                WriteLine("What is the correct answer for: ");
                WriteLine("{0, 10}", op1);
                WriteLine("{0, 10}", "+");
                WriteLine("{0, 10}", op2);
                WriteLine("--------------------\n");

                //Get user's answer 
                Write("Enter your answer and hit ENTER ==>  ");
                strAnswer = ReadLine();

                int.TryParse(strAnswer, out intAnswer);  //invalid data is converted to answer=zero

                //Update performance
                correctAnswer = op1 + op2;  //computer correct answer

                if (intAnswer == correctAnswer)
                {
                    userCorrect++;  //update user correct count
                    Write("\nGood Job!");
                }
                else
                {
                    userWrong++;  //update user incorrect count
                    Write("\nSorry! The correct answer is:  {0}", correctAnswer);
                }

                //Ask want to continue in a MessageBox? Change the flag accordingly
                proceed = MessageBox.Show("Do you want to do another problem?", "ADDITION-EASY",
                                           MessageBoxButtons.YesNo,
                                           MessageBoxIcon.Question);   //MessageBox always displays in the center of the screen
                if (proceed == DialogResult.No)
                    moreData = false;              //change flag to stop the loop  

            }  //while

            MathTrainer.DisplayStatistics("ADDITION", "Easy", count, userCorrect, userWrong);   //call USD method to display statistics

            return;


        }  //EasyAdd()

        //************************************************************************************************
        public static void ModerateAdd()
        //************************************************************************************************
        {
            /*This method allows user to practice "moderate" integer addition using one random single-digit number
             * and one two-digit number, and displays useful statistics at the end.
             *  PARAM: None
             *  RETURN: None 
             */

            DialogResult proceed = DialogResult.Yes;   //define a var to capture button values of messagebox

            bool moreData = true;   //initialize flag to stop loop

            string strAnswer = null;   //user's input math answer as string
            int intAnswer = 0, correctAnswer = 0, count = 0, userCorrect = 0, userWrong = 0;

            Random objRandomNum = new Random();  //create a random object (not random number yet)


            //Do additions inside a loop as long as user wants

            while (moreData == true)
            {

                int op1 = objRandomNum.Next(1, 10);  //generate first random operand between [1-9]
                int op2 = objRandomNum.Next(10, 100);  //generate second random operand between [10-99]

                Clear();
                Helpers.printHeader("add", "moderate");

                WriteLine("\nPROBLEM NUMBER: {0}\n", ++count);
                WriteLine("--------------------\n");
                WriteLine("What is the correct answer for: ");
                WriteLine("{0, 10}", op1);
                WriteLine("{0, 10}", "+");
                WriteLine("{0, 10}", op2);
                WriteLine("--------------------\n");

                //Get user's answer 
                Write("Enter your answer and hit ENTER ==>  ");
                strAnswer = ReadLine();

                int.TryParse(strAnswer, out intAnswer);  //invalid data is converted to answer=zero

                //Update performance
                correctAnswer = op1 + op2;  //computer correct answer

                if (intAnswer == correctAnswer)
                {
                    userCorrect++;  //update user correct count
                    Write("\nGood Job!");
                }
                else
                {
                    userWrong++;  //update user incorrect count
                    Write("\nSorry! The correct answer is:  {0}", correctAnswer);
                }

                //Ask want to continue in a MessageBox? Change the flag accordingly
                proceed = MessageBox.Show("Do you want to do another problem?", "ADDITION-MODERATE",
                                           MessageBoxButtons.YesNo,
                                           MessageBoxIcon.Question);   //MessageBox always displays in the center of the screen
                if (proceed == DialogResult.No)
                    moreData = false;              //change flag to stop the loop  

            }  //while

            MathTrainer.DisplayStatistics("ADDITION", "Moderate", count, userCorrect, userWrong);   //call USD method to display statistics

            return;


        }  //ModerateAdd()

        //************************************************************************************************
        public static void HardAdd()
        //************************************************************************************************
        {
            /*This method allows user to practice "hard" integer addition using two random two-digit numbers,
             * and displays useful statistics at the end.
             *  PARAM: None
             *  RETURN: None 
             */

            DialogResult proceed = DialogResult.Yes;   //define a var to capture button values of messagebox

            bool moreData = true;   //initialize flag to stop loop

            string strAnswer = null;   //user's input math answer as string
            int intAnswer = 0, correctAnswer = 0, count = 0, userCorrect = 0, userWrong = 0;

            Random objRandomNum = new Random();  //create a random object (not random number yet)


            //Do additions inside a loop as long as user wants

            while (moreData == true)
            {

                int op1 = objRandomNum.Next(10, 100);  //generate first random operand between [10-99]
                int op2 = objRandomNum.Next(10, 100);  //generate second random operand between [10-99]

                Clear();
                Helpers.printHeader("add", "hard");

                WriteLine("\nPROBLEM NUMBER: {0}\n", ++count);
                WriteLine("--------------------\n");
                WriteLine("What is the correct answer for: ");
                WriteLine("{0, 10}", op1);
                WriteLine("{0, 10}", "+");
                WriteLine("{0, 10}", op2);
                WriteLine("--------------------\n");

                //Get user's answer 
                Write("Enter your answer and hit ENTER ==>  ");
                strAnswer = ReadLine();

                int.TryParse(strAnswer, out intAnswer);  //invalid data is converted to answer=zero

                //Update performance
                correctAnswer = op1 + op2;  //computer correct answer

                if (intAnswer == correctAnswer)
                {
                    userCorrect++;  //update user correct count
                    Write("\nGood Job!");
                }
                else
                {
                    userWrong++;  //update user incorrect count
                    Write("\nSorry! The correct answer is:  {0}", correctAnswer);
                }

                //Ask want to continue in a MessageBox? Change the flag accordingly
                proceed = MessageBox.Show("Do you want to do another problem?", "ADDITION-HARD",
                                           MessageBoxButtons.YesNo,
                                           MessageBoxIcon.Question);   //MessageBox always displays in the center of the screen
                if (proceed == DialogResult.No)
                    moreData = false;              //change flag to stop the loop  

            }  //while

            MathTrainer.DisplayStatistics("ADDITION", "Hard", count, userCorrect, userWrong);   //call USD method to display statistics

            return;


        }  //HardAdd()
    }
}
