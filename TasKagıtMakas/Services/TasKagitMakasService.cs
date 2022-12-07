using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasKagıtMakas.Services
{
    internal class TasKagitMakasService
    {
        string[] _hareketler = new string[3]
        {
            "Kağıt","Taş","Makas"
        };
        Random _rastgele = new Random();
        public int HareketOlustur()
        {
            int rastgeleIndex = _rastgele.Next(0, 3);
            return rastgeleIndex;
        }
        public string Oyna(int kullaniciHareketIndex)
        {
            int bilgisayarHareketIndex = HareketOlustur();
            string sonuc = $"Kullanıcı: {_hareketler[kullaniciHareketIndex]}\n" +
                $"Bilgisayar: {_hareketler[bilgisayarHareketIndex]}\n " +
                $"Kazanan: {KazananiBul(bilgisayarHareketIndex, kullaniciHareketIndex)}";
            return KazananiBul(bilgisayarHareketIndex, kullaniciHareketIndex);
        }
        public string KazananiBul(int bilgisayarHareketIndex, int kullaniciHareketIndex)
        { 
            string sonuc = "Berabere";
            int bilgisayarDeger = bilgisayarHareketIndex == 2 && kullaniciHareketIndex == 0 ? -1 : bilgisayarHareketIndex;
            int kullaniciDeger = kullaniciHareketIndex == 2 && kullaniciHareketIndex == 0 ? -1 : kullaniciHareketIndex;
            if (bilgisayarDeger < kullaniciDeger)
                sonuc = "Bilgisayar";
            else if (kullaniciDeger < bilgisayarDeger)
                sonuc = "Kullanıcı";
            return sonuc;
        }
    }
}
