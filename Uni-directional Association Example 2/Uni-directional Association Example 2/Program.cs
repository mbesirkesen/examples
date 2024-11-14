using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Bir çalışan bir departmana aittir ancak departman çalışana doğrudan referans vermez.
class Departman
{
    public string DepartmanAdı { get; private set; }
    public string Lokasyon { get; private set; }

    public Departman( string ad, string lokasyon)
    {
        DepartmanAdı = ad;
        Lokasyon = lokasyon;
    }
}
class Calısan
{
    public string Ad { get; private set; }
    public string Pozisyon { get; private set ; }
    public Departman Departman {  get; private set; }
    public Calısan( string ad, string pozisyon)
    {
        Ad = ad;
        Pozisyon = pozisyon;
    }
    public void DepartmanAtama(Departman departman)
    {
        Departman = departman;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Calısan calısan = new ("Beşir", "Mühendis");
        Departman departman1 = new ("yazılım", "fü");
        calısan.DepartmanAtama(departman1);
    }
}