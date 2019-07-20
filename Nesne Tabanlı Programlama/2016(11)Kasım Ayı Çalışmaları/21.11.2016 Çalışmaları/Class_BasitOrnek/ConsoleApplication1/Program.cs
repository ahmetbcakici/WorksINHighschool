using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            DenemeSinif sinif1 = new DenemeSinif();
            DenemeSinif sinif2 = new DenemeSinif();
            sinif1.bilgial("Ahmet", 20);
            sinif1.bilgiyaz();
            sinif2.bilgial("Yasin", 25);
            sinif2.bilgiyaz();           
            Console.Read();
        }
    }
    public class DenemeSinif
    {
        string ad;int yas;
        public void bilgial(string add, int yass) { ad = add; yas = yass; }
        public void bilgiyaz() { Console.WriteLine("Ad:"+ad+"|Yaş:"+yas); }
    }
}
