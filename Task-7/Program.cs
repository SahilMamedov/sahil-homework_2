using System;

namespace Task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*2 dene 5 reqemli eded verilib.
                * Bu ededleri toplayib.
                * Alinan cavabin evveline ve axirina 5 artir.
                * Neticenin 5 % tap
                */

            double a,b,c;
            Console.WriteLine("1-ci 5 reqemli ededi daxil edin");
            a = Convert.ToInt32(Console.ReadLine());

          
            Console.WriteLine("2-ci 5 reqemli ededi daxil edin");
            b = Convert.ToInt32(Console.ReadLine());

            if (a < 10000 || a > 99999)
            {

                Console.WriteLine("1-ci yazdiqiniz eded 5 reqemli deyil");
                return;
            }
            if (b < 10000 || b > 99999)
            {

                Console.WriteLine("2-ci yazdiqiniz eded 5 reqemli deyil");
                return;
            }
            c = a + b;
            c = c + 500000;
            c = c * 10 + 5;
            c = c / 100 * 5;

            Console.WriteLine(c);
        }
    }
}
