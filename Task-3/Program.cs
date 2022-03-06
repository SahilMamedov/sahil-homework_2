using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*5 reqemli eded verilib.
             * Bu ededin evvel 18 % sonra ise 3 % tap.
             */

            double a;
            Console.WriteLine("5 reqemli ededi daxil edin");
            a = Convert.ToInt32(Console.ReadLine());
            if (a <10000 || a >99999)
            {
                Console.WriteLine("5 reqemli deyil yazdiqiniz eded");
                return;
            }
            a = a / 100 * 18;
    
            Console.WriteLine(a+   " bu ededin 18% di ");
            a = a / 100 * 3;
            Console.WriteLine(a+    " bu ededin 3% di");



        }
    }
}
