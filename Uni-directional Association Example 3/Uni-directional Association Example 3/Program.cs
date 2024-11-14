using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
//Bir sipariş birden fazla ürün içerebilir, ancak ürünlerin siparişe dair bilgisi yoktur.
class Siparis
{
    public DateTime Tarih { get; private set; }
    public decimal Toplam { get; private set; }
    public Ürün Ürün { get; private set; }
    public List<Ürün> Urunler { get; private set; }
    
   
    public Siparis(decimal toplam)
    {
        Tarih = DateTime.Now;
        Toplam = toplam;
        Urunler = new List<Ürün>();
    }
    public void Sipariseekle(Ürün ürün)
    {
        Ürün = ürün;
        Urunler.Add(ürün);
        Toplam += Ürün.Fiyat;
    }
    public void Siparisiyazdır()
    {
        Console.WriteLine($"siparis toplamı: {Toplam}\nsiparis zamanı: {Tarih}");
        Console.WriteLine("Sipariş Edilen Ürünler:");
        foreach (var ürün in Urunler)
        {
            Console.WriteLine(ürün.ÜrünBilgisi());
        }
    }
}
class Ürün
{
    public string Ad { get; private set; }
    public int Fiyat { get; private set; }
    public Ürün(string ad, int fiyat)
    {
        Ad = ad;
        Fiyat = fiyat;
    }
    public string ÜrünBilgisi() 
    { 
        return $"Ürünün Adı: {Ad}\nÜrünün Fiyatı: {Fiyat}";
    }
   
}
class Program
{
    static void Main(string[] args)
    {
        
        Ürün ürün = new("üzüm", 50);
        Ürün ürün1 = new("SÜT", 25);
        Ürün ürün2 = new("agac", 850);
        Siparis siparis = new(0);
        siparis.Sipariseekle(ürün);
        siparis.Siparisiyazdır(); 
        siparis.Sipariseekle(ürün1);
        siparis.Sipariseekle(ürün2);
        siparis.Siparisiyazdır();
    }
}