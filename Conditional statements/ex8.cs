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
            int choice = Int32.Parse(Console.ReadLine());
            switch (choice)
            {
                    case 1: Console.Write("Enter integer: ");
                    int a = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Integer value increased with 1" + (a + 1));
                    break;
                    case 2: Console.Write("Enter double: ");
                    double b = Double.Parse(Console.ReadLine());
                    Console.WriteLine("Integer value increased with 1" + (b + 1));
                    break;
                    case 3: Console.Write("Enter sting: ");
                    string c = Console.ReadLine();
                    Console.WriteLine("Integer value increased with 1" + (c + '*'));
                    break;
            }
        }
    }
}
