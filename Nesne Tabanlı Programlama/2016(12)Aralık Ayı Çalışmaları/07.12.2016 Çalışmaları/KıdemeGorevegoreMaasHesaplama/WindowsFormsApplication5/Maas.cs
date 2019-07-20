using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication5
{
    class Maas
    {
        string gorev, adsoyad; int kidem, maas;
        
        public Maas(string grv,string adsyd,int kdm)
        {
            gorev = grv;
            kidem = kdm;
            adsoyad = adsyd;
        }
        public int hesapla()
        {
            if (gorev == "Memur")
                maas = 2000;
            else if (gorev == "Şef")
                maas = 2750;
            else if (gorev == "Müdür")            
                maas = 4000;            
            if (kidem > 0 && kidem < 5)            
                maas += maas * 5 / 100;            
            else if (kidem >= 5 && kidem < 10)            
                maas += maas * 7 / 100;            
            else if (kidem >= 10 && kidem < 15)             
                maas += maas * 10 / 100;            
            else if (kidem >= 15)            
                maas += maas * 12 / 100;    
        
            return maas;
        }
        

    }
}
