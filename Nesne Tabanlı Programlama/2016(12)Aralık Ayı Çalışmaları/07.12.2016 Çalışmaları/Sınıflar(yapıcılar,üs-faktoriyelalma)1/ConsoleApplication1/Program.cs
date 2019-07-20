using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Matematik mat = new Matematik();
            Console.Write("İşlem yapılacak sayıyı giriniz:");
            int sayii = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Girdiğiniz sayının faktöriyeli:"+Matematik.faktoriyel(sayii));
            Console.WriteLine();
            Console.Write("Girdiğiniz sayının kaçıncı kuvvetini görmek istiyorsunuz:");
            int kuvvett = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(sayii+" sayısının "+kuvvett+".kuvveti:"+mat.usalma(sayii,kuvvett));
            Console.WriteLine("Yaptığınız işlem sayısı :"+Matematik.sayac);
            Console.Read();
        }
    }
    class Matematik
    {
        int sayi, kuvveti;
        public static int sayac;
        public Matematik()
        {
            sayi = 0;
            kuvveti = 0;
        }
        public Matematik(int s1, int s2)
        {
            sayi = s1;
            kuvveti = s2;
        }
        public int usalma(int a, int b)
        {            
            sayac++;
            int c = 1;
            for (int i = 1; i <= b ; i++)
            {
                c *= a;
            }
            return c;
        }
        public static int faktoriyel(int a)
        {
            sayac++;
            int faktoriyel = 1;
            for (int i = 1; i <= a; i++) 
            {
                faktoriyel *= i;
            }
            return faktoriyel;
        }
    }
}
