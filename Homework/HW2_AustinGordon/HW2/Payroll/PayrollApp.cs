/* AUTHOR: Austin Gordon
 * DATE: 2-6-18
 * PURPOSE: HW2 - Calculates an employees take home pay
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Payroll
{
    class PayrollApp
    {
        static void Main(string[] args)
        {

            const double COMM_RATE = 0.07;
            const double FED_TAX_RATE = 0.18;
            const double SOCIAL_SECURITY_RATE = 0.06;
            const double RETIREMENT_CONTRIBUTION = 0.1;

            string employeeName = "Joe Blow";
            int weeklySales = 150000;
            double grossPay, socialSecurity, retirement, federalTax;

            grossPay = weeklySales * COMM_RATE;
            socialSecurity = grossPay * SOCIAL_SECURITY_RATE;
            retirement = grossPay * RETIREMENT_CONTRIBUTION;
            federalTax = grossPay * FED_TAX_RATE;

            WriteLine("PAYROLL CALCULATOR");

            WriteLine("\nEmployee:\t\t\t" + employeeName + "\n");

            WriteLine("Gross Pay:\t\t\t" + grossPay);
            WriteLine("Social Security:\t\t" + socialSecurity);
            WriteLine("Retirement Contribution:\t" + retirement);
            WriteLine("Federal Tax:\t\t\t" + federalTax);

            WriteLine("\nTake Home Pay:\t\t\t" + (grossPay - socialSecurity - retirement - federalTax));

            ReadKey();

        }
    }
}
