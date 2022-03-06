using System;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 4 reqemli eded verilib.
             * Bu ededin evveline 4 reqemi ,
             * axirina ise 44 ededini artir.
             * Alinan cavabin 44 % tap.
             */

            double a;
            Console.WriteLine("4 reqemli ededi daxil edin");
            a = Convert.ToInt32(Console.ReadLine());

            if (a <1000 || a > 9999 )
            {
                Console.WriteLine("Eded 4 reqemli deyil");
                return;
            }

            a = a + 40000;
            a = a * 100 + 44;
            a = a / 100 * 44;
            Console.WriteLine($"{a} Bu ededin 44 faizidir.");








        }
    }
}
