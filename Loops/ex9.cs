using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] colours = new string[4] { "clubs", "diamonds", "hearts", "spades" };
            string[] cards = new string[13] { "two", "three", "four", "five", "six", "seven", "eight", "nine","ten", "Jack", "Queen", "King", "Ace" };
            for (int i = 0; i < colours.Length; i++)
            {
                for (int j = 0; j < cards.Length; j++)
                {
                    Console.WriteLine("{0} of {1}", colours[i], cards[j]);
                }
            }
        }
    }
}
