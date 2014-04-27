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
            int a = ParseInt(Console.ReadLine());
            int b = ParseInt(Console.ReadLine()); ;
            int h = ParseInt(Console.ReadLine()); ;
            int area = ((a + b) / 2) * h;
            Console.WriteLine("Лицето на трапеца е: {0} ",area);
        }
    }
}
