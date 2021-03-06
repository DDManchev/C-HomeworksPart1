﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number:");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Enter bit position:");
            int position = int.Parse(Console.ReadLine());

            int mask = 1 << position;
            int maskAndNumber = number & mask;
            int pInNumber = maskAndNumber >> position;

            Console.WriteLine("In number {0} bit at position {1} is {2}", number, position, pInNumber);  
        }
    }
}
