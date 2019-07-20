using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication2
{
    class Islem
    {
        public static int sayac;    
        public static int topla(int s1, int s2)
        {
            sayac++;
            return s1 + s2;
        }
        public static int cikar(int s1, int s2)
        {
            sayac++;
            return s1 - s2;
        }
        public static int carp(int s1, int s2)
        {
            sayac++;
            return s1 * s2;
        }
        public static int bol(int s1, int s2)
        {
            sayac++;
            return s1 / s2;
        }
    }
}
