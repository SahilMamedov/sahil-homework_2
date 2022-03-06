using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             4 reqemli eded verilib. 
            Bu ededin eveline 7 reqemini ,
            axirinada 8 reqemini artir. Example1: 333= 73338
             */
            int a;
            Console.WriteLine("4 reqemli ededi daxil edin");
            a = Convert.ToInt32(Console.ReadLine());
            
            if (a < 1000 || a > 9999)
            {
                Console.WriteLine("4 reqemli deyil");
                return;
            }
            
            a = a + 70000;
            a = a * 10 + 8;
            Console.WriteLine(a);
           





        }
    }
}
