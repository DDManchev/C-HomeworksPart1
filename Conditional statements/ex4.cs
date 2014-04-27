using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstVal = Convert.ToInt32(Console.ReadLine());
            int secondVal = Convert.ToInt32(Console.ReadLine());
            int thirdVal = Convert.ToInt32(Console.ReadLine());
            int first;
            int second;
            int third;
            if ((firstVal >= secondVal) && (firstVal >= thirdVal))
            {
                if (secondVal >= thirdVal)
                {
                    Console.WriteLine(firstVal);
                    Console.WriteLine(secondVal);
                    Console.WriteLine(thirdVal);
                }
                else
                {
                    Console.WriteLine(firstVal);
                    Console.WriteLine(thirdVal);
                    Console.WriteLine(secondVal);
                }
            }

            else if ((secondVal >= firstVal) && (secondVal >= thirdVal))
            {
                if (firstVal >= thirdVal)
                {
                    Console.WriteLine(secondVal);
                    Console.WriteLine(firstVal);
                    Console.WriteLine(thirdVal);
                }
                else
                {
                    Console.WriteLine(secondVal);
                    Console.WriteLine(thirdVal);
                   Console.WriteLine(firstVal);
                }
            }


            else if ((thirdVal >= firstVal) && (thirdVal >= secondVal))
            {
                if (first >= secondVal)
                {
                    Console.WriteLine(thirdVal);
                    Console.WriteLine(firstVal);
                    Console.WriteLine(secondVal);
                }
                else
                {
                    Console.WriteLine(thirdVal);
                    Console.WriteLine(secondVal);
                    Console.WriteLine(firstVal);
                }
            }
        }
    }
}
