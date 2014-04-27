using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isPrime = true;
            int num = ParseInt(Console.ReadLine());
            for (var i = 2; i < Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
            {
                Console.WriteLine("Въведеното число е просто");
            }
            else
            {
                Console.WriteLine("Въведеното число не е просто");
            }
        }
    }
}
