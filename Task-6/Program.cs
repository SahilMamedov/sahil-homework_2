using System;

namespace Task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*     4 reqemli eded verilib.
                   Bu ededin evvel 20%-ni ,
                   sonra ise cavabin 10% tap.
                   Alinan cavabin kvadratini tap.
            */

            double a;
            Console.WriteLine("4 reqemli ededi daxil edin");
            a = Convert.ToInt32(Console.ReadLine());

            if (a <1000 || a > 9999)
            {
                Console.WriteLine("Yazdiqiniz eded 4 reqemli deyil");
            }

            a = a / 100 * 20;
            a = a / 100 * 10;
            a = a * a;

            Console.WriteLine(a);








        }
    }
}
