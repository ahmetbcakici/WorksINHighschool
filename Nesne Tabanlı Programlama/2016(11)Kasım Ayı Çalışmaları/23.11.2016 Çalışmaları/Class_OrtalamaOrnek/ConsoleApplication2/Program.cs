using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ad Soyad giriniz:");
            string bilgi = Console.ReadLine();
            Console.Write("1. notunuzu giriniz:");
            int n1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("2. notunuzu giriniz:");
            int n2 = Convert.ToInt16(Console.ReadLine());
            Ortalama nesne = new Ortalama();
            Console.Clear();
            nesne.hesapla(bilgi, n1, n2);
            
            Console.Read();
        }
    }
    class Ortalama
    {
        public void hesapla(string ad,int s1, int s2)
        {
            if ((s1 + s2) / 2 < 50)
            { Console.ForegroundColor = ConsoleColor.Red; }
            else { Console.ForegroundColor = ConsoleColor.Green; }
            Console.WriteLine("Ad Soyad : {0}\nNot1 : {1}\nNot2 : {2}\nOrtalama : {3}", ad, s1, s2, (s1 + s2) / 2);           
        }
    }
}
