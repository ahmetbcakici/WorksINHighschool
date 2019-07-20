using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        public static int EnKucukBul(params int[] deneme)
        {
            int enkucuk = deneme[0];
            for (int i = 0; i < deneme.Length; i++) 
            {
                if (deneme[i] < enkucuk)
                    enkucuk = deneme[i];
            }
            return enkucuk;
        }
        public static int EnBuyukBul(params int[] deneme)
        {
            int enbuyuk = deneme[0];
            for (int i = 0; i < deneme.Length; i++)
            {
                if (deneme[i] > enbuyuk)
                    enbuyuk = deneme[i];
            }
            return enbuyuk;
        }
        public static int SayilariTopla(params int[] deneme)
        {
            int toplam = 0;
            for (int i = 0; i < deneme.Length; i++)
            {
                toplam += deneme[i];
            }
            return toplam;
        }
        static void Main(string[] args)
        {
            int enkucuk = EnKucukBul(21, 13, 7, 210, 8, 9, 10);
            int enbuyuk = EnBuyukBul(21, 13, 7, 210, 8, 9, 10);
            int toplam = SayilariTopla(10, 20, 30, 40, 50, 60, 70);
            Console.WriteLine(enkucuk);
            Console.WriteLine(enbuyuk);
            Console.WriteLine(toplam);
            Console.Read();
        }
    }
}
