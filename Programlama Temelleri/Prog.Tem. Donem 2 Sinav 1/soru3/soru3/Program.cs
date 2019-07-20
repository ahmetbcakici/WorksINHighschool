using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace soru3
{
    class Program
    {
        static void Main(string[] args)
        {
            int carpim =0;
            Console.Write("Başlangıç değeri girin:");
            int basla = Convert.ToInt16(Console.ReadLine());
            Console.Write("Bitiş değeri girin:");
            int son = Convert.ToInt16(Console.ReadLine());
            for (int i = basla; i <= son; i++)
            {
                Console.WriteLine("{0} ler",i);
                for (int j = 10; j >= 1; j--) 
                {
                    
                    carpim = i*j;
                    Console.WriteLine("{0} x {1} = {2}", i, j, carpim);
                }
                Console.WriteLine("------");
            }
            Console.ReadKey();


        }
    }
}
