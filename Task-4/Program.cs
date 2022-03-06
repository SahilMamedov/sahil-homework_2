using System;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*3 reqemli eded verilib.
             * Bu ededin axirina 7 artir.
             * Sonra cavabin 7% tap;
             */
            double a;
            Console.WriteLine("3 reqemli ededi daxil edin");
            a = Convert.ToInt32(Console.ReadLine());
            if (a < 100 || a >= 1000)
            {
                Console.WriteLine("3 reqemli deyil yazdiqiniz eded");
                return;
            }
            a = a * 10 + 7;
            a = a / 100 * 7;



            Console.WriteLine(a);
    





        }
    }
}
