using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 3 reqemli eded verilib.
             * Bu ededin axirina hemin ededdin ozunu yapishdir.
             * example: 333= 333333;
            */
            int a;
            Console.WriteLine("3 reqemli ededi daxil edin");
            a = Convert.ToInt32(Console.ReadLine());

            if (a < 100 ||a >999) 
            {
                Console.WriteLine("3 reqemli deyil");
                return;
       
            }
            a = a * 1000 + a;
            Console.WriteLine(a);



        }
    }
}
