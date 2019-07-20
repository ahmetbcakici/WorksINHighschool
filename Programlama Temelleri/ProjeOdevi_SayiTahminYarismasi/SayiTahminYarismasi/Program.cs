using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SayiTahminYarismasiProje
{
    class Program
    {
        static void Main(string[] args)
        {
            char tercih = 'h';
            int haksayisi, sayac = 0;
            Console.WriteLine("Sayı Tahmin Oyununa Hoşgeldiniz!\n\n");
            do
            {
                sayac = 0;//Kullanıcı tekrar oynamak isterse sayaç yanlış çıkmasın diye sayaçı sıfırlıyorum.
                Random random = new Random();//Rastgele sayı üretmek için yazdığımız komut.
                int rnd = random.Next(0, 51);//Rastgele değeri rnd isimli değişkene aktarıyoruz ve rastgele sayıların kaç aralıkta olduğunu belirtiyoruz.(51'e kadar 51 dağil değil.)
                Console.Clear();//Console ekranını temizliyoruz.(Bu satırın üstündeki yazılar için)
                Console.Write("Hak sayısı giriniz:");
                haksayisi = Convert.ToInt16(Console.ReadLine());//Kullanıcıya kaç hak sayısı istediğini sorup burada kullanıcının girdiğini int tipi değere dönüştürüp hafızaya alıyoruz.            
                Console.Clear();
                while (haksayisi <= 0)//Hak sayısını 0 girmemesini sağladım 
                {// İf ile yapmama sebebim tekrar tekrar dönsün asla 0 girilmesin if ile yapsam tekrar 0 girebilirdi.Tekrar tekrar kontrol için garanti while kullandım.
                    Console.Write("1 den küçük hak sayısı isteyemezsiniz!\n Tekrar giriniz:");
                    haksayisi = Convert.ToInt16(Console.ReadLine());
                    Console.Clear();
                }
                Console.Clear();
                for (int i = haksayisi; i >= 0; i--)//Başlangıcımız kullanıcının girdiği haksayısı ; i(haksayısı) >= 0 (0 a büyük veya eşittir) olana kadar ; ve her döngü çalıştığında i(haksayısı'nı) eksiltiyoruz.Yani haksayısından başlıcak haksayısı 0 olana kadar bu döngü devam edecek.
                {
                    if (i == 0)//Önce i'nin 0 a eşit olup olmadığını kontrol ediyorum eşitse ;
                    {
                        Console.WriteLine("{0}. tahmininizde hakkınız bitti.\nRastgele sayı {1} idi", sayac, rnd);//Kaçıncı tahmininde hakkının bittiğini belirtiyoruz ve bilmeye çalıştığı sayıyı söylüyoruz.
                        Console.Write("Tekrar oynamak ister misiniz? (E/H):");
                        tercih = Convert.ToChar(Console.ReadLine().ToLower());//Kullanıcının tercih yapmasını isteyip yaptığı tercihi char tipine dönüştürüyoruz.Ardından hafızaya alıyoruz ve küçük harfe dönüştürüyoruz.
                        break;//For döngüsünden çıkıyor dışarda do-while döngüsü var kullanıcıya tercih yaptırdım yaptığı tercihe göre program devam eder veya etmez.
                    }
                    else//i 0 a eşit değilse programımız çalışacaktır.
                    {
                        Console.WriteLine("Hak sayınız : {0}", i);//Her defasında haksayısını hatırlatıyoruz.
                        Console.Write("Tahmin yapınız(0,50):");//Rastgele sayımız 0,50 arasında o yüzden 0,50 arasında tahmin istiyoruz.
                        int tahmin = Convert.ToInt16(Console.ReadLine());//Kullanıcıdan tahmin istiyoruz tahminini int değere çevirip hafızaya alıyoruz.
                        sayac++;//Kaçıncı tahminde bulduğunu göstermek için sayaç kullanıyoruz ve  her tahmininde arttırıyoruz.
                        if (tahmin > rnd)//Eğer tahmin rastgele sayıdan büyükse ;
                        {
                            if (i > 1)//Bu ifleri yapma sebebim eğer haksayımız 1 den büyükse bize büyük tahmin yaptınız aşağı ininiz desin diye çünkü haksayımız kalmayıpta böyle birşey demenin anlamı yok nede olsa bir daha tahmin yapamıcaz.
                            {//i 1 den büyük olduğu sürece aşağı in , yukarı çık dicek ama 1 olunca napacak?O zamanda zaten kullanıcının son hakkı oluyor o yüzden koşulu i > 1 yaptım.
                                Console.WriteLine("Büyük tahmin yaptınız aşağı ininiz.");//Tahminin rastgele sayıdan büyük aşağı in uyarısını veriyoruz.
                            }
                        }
                        else if (tahmin < rnd)//Eğer tahmin rastgele sayıdan küçükse ; 
                        {
                            if (i > 1)//Aynı şekilde yukarıda açıkladığım gibi
                            {
                                Console.WriteLine("Küçük tahmin yaptınız yukarı çıkınız.");//Tahminin rastgele sayıdan küçük yukarı çık uyarısını veriyoruz.
                            }
                        }
                        else//Üstteki ifler ( tahmin > rnd ve tahmin < rnd ) tutmuyorlarsa geriye bitek eşit olmaları kalıyor eşit oluncada bilmiş oluyor.Bilince aşağıdaki işlemler gerçekleşiyor.                    
                        {
                            Console.WriteLine("Tebrikler {0}. tahmininizde bildiniz!\n{1} hak sayınız daha vardı.", sayac, i);//Kaçıncı tahmininde ve kaç haksayısı kalmışken bildiğini belirtiyoruz.
                            Console.Write("Tekrar oynamak ister misiniz? (E/H):");
                            tercih = Convert.ToChar(Console.ReadLine().ToLower());//Kullanıcının tercih yapmasını isteyip yaptığı tercihi char tipine dönüştürüyoruz.Ardından hafızaya alıyoruz ve küçük harfe dönüştürüyoruz.                         
                            break;//For döngüsünden çıkıyor dışarda do-while döngüsü var kullanıcıya tercih yaptırdım yaptığı tercihe göre program devam eder veya etmez.
                        }
                    }
                }
            }
            while (tercih == 'e');
            Console.ReadKey();//Console ekranının herhangi bir tuşa basılana kadar ekranda kalmasını sağlayan kod.
        }
    }
}
