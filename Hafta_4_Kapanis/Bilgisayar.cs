public class Bilgisayar : BaseMakine
{
    private int usbGirisSayisi;

    public int UsbGirisSayisi
    {
        get { return usbGirisSayisi; }
        set
        {
            if (value == 2 || value == 4)
                usbGirisSayisi = value;
            else
            {
                Console.WriteLine("USB giriş sayısı 2 veya 4 olmalıdır, -1 olarak atanıyor.");
                usbGirisSayisi = -1;
            }
        }
    }

    public bool Bluetooth { get; set; }

    // Bilgileri yazdırma metodu
    public override void BilgileriYazdir()
    {
        base.BilgileriYazdir();
        Console.WriteLine($"USB Giriş Sayısı: {usbGirisSayisi}");
        Console.WriteLine($"Bluetooth: {Bluetooth}");
    }

    // Soyut metodun implementasyonu
    public override void UrunAdiGetir()
    {
        Console.WriteLine($"Bilgisayarınızın adı ---> {Ad}");
    }
}
