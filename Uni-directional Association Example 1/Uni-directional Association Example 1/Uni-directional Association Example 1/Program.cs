using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Bir yazar, birden fazla kitaba sahip olabilir ancak kitap, yazara referans vermez.
class Kitap
{
    public string Baslik { get; private set; }
    public string İSBN { get; private set; }
    public Kitap(string baslık, string isbn)
    {
        İSBN = isbn;
        Baslik = baslık;
    }
    public string KitapBilgisi()
    {
        return $"Başlık: {Baslik}\nİSBN: {İSBN}\n";
    }
}
class Yazar
{
    public string Ad { get; private set; }
    public string Ülke { get; private set; }
    public List<Kitap> Kitaplar { get; private set; }
    public Yazar(string ad, string ülke)
    {
        Ad = ad;
        Ülke = ülke;
        Kitaplar = new List<Kitap>();
    }
    public void Kitapekle(Kitap kitap)
    {
        Kitaplar.Add(kitap);
    }
    public void yazdir()
    {
        Console.WriteLine($"\n{Ad} adlı yazarın kitapları:");
        foreach (var kitap in Kitaplar)
        {
            Console.WriteLine(kitap.KitapBilgisi());
        }
    }
}

class Program
{
    static void Main(string[] args)
    {

        {   
            Yazar yazar = new Yazar("Beşir Kesen", "Türkiye");
            Kitap kitap1 = new Kitap("HOİ", "123456789");
            Kitap kitap2 = new Kitap("HARP OKULU ;)", "999999999");
            yazar.Kitapekle(kitap1);
            yazar.Kitapekle(kitap2);
           
            yazar.yazdir();

        }
    }
}