using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriAdiSoyadi + " başarıyla eklendi.");
        }
        public void Listele(Musteri musteri)
        {
            Console.WriteLine("Müşteri ID: " + musteri.MusteriId);
            Console.WriteLine("Müşteri TC: " + musteri.MusteriTcKimlikNo);
            Console.WriteLine("Müşteri Ad ve Soyad: " + musteri.MusteriAdiSoyadi);
            Console.WriteLine("Müşteri Yaş: " + musteri.MusteriYas);
            Console.WriteLine("Müşteri Şehir: " + musteri.MusteriSehir);
            Console.WriteLine("Müşteri Meslek: " + musteri.MusteriMeslek);
            Console.WriteLine("Müşteri Maaş: " + musteri.MusteriMaas);
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriAdiSoyadi + " başarıyla silindi.");
        }
    }
}
