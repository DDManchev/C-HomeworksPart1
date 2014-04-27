using System;
 
class ex10
{
    static void Main()
    {
        // Catalan formula =  (2n)! / (n + 1)! * n!
 
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());

        int totalSum;
        decimal product2n = 1;
        decimal productn = 1;
        decimal product_n_1 = 1;
 
        for (int i = 1; i <= 2*n; i++)
        {
           product2n *= i;
        }
        for (int i = 1; i <= n; i++)
        {
            productn *= i;
        }
        for (int i = 1; i <= n + 1; i++)
        {
            product_n_1 *= i;
        }
        totalSum = product2n / (productn * product_n_1);
            Console.WriteLine("(2n)! / (n + 1)! * n! = {0}", product);
    }
}
   