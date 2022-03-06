using System;

namespace Task_15
{
    class Program
    {
        static void Main(string[] args)
        {
            /*             7 dene eded verilib.Bunlardan 2 denesi 3 reqemlidir. 2 denesi 4 reqemlidir. 2 denesi 5 reqemlidir.1 denesi ise 6 reqemlidir.
                           3 reqemli ededleri topla , sonra bunlarin ustune gel 4 reqemli ededlerin bir birine vurulmasindan alinan cavabi.
                           Sonra neticenin axirina 7 reqemini artir. Sonra cavabin ustune gel 5 reqemli ededlerin cemini.
                           Sonra neticeden cix 3 reqemli ededlerin bir birine vurulmasindan alinan cavabin axirina 1 artirilmish variantini.
                           Sonra alinan cavabin ustune gel 6 reqemli ededi.
                           Sonra alinan cavabdan cix 3 reqemli ve 4 reqemli ededlerin cemini.
                           Sonra alinan cavabin 18% -ni sonra 3%-ni sonra 1% tap.
                           Sonra alinan cavabin ustune 5 reqemli ededlerin cemini gel.*/



            double a, b, c, d, e,z, f;
            double sum, sum1, sum2,sum3,sum4,sum5;

            Console.WriteLine("1-ci 3 reqemli ededi daxil edin");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("2ci 3 reqemli ededi daxil edin");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("3-cu 4 reqemli ededi daxil edin");
            c = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("4-cu 4 reqemli ededi daxil edin");
            d = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("5-ci 5 reqemli ededi daxil edin");
            e = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("6-ci 5 reqemli ededi daxil edin");
            z = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("7-ci 6 reqemli ededi daxil edin");
            f = Convert.ToDouble(Console.ReadLine());

            if(a < 100 ||a > 999 || b < 100 || b > 999)
            {
                Console.WriteLine("1-ci veya 2ci yazdiqiniz eded 3 reqemli deyil");
            }
            else if (c < 1000 || c > 9999 || d < 1000 || d > 9999)
            {
                Console.WriteLine("3-cu veya 4-cu yazdiqiniz eded 4 reqemli deyil");
            }
            else if (e < 10000 || e > 99999 || z < 10000 || z > 99999)
            {
                Console.WriteLine("5-ci veya 6-ci yazdiqiniz eded 5 reqemli deyil");
            }
            else if (f < 100000 || f > 999999)
            {
                Console.WriteLine("7-ci yazdiqiniz eded 6 reqemli deyil");
            }

         

            sum = a + b ;

            sum1 = c * d;

            sum = sum + sum1;

            sum = sum * 10 + 7;

            sum2 = e + z;

            sum = sum + sum2;

            sum3 = a * b;

            sum3 = sum3 * 10 + 1;

            sum = sum - sum3;

            sum = sum + f;

            sum4 = a + b + c + d;

            sum = sum - sum4;

            sum = sum / 100 * 18;

            sum = sum / 100 * 3;

            sum = sum / 100 * 1;

     

            sum = sum + sum2;


            Console.WriteLine($" Alinan     {sum}");










        }
    }
}
