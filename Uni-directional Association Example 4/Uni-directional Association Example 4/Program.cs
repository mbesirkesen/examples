using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
//Bir müşteri birden fazla sipariş verebilir, ancak siparişler müşteriye referans vermez.
class Musteri
{
    public string Ad { get; private set; }
    public string TelefonNumarasi { get; private set; }
    public Musteri(string ad, string telefon) 
    { 
        Ad = ad;
        TelefonNumarasi = telefon;
    }
    public void SiparisVerr(Siparis siparis)
    {
        Console.WriteLine($"{Ad} kişisine ait sipariş alınmıştır");
        Console.WriteLine(siparis.SiparisVer(siparis));
    }
    public string MusteriBilgileri()
    {
        return $"AD: {Ad} \nTELEFON NUMARASI: {TelefonNumarasi}";
    }
    public void yazdır()
    {   
        Console.WriteLine(MusteriBilgileri());
    }
}
class Siparis
{
    public DateTime Tarih { get; private set; }
    public string ÜRÜN { get; private set; }
    public string SiparisDurumu { get; private set; }
    public Siparis(string durum,string ürün)
    {
        ÜRÜN = ürün;
        SiparisDurumu = durum;
        Tarih = DateTime.Now;
    }
    public string SiparisVer(Siparis siparis)
    {
        return $"{siparis.ÜRÜN}\nSipariş durumu: {siparis.SiparisDurumu}";
    }
    public string SiparisBilgileri(Siparis siparis)
    {
        return $"siparis tarihi: {Tarih}\nsiparis durumu: {siparis.SiparisDurumu}";
    }
    public void Yazdır(Siparis siparis)
    {
        Console.WriteLine(SiparisBilgileri(siparis));
        
    }

}
class Program
{
    static void Main(string[] args)
    {
        Siparis siparis = new("sipariş verildi","kola");
        Siparis siparis1 = new("sipariş verildi","soda");
        Siparis siparis2 = new("sipariş verildi","burger");
        Siparis siparis3 = new("teslim edildi","sen");
        Musteri musteri = new("Beşir KESEN", "05537139241");
       
        musteri.yazdır();
        musteri.SiparisVerr(siparis);
        musteri.SiparisVerr(siparis1 );
        musteri.SiparisVerr(siparis2 );
        musteri.SiparisVerr(siparis3 );
        siparis.Yazdır(siparis);
    }
}