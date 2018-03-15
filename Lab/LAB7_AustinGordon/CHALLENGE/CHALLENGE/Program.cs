/* AUTHOR: Austin Gordon
 * DATE: 3-15-18
 * PURPOSE: LAB7 CHALLENGE - Outputs a pyramid using # symbols based on a given value
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CHALLENGE
{
    class Program
    {
        static void Main(string[] args)
        {

            int num = 6, count = 0, endCount;

            endCount = num * 2 + 1;
            
            while (count <= endCount)
            {
                if(count <= num)
                {

                    for (int i = 0; i <= count; i++)
                    {
                        Write("#");
                        
                    }

                    Write("\n");

                }else if(count < endCount)
                { // count = 6

                    for (int i = num - (count - num - 1); i > 0; i--)
                    {
                        Write("#");
                    }

                    Write("\n");

                }
                

                count++;
            }

            ReadKey();

        }
    }
}
