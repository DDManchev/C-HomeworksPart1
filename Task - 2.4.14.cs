using System;
 
class SubSetSum
{
    static void Main()
    {
        Console.WriteLine("Enter the wanted subset sum");
        int wantedSum = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the number of elements:");
        int numels = int.Parse(Console.ReadLine());
        int[] elements = new int[numels];
        int counter = 0;
        string subset = "";
        for (int i = 0; i < elements.Length; i++)
        {
            Console.WriteLine("Enter element Number: {0}", i + 1);
            elements[i] = int.Parse(Console.ReadLine());
        }
        int maxSubsets = (int)Math.Pow(2, numels) - 1;
        for (int i = 1; i <= maxSubsets; i++)
        {
            subset = "";
            int checkingSum = 0;
            for (int j = 0; j <= numels; j++)
            {
                int mask = 1 << j;
                int nAndMask = i & mask;
                int bit = nAndMask >> j;
                if (bit == 1)
                {
                    checkingSum = checkingSum + elements[j];
                    subset = subset + " " + elements[j];
                }
            }
            if (checkingSum == wantedSum)
            {
                Console.WriteLine("Number of subest that have the sum of {0}", wantedSum);
                counter++;
                Console.WriteLine("This subset has a sum of {0} : {1} ", wantedSum, subset);
            }
        }
        Console.WriteLine(counter);
    }
}