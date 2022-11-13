using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.MusteriId = 1;
            musteri1.MusteriTcKimlikNo = 12345678910;
            musteri1.MusteriAdiSoyadi = "Deniz Can Coştur";
            musteri1.MusteriYas = 27;
            musteri1.MusteriSehir = "İstanbul";
            musteri1.MusteriMeslek = "Software Engineer";
            musteri1.MusteriMaas = 25000;

            Musteri musteri2 = new Musteri();
            musteri2.MusteriId = 2;
            musteri2.MusteriTcKimlikNo = 23456789101;
            musteri2.MusteriAdiSoyadi = "Hatice Akyol";
            musteri2.MusteriYas = 26;
            musteri2.MusteriSehir = "İstanbul";
            musteri2.MusteriMeslek = "Bankacı";
            musteri2.MusteriMaas = 25001;

            Musteri musteri3 = new Musteri();
            musteri3.MusteriId = 3;
            musteri3.MusteriTcKimlikNo = 34567891011;
            musteri3.MusteriAdiSoyadi = "Nevin Yaşar";
            musteri3.MusteriYas = 63;
            musteri3.MusteriSehir = "İstanbul";
            musteri3.MusteriMeslek = "Aşçı";
            musteri3.MusteriMaas = 25002;

            Musteri[] musteris = new Musteri[3] { musteri1,musteri2,musteri3 };

            MusteriManager musteriIslemleri =new MusteriManager();
            musteriIslemleri.Listele(musteri1);
            Console.WriteLine("----------------------");
            musteriIslemleri.Listele(musteri2);
            Console.WriteLine("----------------------");
            musteriIslemleri.Listele(musteri3);
            Console.WriteLine("----------------------");

            musteriIslemleri.Ekle(musteri1);
            Console.WriteLine("----------------------");
            musteriIslemleri.Ekle(musteri2);
            Console.WriteLine("----------------------");
            musteriIslemleri.Ekle(musteri3);
            Console.WriteLine("----------------------");

            musteriIslemleri.Sil(musteri1);
            Console.WriteLine("----------------------");
            musteriIslemleri.Sil(musteri2);
            Console.WriteLine("----------------------");
            musteriIslemleri.Sil(musteri3);
            Console.WriteLine("----------------------");

            Console.ReadKey();
        }
    }
}
