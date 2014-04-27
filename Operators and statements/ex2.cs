using System;
namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
		   Console.Write("Enter value: ");
		   int x =ParseInt(Console.ReadLine());
		   if ( x % 35 == 0) {
  Console.WriteLine("the number can be divided by 5 and 7");
 }
  else {
   Console.WriteLine("the number cannot be divided by 5 and 7");
  }
		}
    }
}
