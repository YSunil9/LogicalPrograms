﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    internal class LogicalSolutions
    {
        public static void Fibonacci()
        {
            int x=0, y=1,z= 0;
            Console.WriteLine("Enter value");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-----\n0 \n1");
            for (int i = 2; i < input; i++)
            {
                z = x+y;
                x = y;
                y = z;
                Console.WriteLine(z);
               
            }
        }
        //CheckPerfectNumber
        public static void FindPerfectNumber()
        {
            int result = 0;
            Console.WriteLine("Enter number to check for perfect number");
            int input = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < input; i++)
            {
                if (input % i == 0)
                {
                    result = result + i;
                }
            }
            if (result == input)
            {
                Console.WriteLine(input + " is a perfect number");
            }
            else
            {
                Console.WriteLine(input + " is not a perfect number");
            }
        }
    }
}
