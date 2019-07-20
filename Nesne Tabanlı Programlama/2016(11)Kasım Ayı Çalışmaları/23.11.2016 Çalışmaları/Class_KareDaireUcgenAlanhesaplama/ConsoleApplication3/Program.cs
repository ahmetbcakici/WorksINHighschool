using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {            
            Alan hesaplama = new Alan();
            Console.Write("Kare\nDaire\nÜçgen \nhangisini hesaplamak istersiniz?:");
            string secim = Console.ReadLine().ToLower();
            Console.Clear();
            if (secim == "daire")
            {
                Console.Write("Daire yarı çapı giriniz:");
                int dairecapi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Sonuç: "+hesaplama.daire(dairecapi));
            }
            else if (secim == "kare")
            {
                Console.Write("Kare kenarı giriniz:");
                int karekenar = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Sonuç: "+hesaplama.kare(karekenar));
            }
            else if (secim == "üçgen")
            {
                Console.Write("Yükseklik giriniz:");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Taban giriniz:");
                int y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Sonuç: "+hesaplama.ucgen(x,y));
            }
            Console.Read();
        }
    }
    class Alan
    {
        public double daire(double a)
        {
            return Math.PI * a * a;
        }
        public int kare(int a)
        {
            return a * a;
        }
        public int ucgen(int a,int b)
        {
            return a * b;
        }
    }
}