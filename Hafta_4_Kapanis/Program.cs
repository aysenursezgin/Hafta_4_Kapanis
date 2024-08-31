using System;

class Program
{
    static void Main()
    {
        bool devam = true;

        while (devam)
        {
            Console.WriteLine("Telefon üretmek için 1'e, Bilgisayar üretmek için 2'ye basınız.");
            string secim = Console.ReadLine();

            BaseMakine urun = null;

            if (secim == "1")
            {
                urun = new Telefon();
                Console.WriteLine("Telefon bilgilerini giriniz:");
                UrunBilgileriniAl(urun);
                Telefon telefon = (Telefon)urun;

                Console.Write("TR Lisanslı mı? (Evet/Hayır): ");
                telefon.TrLisansliMi = Console.ReadLine().Trim().ToLower() == "evet";

                telefon.BilgileriYazdir();
                telefon.UrunAdiGetir();
            }
            else if (secim == "2")
            {
                urun = new Bilgisayar();
                Console.WriteLine("Bilgisayar bilgilerini giriniz:");
                UrunBilgileriniAl(urun);
                Bilgisayar bilgisayar = (Bilgisayar)urun;

                Console.Write("USB giriş sayısını giriniz (2 veya 4): ");
                bilgisayar.UsbGirisSayisi = int.Parse(Console.ReadLine());

                Console.Write("Bluetooth var mı? (Evet/Hayır): ");
                bilgisayar.Bluetooth = Console.ReadLine().Trim().ToLower() == "evet";

                bilgisayar.BilgileriYazdir();
                bilgisayar.UrunAdiGetir();
            }
            else
            {
                Console.WriteLine("Geçersiz seçim!");
                continue;
            }

            Console.WriteLine("Ürün başarıyla üretildi.");
            Console.Write("Başka bir ürün üretmek ister misiniz? (Evet/Hayır): ");
            devam = Console.ReadLine().Trim().ToLower() == "evet";
        }

        Console.WriteLine("İyi günler!");
    }

    // Ortak ürün bilgilerini alır
    static void UrunBilgileriniAl(BaseMakine urun)
    {
        Console.Write("Ad: ");
        urun.Ad = Console.ReadLine();

        Console.Write("Açıklama: ");
        urun.Aciklama = Console.ReadLine();

        Console.Write("İşletim Sistemi: ");
        urun.IsletimSistemi = Console.ReadLine();

        Console.Write("Seri Numarası: ");
        urun.SeriNumarasi = Console.ReadLine();
    }
}
