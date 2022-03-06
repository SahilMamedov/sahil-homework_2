using System;

namespace Task_13
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  5 dene eded verilib.
                Bunlardan 3 denesi 5 reqemli. 2 denesi ise 3 reqemlidir.
                5 reqemli ededlerin 5% tap ,neticeleri vur bir birine.
                Sonra 3 reqemli ededlerin 3% tap ,neticeleri topla.
                Sonra yekunda alinan iki cavalarin her birinin 10%-ni tapib topla.*/

            double a, b, c, d, e;
            double sum, sum1, sum2,sum3;

            Console.WriteLine("1-ci 5 reqemli ededi daxil edin");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("2-ci 5 reqemli ededi daxil edin");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("3-cu 5 reqemli ededi daxil edin");
            c = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("4-cu 3 reqemli ededi daxil edin");
            d = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("5-ci 3 reqemli ededi daxil edin");
            e = Convert.ToDouble(Console.ReadLine());


          if(a < 10000 ||a > 99999 || b < 10000 || b > 99999 || c < 10000 || c > 99999)
            {
                Console.WriteLine("yazdiqiniz 1-ci 2-ci veya 3-cu eded 5 reqemli deyil");
                return;
            }
        else if (d < 100 || d > 999 || e < 100 || e > 999 )
            {
                Console.WriteLine("yazdiqiniz 1-ci veya 2-ci eded 3 reqemli deyil");
                return;
            }

            /*  5 dene eded verilib.
                  Bunlardan 3 denesi 5 reqemli. 2 denesi ise 3 reqemlidir.
                  5 reqemli ededlerin 5% tap ,neticeleri vur bir birine.
                  Sonra 3 reqemli ededlerin 3% tap ,neticeleri topla.
                  Sonra yekunda alinan iki cavalarin her birinin 10%-ni tapib topla.*/

            a = a / 100 * 5;
            b = b / 100 * 5;
            c = c / 100 * 5;

            sum = a * b * c;

            d = d / 100 * 3;
            e = e / 100 * 3;

            sum1 = d + e;

            sum = sum / 100 * 10;
            sum1 = sum1 / 100 * 10;
            sum3 = sum1 + sum;

            Console.WriteLine(sum3);







        }
    }
}
