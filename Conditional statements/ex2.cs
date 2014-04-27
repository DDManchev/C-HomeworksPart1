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
            Console.Write("Enter first value: ");
            int firstVal = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second value: ");
            int secondVal = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second value: ");
            int thirdVal = Convert.ToInt32(Console.ReadLine());
            if (((firstVal < 0) && (secondVal < 0) && (thirdVal < 0)) || (((firstVal < 0) && (secondVal > 0) && (thirdVal > 0)) || ((firstVal > 0) && (secondVal < 0) && (thirdVal > 0)) || ((firstVal > 0) && (secondVal > 0) && (thirdVal < 0))))
            {
                Console.WriteLine("The value is -");
            }
            else
            {
                Console.WriteLine("The value is +");
            }
        }
    }
}
