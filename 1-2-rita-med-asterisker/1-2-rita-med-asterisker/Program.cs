using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_2_rita_med_asterisker
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i < 25; i++)
            {

                if (i == 1 || i == 3 || i == 5 || i == 7 || i == 9 || i == 11 || i == 13 || i == 15 || i == 17 || i == 19 || i == 21 || i == 23 || i == 25)
                {
                    Console.Write(" ");

                }


                for (int j = 0; j < 39; j++)
                {

                    Console.Write("* ");

                }
                Console.WriteLine();

                switch (i)
                {
                    case 0:
                    case 3:
                    case 6:
                    case 9:
                    case 12:
                    case 15:
                    case 18:
                    case 21:
                    case 24:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    case 1:
                    case 4:
                    case 7:
                    case 10:
                    case 13:
                    case 16:
                    case 19:
                    case 22:
                    case 25:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        break;
                    case 2:
                    case 5:
                    case 8:
                    case 11:
                    case 14:
                    case 17:
                    case 20:
                    case 23:
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                }

                

                //do
                //{
                //    Console.ForegroundColor = ConsoleColor.Yellow;

                //} while (i == 0);
            }
            
        }
    }
}
