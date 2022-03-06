using System;

namespace Task_10
{
    class Program
    {
        static void Main(string[] args)
        {
            /*   3 dene 4 reqemli eded verilib.
                    I ededin 1%-ni, II ededin 2% , III ededin 3 % tap.
                    Neticeleri bir birinden cix. Alinan cavabin ustune III ededin 7% faizini gel*/

            double a, b, c, d, sum;

            Console.WriteLine("1-ci 4 reqemli ededi daxil edin");
            a = Convert.ToInt32(Console.ReadLine());
           
           
            Console.WriteLine("2-ci 4 reqemli ededi daxil edin");
           b = Convert.ToInt32(Console.ReadLine());
          
         
            Console.WriteLine("3-cu 4 reqemli ededi daxil edin");
            c = Convert.ToInt32(Console.ReadLine());
          
           
            
          if  ( a < 1000 || a > 9999 || b < 1000 || b > 9999 || c < 1000 || c > 9999)
            {
                Console.WriteLine(" 1, 2, veya 3-cu Eded 4 reqemli deyil");
                return;
            }



            a = a / 100 * 1;
            d = c / 100 * 7;
            b = b / 100 * 2;
            c = c / 100 * 3;
            sum = a - b - c;
  
            sum = sum + d;
            Console.WriteLine(sum);




       





        }
    }
}
