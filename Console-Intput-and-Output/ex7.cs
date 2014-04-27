using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Input_and_Output
{
    class Program
    {
        static void Main(string[] args)
        {
           int sum = 0;
 
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {

            int input = int.Parse(Console.ReadLine());

            sum += input;
        }
        }
    }
}
