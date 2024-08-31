using System;

public abstract class BaseMakine
{
    public DateTime UretimTarihi { get; private set; }
    public string SeriNumarasi { get; set; }
    public string Ad { get; set; }
    public string Aciklama { get; set; }
    public string IsletimSistemi { get; set; }

    // Constructor
    protected BaseMakine()
    {
        UretimTarihi = DateTime.Now; // Üretim tarihi nesne oluşturulurken otomatik atanır
    }

    // Bilgileri yazdırma metodu
    public virtual void BilgileriYazdir()
    {
        Console.WriteLine($"Üretim Tarihi: {UretimTarihi}");
        Console.WriteLine($"Seri Numarası: {SeriNumarasi}");
        Console.WriteLine($"Ad: {Ad}");
        Console.WriteLine($"Açıklama: {Aciklama}");
        Console.WriteLine($"İşletim Sistemi: {IsletimSistemi}");
    }

    // Soyut metod
    public abstract void UrunAdiGetir();
}
