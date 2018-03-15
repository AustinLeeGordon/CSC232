using System;
using static System.Console;
using System.Windows.Forms;

namespace PRACTICE_5
{
    class While_with_MessagBox
    {
        static void Main(string[] args)
        {
            /*
             * C# has a predefined class called MessageBox that can be used to display information to and communicate with users through its Show() method.
             * The dialog box generated is quite user friendly that we are accustomed to seeing and using.
             * We can use this dialog box in an open-ended loop to continue or stop the loop.
             */

            DialogResult proceed;   //define a var to capture button values of messagebox

            bool moreData = true;   //initialize flag
            string inValue = "";
            int sum = 0, examScore = 0, num = 0;

            //Exam scores loop
            while (moreData == true)
            {
                Write("Enter exam score (0-100): ");
                inValue = ReadLine();       //initialize & update

                //Validate each entered exam score loop
                while (int.TryParse(inValue, out examScore) == false)
                {
                    WriteLine("Invalid input - Re-enter valid exam score.");
                    Write("Enter exam score (0-100): ");
                    inValue = ReadLine();   //update invalid data
                }
                //Process data
                num++;
                sum += examScore;     //Keep running total scores

                //Ask want to continue in a MessageBox? Change the flag accordingly
                proceed = MessageBox.Show("Do you want to add another score?", "Flag Controlled Loop",
                                           MessageBoxButtons.YesNo,
                                           MessageBoxIcon.Question);   //MessageBox always displays in the center of the screen

                if (proceed == DialogResult.No)
                    moreData = false;              //change flag to stop the outer loop  

            }
            WriteLine("\n\nThe number of exam scores: {0}", num);
            WriteLine("Sum of exam scores: {0}", sum);

            ReadKey();
        }
    }
}
