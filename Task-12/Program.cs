using System;

namespace Task_12
{
    class Program
    {
        static void Main(string[] args)
        {
            /*       4 dene 6 reqemli eded verilib.
                     Ededlerin hamisinin 10 faizini tap ve topla.
                     Sonra hamisinin 15 faizini tap ve topla.
                     Sonra yekunda alinanlar iki cavabi vur biri birine.
                     Alinan neticenin evvel 10% tap sonra ise hemin cavabin 11% tap.*/

            double a,b,c,d;
            double sum, sum1, sum2, sum3;
            double a1, b1, c1, d1;

            Console.WriteLine("1-ci 6 reqemli ededi daxil edin");
            a = Convert.ToInt32(Console.ReadLine());
              
            Console.WriteLine("2-ci 6 reqemli ededi daxil edin");
            b = Convert.ToInt32(Console.ReadLine());
           
            Console.WriteLine("3-cu 6 reqemli ededi daxil edin");
            c = Convert.ToInt32(Console.ReadLine());
         
            Console.WriteLine("4-cu 6 reqemli ededi daxil edin");
            d = Convert.ToInt32(Console.ReadLine());
           

            if (a < 100000 || a > 999999)
            {
                Console.WriteLine(" Yazdiqiniz eded 6 reqemli deyil");
            }
            else if (b < 100000 || b > 999999)
            {
            }
            else if (d < 100000 || d > 999999)
            {
                Console.WriteLine("Yazdiqiniz D ededi 5 reqemli deyil");
                return;
            }
            else if (c < 100000 || c > 999999)
            {
                Console.WriteLine("Yazdiqiniz C ededi 5 reqemli deyil");
                return;
            }



            a1 = a / 100 * 10;
            b1 = b / 100 * 10;
            c1 = c / 100 * 10;
            d1 = d / 100 * 10;

            sum = a1 + b1 + c1 + d1;

            a = a / 100 * 15;
            b = b / 100 * 15;
            c = c / 100 * 15;
            d = d / 100 * 15;

            sum1 = a + b + c + d;

            sum2 = sum1 * sum;
            sum3 = sum2 / 100 * 10;
            sum3 = sum3 / 100 * 11;

            Console.WriteLine(sum3);









        }
    }
}
