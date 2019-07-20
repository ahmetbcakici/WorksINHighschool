using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication4
{
    class Matematik
    {
        public static int sayac;
        int s1, s2;
        public Matematik()
        {
            s1 = 0;
            s2 = 0;
        }
        public Matematik(int dgr1, int dgr2)
        {
            s1 = dgr1;
            s2 = dgr2;
        }
        public int faktoriyel()
        {
            int fkt = 1;
            for (int i = 1; i <= s1; i++)
            {
                fkt *= i;
            }
            return fkt;
        }
        public int usalma()
        {
            int c = 1;
            for (int i = 1; i <=s2; i++)
            {
                c *= s1;
            }
            return c;
        }
    }
}
