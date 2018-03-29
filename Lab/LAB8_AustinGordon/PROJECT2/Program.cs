using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace PROJECT2
{
    class Program
    {
        static void Main(string[] args)
        {
            //call external function 
            Coin_Toss_Experiment();


        }

        static void Coin_Toss_Experiment()
        {
            /*
            * This external module simulates flipping a coin numerous times using the random Number Generator.
            * This is one wy to prove the probability theory that the chance of head or tail occurring is 50%.   
            * By definition, a head outcome will be assigned a "1" and
            * a tail outcome will be assigned a "0" arbitrarily          
            */

            //Create a new Random Number object
            Random objRandom = new Random();

            int roll;
            int countHeads  = 0, countTails = 0;
            double percentHeads = 0, percentTails = 0;

            for (roll = 1; roll <= 100000; roll++)
            {
                //Generate  random integers o or 1 using the Random NUmber object created above
                int randNumber = objRandom.Next(0, 2);  //generates 0 or 1 only; 2 is not included

                //Check if the roll is a "Head 1" or a "Tail 0".

            switch (randNumber)
                {
                    case 1:  //it is a "Head" by definition
                        countHeads = countHeads + 1;  //find running total of count
                        break;

                    case 0:  //it is a "Tail" by definition
                        countTails = countTails + 1;  //find running total of count
                        break;
                }
            }

            //After the loop is over, roll will have a value of one extra roll to stop the FOR LOOP
            //Compute

            percentHeads = (double)countHeads / (roll - 1) * 100;
            percentTails = (double)countTails / (roll - 1) * 100;

            //Display
            WriteLine("{0,-20}{1,12:N0}", "Number of Rolls", roll-1);

            WriteLine("{0,-20}{1,10:N1} {2}", "Percent of Heads", percentHeads, "%");

            WriteLine("{0,-20}{1,10:N1} {2}", "Percent of Tails", percentTails, "%");

            ReadKey();
        }  //Coin_Toss_Experiment()

    }  //class
} //namespace
