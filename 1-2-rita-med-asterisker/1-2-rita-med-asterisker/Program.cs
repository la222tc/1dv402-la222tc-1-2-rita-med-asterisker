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
                
                if (i % 2 == 1)
                {
                    Console.Write(" ");

                }
                // Om i % 2 är samma som 1 så skrivs ett mellanslag ut innan raden
                switch (i % 3)
                {

                    case 0:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;

                    case 1:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        break;

                    case 2:
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;

                }
                

                for (int j = 0; j < 39; j++)
                {

                    Console.Write("* ");

                }
                Console.WriteLine();

                // Skriver ut (* ) tills j = 39

                

            }

        }
    }
}

                    //case 1:
                    //default:
                    //    {
                    //        if (i % 3 == 0)
                    //        {
                    //            Console.ForegroundColor = ConsoleColor.Yellow;
                    //        }
                    //        else if (i % 3 == 1)
                    //        {
                    //            Console.ForegroundColor = ConsoleColor.Magenta;
                    //        }
                    //        else if (i % 3 == 2)
                    //        {
                    //            Console.ForegroundColor = ConsoleColor.Green;
                    //        }
                    //    }
                    //    break;
                   
                    //case 2:
                    //    if (i % 3 == 1)
                    //    {
                    //        Console.ForegroundColor = ConsoleColor.Magenta;
                    //    }

                    //    break;


                    //case 3:
                    //    if (i % 3 == 2)
                    //    {
                    //        Console.ForegroundColor = ConsoleColor.Green;
                    //    }
                        
                    //    break;
                
                // Använder i och väljer ut de olika värden i får och tilldelar den raden en färg.
                



                //do
                //{
                //    Console.ForegroundColor = ConsoleColor.Yellow;

                //} while (i == 0);
            
