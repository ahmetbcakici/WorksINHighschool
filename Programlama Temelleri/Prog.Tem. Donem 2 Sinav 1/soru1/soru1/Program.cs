using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace soru1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1-cm-->inç");
            Console.WriteLine("2-inç-->cm");
            Console.Write("Seçiminiz:");
            int secim = Convert.ToInt16(Console.ReadLine());
            switch (secim)
            {
                case 1:
                    Console.Write("Uzunluğu giriniz:");
                    int uzunluk = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("{0} cm = {1} inç", uzunluk, uzunluk / 2.54);
                    break;
                case 2:
                    Console.Write("Uzunluğu giriniz:");
                    int x = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("{0} inç = {1} cm", x, x * 2.54);
                    break;
                default:
                    Console.WriteLine("Hatalı seçim");
                    break;

            }
            Console.ReadKey();           

        }
    }
}
