using System;

namespace Task_9
{
    class Program
    {
        static void Main(string[] args)
        {
            /*3 dene 6 reqemli eded verilib.
             * Her birinin 10 faizini tapib neticeleri topla.
             * Alinan cavabin 10% tap.
             */
            double a,b,c,cem;

            Console.WriteLine("4 reqemli ededi daxil edin");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("4 reqemli ededi daxil edin");
            b = Convert.ToInt32(Console.ReadLine());
        
            Console.WriteLine("4 reqemli ededi daxil edin");
            c = Convert.ToInt32(Console.ReadLine());

          
            if (a < 100000 || a > 999999)
            {
                Console.WriteLine("1-ci eded 6 reqemli eded deyil");
                return;
            }
            else if (b < 100000 || b > 999999)
            {
                Console.WriteLine("2-ci eded 6 reqemli eded deyil ");
                return;
            }
            else if (c < 100000 || c > 999999)
            {
                Console.WriteLine("3-cu eded 6 reqemli eded deyil ");
                return;
            }

            a = a / 100 * 10;
            b = b / 100 * 10;
            c = c / 100 * 10;
            cem = a + b + c;
            cem = cem / 100 * 10;
            Console.WriteLine(cem);





        }
    }
}
