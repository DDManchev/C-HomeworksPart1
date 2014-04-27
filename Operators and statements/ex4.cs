using System;
namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
		   Console.Write("Enter value a: ");
		   int a = ParseInt(Console.ReadLine());
		   a  = a/100;
		   if(a % 10 == 7) {
 Console.WriteLine( "Третата цифра е 7");
}
 else {
  Console.WriteLine("Третата не е цифра е 7");
} 
		}
    }
}