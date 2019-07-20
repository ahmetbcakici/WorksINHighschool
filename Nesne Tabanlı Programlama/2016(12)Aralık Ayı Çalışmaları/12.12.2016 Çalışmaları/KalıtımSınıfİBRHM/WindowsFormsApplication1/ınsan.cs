
namespace WindowsFormsApplication1
{
    class Insan
    {
        public string ad, soyad, cinsiyet, yas;
        public string bilgigoster()
        {
            return (ad + " " + soyad + " " + cinsiyet + " " + yas);
        }
    }
    class Ogretmen : Insan
    {
        public string brans, nobetgunu, rehberlik, maas;
        public string obilgigoster()
        {
            return (brans + " " + nobetgunu + " " + rehberlik + " " + maas);
        }
    }
    class MudurYrd : Insan
    {
        public string nobetgunu, odano;
        public string mbilgigoster()
        {
            return (odano + " " + nobetgunu);
        }
    }
}