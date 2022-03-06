using System;

namespace Task_14
{
    class Program
    {
        static void Main(string[] args)
        {

            /*             6 dene 6 reqemli eded verilib.
                           Evvel hamisini topla .
                           Sonra I ve III ededi bir birine yapishdir ve bir eded al.
                           I neticeden II neticeni cix.
                           Alinan cavabin 10% tap.
                           Neticenin uzerine V ve VI ededleri gel.
                           Yekunda alinan cavabin 11% tap.*/
            
            double a, b, c, d, e, z;
            double sum, sum1, sum2;


            Console.WriteLine("1-ci 6 reqemli ededi daxil edin");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("2-ci 6 reqemli ededi daxil edin");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("3-cu 6 reqemli ededi daxil edin");
            c = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("4-cu 6 reqemli ededi daxil edin");
            d = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("5-ci 6 reqemli ededi daxil edin");
            e = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("6-ci 6 reqemli ededi daxil edin");
            z = Convert.ToDouble(Console.ReadLine());





            if (a < 100000 || a > 999999)
            {
                Console.WriteLine("Yazdiqiniz eded 6 reqemli deyil");
                return;
            }
            

            else if (b < 100000 || b > 999999)
            {
                Console.WriteLine("2-ci eded 6 reqemli deyil");
                return;
            }

            else if (c < 100000 || c > 999999)
            {
                Console.WriteLine("3-cu eded 6 reqemli deyil");
                return;
            }
            else if (d < 100000 || d > 999999)
            {
                Console.WriteLine("4-cu eded 6 reqemli deyil");
                return;
            }
            else if (e < 100000 || e > 999999)
            {
                Console.WriteLine("5-ci eded 6 reqemli deyil");
                return;
            }
            else if (z < 100000 || z > 999999)
            {
                Console.WriteLine("6-ci eded 6 reqemli deyil");
                return;
            }
            /*             6 dene 6 reqemli eded verilib.
                           Evvel hamisini topla .
                           Sonra I ve III ededi bir birine yapishdir ve bir eded al.
                           I neticeden II neticeni cix.
                           Alinan cavabin 10% tap.
                           Neticenin uzerine V ve VI ededleri gel.
                           Yekunda alinan cavabin 11% tap.*/

            sum = a + b + c + d + e + z;

                sum1 = a * 1000000 + c;

                sum2 = sum - sum1;

                sum2 = sum2 / 100 * 10;

                sum2 = sum2 + e + z;

                sum2 = sum2 / 100 * 11;



                Console.WriteLine(sum2);



            
        }
    }
}
