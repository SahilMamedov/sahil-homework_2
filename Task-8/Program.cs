using System;

namespace Task_8
{
    class Program
    {
        static void Main(string[] args)
        {
            /*        2 dene eded verilib. I eded 4 reqemli II eded 7 reqemlidir.
                      I ededin 4%-ni tap.
                      Sonra II ededin 9% ni tap.
                      Sonra Cavalari toplayib 10 %ni tap.*/

            double a ;
            Console.WriteLine("4 reqemli ededi daxil edin");
            a = Convert.ToInt32(Console.ReadLine());

            double b; Console.WriteLine("7 reqemli ededi daxil edin");
            b = Convert.ToInt32(Console.ReadLine()); ;

            double c;
            if (a < 1000 || a > 9999)
            {
                Console.WriteLine("1-ci yazdiqiniz eded 4 reqemli deyil");
                return;
            }
            else if (b < 1000000 || b > 9999999)
            {
                Console.WriteLine("2-ci Yazdiqiniz eded 7 reqemli deyil");
                return;
            }
            a = a / 100 * 4;
            b = b / 100 * 9;
            c = a + b;
            c = c / 100 * 10;
            Console.WriteLine(c);









        }
    }
}
