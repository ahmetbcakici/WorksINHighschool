using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _775AhmetCakici_Sinav2
{
    class Matematik
    {
        int sayi1, sayi2, sayi3;
        public Matematik() { }
        public Matematik(int s1,int s2,int s3)
        {
            sayi1 = s1;
            sayi2 = s2;
            sayi3 = s3;
        }
        public static int rastgelesayi1()//Aynı geliyordu mecbur 3 metod yaptım hepsini farklı aralık yaptım
        {
            Random rnd = new Random();
            return rnd.Next(1, 4);
        }
        public static int rastgelesayi2()
        {
            Random rnd = new Random();
            return rnd.Next(4, 7);
        }
        public static int rastgelesayi3()
        {
            Random rnd = new Random();
            return rnd.Next(7, 11);
        }
        public int ortalama(int txts1,int txts2,int txts3)
        {
            return (txts1 + txts2 + txts3) / 3;
        }
        public int ortalama()
        {
            return (sayi1 + sayi2 + sayi3) / 3;
        }
        public int enbuyuk()
        {
            if (sayi1 > sayi2 && sayi1 > sayi3)
                return sayi1;
            if (sayi2 > sayi1 && sayi2 > sayi3)
                return sayi2;
            if (sayi3 > sayi1 && sayi3 > sayi2)
                return sayi3;
            return 0;

        }
        public int enkucuk()
        {
            if (sayi1 < sayi2 && sayi1 < sayi3)
                return sayi1;
            else if (sayi2 < sayi1 && sayi2 < sayi3)
                return sayi2;
            else if (sayi3 < sayi1 && sayi3 < sayi2)
                return sayi3;
            else
                return 0;
        }


    }
}
