/* AUTHOR: Austin Gordon
 * DATE: 2-21-18
 * PURPOSE: HW4 - Calculates and displays the profit an organization receives
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SalesProfit
{
    class SalesProfitApp
    {
        static void Main(string[] args)
        {

            string input;
            double profitRatio, netProceeds, salesAmount;

            Write("Please enter a sales amount: ");
            input = ReadLine();

            salesAmount = Convert.ToDouble(input);

            if(salesAmount >= 0 && salesAmount <= 1000.00)
            {
                profitRatio = .03;

            }else if(salesAmount >= 1000.01 && salesAmount <= 5000.00)
            {
                profitRatio = .035;

            }else if(salesAmount >= 5000.01 && salesAmount <= 10000.00)
            {
                profitRatio = .04;

            }else
            {
                profitRatio = .045;
            }

            netProceeds = salesAmount * profitRatio;

            WriteLine("\nSALES PROFIT APP\n");
            Write("Sales: "); Write("{0:c}", salesAmount);
            WriteLine();
            Write("Profit Ratio: "); Write("{0:P}", profitRatio);
            WriteLine();
            Write("Net Proceeds: "); Write("{0:c}", netProceeds);
            WriteLine();
            Write("Press any key to exit...");
            ReadKey();

        }
    }
}
