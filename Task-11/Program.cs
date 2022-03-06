using System;

namespace Task_11
{
    class Program
    {
        static void Main(string[] args)
        {
            /*   4 dene 5 reqemli eded verilib.
                 I ededin ustune III ededi gel .
                 II ededin usutune IV eeddi gel.
                Sonra cavablari vur birbirine.
                Alinan neticeden III ededin 3%-ni cix.
          */

            double a, b, c,d,e,sum;

            Console.WriteLine("5 reqemli ededi daxil edin");
            a = Convert.ToInt32(Console.ReadLine());
          
            Console.WriteLine("5 reqemli ededi daxil edin");
            b = Convert.ToInt32(Console.ReadLine());
           
            Console.WriteLine("5 reqemli ededi daxil edin");
            c = Convert.ToInt32(Console.ReadLine());
           
            Console.WriteLine("5 reqemli ededi daxil edin");
            d = Convert.ToInt32(Console.ReadLine());


          
            if (a < 10000 || a > 99999)
            {
                Console.WriteLine("Yazdiqiniz 1-ci ededi 5 reqemli deyil");
                return;
                    
            }
            else if (b < 10000 || b > 99999)
            {
                Console.WriteLine("Yazdiqiniz 2-ci ededi 5 reqemli deyil");
                return;
            }
            else if (d < 10000 || d > 99999)
            {
                Console.WriteLine("Yazdiqiniz 3-cu ededi 5 reqemli deyil");
                return;
            }
            else if (c < 10000 || c > 99999)
            {
                Console.WriteLine("Yazdiqiniz 4-cu ededi 5 reqemli deyil");
                return;
            }



            e = c / 100 * 3;
            a = a + c;
            b = b + d;
            sum = b * a;
            sum = sum - e;

            Console.WriteLine(sum);
       
          



        }
    }
}
