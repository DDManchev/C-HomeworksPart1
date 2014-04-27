using System;
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
            int p1 = 3;
            int p2 = 23;
            Console.Write("Enter a number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int firstThreeBits;
            int secondThreeBits;
            int mask1 = 7<<p1;
            int mask2 = 7<<p2;
            int nAndMask1 =  a & mask1;
            int nAndMask2 =  a & mask2;
            firstThreeBits = nAndMask1 >> p1;
            secondThreeBits = nAndMask2 >> p2;
            firstThreeBits <<= p2;
            secondThreeBits <<= p1;
            int negMask1 = ~(1 << p1);
            int negMasK2 = ~(1 << p2);
            int result = a & negMask1;
            result = a & negMasK2;
            result |= firstThreeBits;
            result |= secondThreeBits;
        }
    }
}
