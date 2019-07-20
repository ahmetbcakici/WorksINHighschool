using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace soru2
{
    class Program
    {
        static void Main(string[] args)
        {
            int toplam = 0;
            Console.Write("Sayı giriniz:");
            int sayi = Convert.ToInt16(Console.ReadLine());
            for (int i = sayi; i <= 100; i++) 
            {
                if ((i % 2) == 0 && (i % 5) == 0)
                {
                    
                    toplam = toplam + i;
                    Console.WriteLine(i);
                }                
            }
            Console.WriteLine("Toplam = {0}",toplam);
            Console.WriteLine("Bitti");
            Console.ReadKey();

        }
    }
}
