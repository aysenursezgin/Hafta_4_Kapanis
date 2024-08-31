public class Telefon : BaseMakine
{
    public bool TrLisansliMi { get; set; }

    // Bilgileri yazdırma metodu
    public override void BilgileriYazdir()
    {
        base.BilgileriYazdir();
        Console.WriteLine($"TR Lisanslı mı: {TrLisansliMi}");
    }

    // Soyut metodun implementasyonu
    public override void UrunAdiGetir()
    {
        Console.WriteLine($"Telefonunuzun adı ---> {Ad}");
    }
}
