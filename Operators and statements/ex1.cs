using System;
namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
		   Console.Write("Enter value: ");
		   int x =ParseInt(Console.ReadLine());
		   if ( x % 2 == 0) {
  Console.WriteLine("the number is even");
 }
  else {
   Console.WriteLine("the number is odd");
  }
		}
    }
}
