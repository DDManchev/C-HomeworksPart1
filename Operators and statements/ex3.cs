using System;
namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
		   Console.Write("Enter value a: ");
		   int a =ParseInt(Console.ReadLine());
		   int b =ParseInt(Console.ReadLine());
		   int RectArea = a * b;
		   Console.WriteLine(RectArea);
		}
    }
}