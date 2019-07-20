using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Odeme
    {
        int urunfiyati, urunadeti;
        public Odeme()
        {
            urunfiyati = 0;
            urunadeti = 0;
        }
        public Odeme(int urfyt, int uradet)
        {
            urunfiyati = urfyt;
            urunadeti = uradet;
        }
        public int uruntutari()
        {
            return urunfiyati * urunadeti;               
        }
        public static int kdv(int urtutar)
        {
            return urtutar+= urtutar * 18 / 100;
        }
        public static int odemesekli(int kdvliurtutar,int secilen)
        {
            if (secilen == 0)            
                kdvliurtutar -= kdvliurtutar * 10 / 100;            
            else if (secilen== 1)            
                kdvliurtutar = kdvliurtutar / 12;            
            else if (secilen== 2)            
                kdvliurtutar =  kdvliurtutar / 24;            
            else if (secilen== 3)            
                kdvliurtutar = kdvliurtutar / 36; 
            
            return kdvliurtutar;
        }
    }
}
