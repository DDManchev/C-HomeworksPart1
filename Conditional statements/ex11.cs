using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Statements
{
    class Program
    {
          public static  string stotici;
            public static  string edinici;
            public static  string desetici;
    
        static void Main(string[] args)
        {
            int number = Int32.Parse(Console.ReadLine());
            int stoticata = number / 100;
            int deseticata = ((number / 10)) % 10;
            int edinicata = number % 10;
            if (number < 20)
            {
                switch (number)
                {
                    case 0: Console.WriteLine("zero"); break;
                    case 1: Console.WriteLine("one"); break;
                    case 2: Console.WriteLine("two"); break;
                    case 3: Console.WriteLine("three"); break;
                    case 4: Console.WriteLine("four"); break;
                    case 5: Console.WriteLine("five"); break;
                    case 6: Console.WriteLine("six"); break;
                    case 7: Console.WriteLine("seven"); break;
                    case 8: Console.WriteLine("eight"); break;
                    case 9: Console.WriteLine("nine"); break;
                    case 10: Console.WriteLine("ten"); break;
                    case 11: Console.WriteLine("eleven"); break;
                    case 12: Console.WriteLine("twelve"); break;
                    case 13: Console.WriteLine("thirteen"); break;
                    case 14: Console.WriteLine("fourteen"); break;
                    case 15: Console.WriteLine("fifteen"); break;
                    case 16: Console.WriteLine("sixteen"); break;
                    case 17: Console.WriteLine("seventeen"); break;
                    case 18: Console.WriteLine("eighteen"); break;
                    case 19: Console.WriteLine("nineteen"); break;
                }
            }

            else if ((number >= 20) && (number <= 999))
            {
                if (stoticata == 0)
                {
                    if (edinicata != 0)
                    {
                        switch (number / 10)
                        {
                            case 1: desetici = "ten"; break;
                            case 2: desetici = "twenty"; break;
                            case 3: desetici = "thirty "; break;
                            case 4: desetici = "fourty "; break;
                            case 5: desetici = "fifty "; break;
                            case 6: desetici = "sixty "; break;
                            case 7: desetici = "seventy "; break;
                            case 8: desetici = "eighty "; break;
                            case 9: desetici = "ninety "; break;

                        }
                        switch (edinicata)
                        {
                            case 1: edinici = "one"; break;
                            case 2: edinici = "two "; break;
                            case 3: edinici = "three "; break;
                            case 4: edinici = "four "; break;
                            case 5: edinici = "five "; break;
                            case 6: edinici = "six "; break;
                            case 7: edinici = "seven "; break;
                            case 8: edinici = "eight "; break;
                            case 9: edinici = "nine "; break;
                        }
                        Console.WriteLine("The result is : {0} {1} " ,desetici,edinici);
                    }
                }
                else if (stoticata != 0)
                {


                    if ((deseticata != 0) && (edinicata != 0))
                    {
                        if (deseticata != 1)
                        {

                            switch (stoticata)
                            {
                                case 1: stotici = "one hundred"; break;
                                case 2: stotici = "two hundred"; break;
                                case 3: stotici = "three hundred"; break;
                                case 4: stotici = "four hundred"; break;
                                case 5: stotici = "five hundred"; break;
                                case 6: stotici = "six hundred"; break;
                                case 7: stotici = "seven hundred"; break;
                                case 8: stotici = "eight hundred"; break;
                                case 9: stotici = "nine hundred"; break;
                            }

                            switch (deseticata)
                            {
                                case 2: desetici = "twenty"; break;
                                case 3: desetici = "thirty "; break;
                                case 4: desetici = "fourty "; break;
                                case 5: desetici = "fifty "; break;
                                case 6: desetici = "sixty "; break;
                                case 7: desetici = "seventy "; break;
                                case 8: desetici = "eighty "; break;
                                case 9: desetici = "ninety "; break;

                            }
                            switch (edinicata)
                            {
                                case 1: edinici = "one"; break;
                                case 2: edinici = "two "; break;
                                case 3: edinici = "three "; break;
                                case 4: edinici = "four "; break;
                                case 5: edinici = "five "; break;
                                case 6: edinici = "six "; break;
                                case 7: edinici = "seven "; break;
                                case 8: edinici = "eight "; break;
                                case 9: edinici = "nine "; break;
                            }
                            Console.WriteLine("The result is " + stotici + " " + desetici + " " + edinici);
                        }

                        else if (deseticata == 1)
                        {
                            switch (stoticata)
                            {
                                case 1: stotici = "one hundred"; break;
                                case 2: stotici = "two hundred"; break;
                                case 3: stotici = "three hundred"; break;
                                case 4: stotici = "four hundred"; break;
                                case 5: stotici = "five hundred"; break;
                                case 6: stotici = "six hundred"; break;
                                case 7: stotici = "seven hundred"; break;
                                case 8: stotici = "eight hundred"; break;
                                case 9: stotici = "nine hundred"; break;
                            }
                            switch (edinicata)
                            {
                                case 0: edinici = "ten"; break;
                                case 1: edinici = "eleven"; break;
                                case 2: edinici = "twelve"; break;
                                case 3: edinici = "thirteen "; break;
                                case 4: edinici = "fourteen "; break;
                                case 5: edinici = "fifteen "; break;
                                case 6: edinici = "sixteen "; break;
                                case 7: edinici = "seventeen "; break;
                                case 8: edinici = "eighteen "; break;
                                case 9: edinici = "nineteen "; break;
                            }
                            Console.WriteLine("The result is " + stotici + " " + edinici);
                        }

                    }

                    else if ((deseticata != 0) && (edinicata == 0))
                    {
                        switch (stoticata)
                        {
                            case 1: stotici = "one hundred"; break;
                            case 2: stotici = "two hundred"; break;
                            case 3: stotici = "three hundred"; break;
                            case 4: stotici = "four hundred"; break;
                            case 5: stotici = "five hundred"; break;
                            case 6: stotici = "six hundred"; break;
                            case 7: stotici = "seven hundred"; break;
                            case 8: stotici = "eight hundred"; break;
                            case 9: stotici = "nine hundred"; break;
                        }

                        switch (deseticata)
                        {
                            case 1: desetici = "ten"; break;
                            case 2: desetici = "twenty"; break;
                            case 3: desetici = "thirty "; break;
                            case 4: desetici = "fourty "; break;
                            case 5: desetici = "fifty "; break;
                            case 6: desetici = "sixty "; break;
                            case 7: desetici = "seventy "; break;
                            case 8: desetici = "eighty "; break;
                            case 9: desetici = "ninety "; break;

                        }
                        Console.WriteLine("The result is " + stotici + " and " + desetici);
                    }

                    else if ((deseticata == 0) && (edinicata != 0))
                    {
                        switch (stoticata)
                        {
                            case 1: stotici = "one hundred"; break;
                            case 2: stotici = "two hundred"; break;
                            case 3: stotici = "three hundred"; break;
                            case 4: stotici = "four hundred"; break;
                            case 5: stotici = "five hundred"; break;
                            case 6: stotici = "six hundred"; break;
                            case 7: stotici = "seven hundred"; break;
                            case 8: stotici = "eight hundred"; break;
                            case 9: stotici = "nine hundred"; break;
                        }
                        switch (edinicata)
                        {
                            case 1: edinici = "one"; break;
                            case 2: edinici = "two "; break;
                            case 3: edinici = "three "; break;
                            case 4: edinici = "four "; break;
                            case 5: edinici = "five "; break;
                            case 6: edinici = "six "; break;
                            case 7: edinici = "seven "; break;
                            case 8: edinici = "eight "; break;
                            case 9: edinici = "nine "; break;
                        }
                        Console.WriteLine("The result is " + stotici + " and " + edinici);
                    }

                }
            }
        }
    }
}
