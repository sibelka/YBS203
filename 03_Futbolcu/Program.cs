using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Futbolcu
{
  public class Insan
  {
    protected string ad;
    protected string soyad;
    protected DateTime? dogumTarihi;
    public void selamla()
    {
        Console.WriteLine("Merhaba, ben " + ad + " " + soyad + ".");
    }
    public Insan()
    {
        this.ad = "";
        this.soyad = "";
        this.dogumTarihi = null;
    }
    public Insan(string ad, string soyad, DateTime dogumTarihi)
    {
        this.ad = ad;
        this.soyad = soyad;
        this.dogumTarihi = dogumTarihi;
    }
  }
  public class Futbolcu : Insan
  {
    protected char ayak;
    protected string takim;
    public void tanit()
    {
        Console.WriteLine("Dogum tarihi: " + Convert.ToString(dogumTarihi));
        if (ayak == 'L')
            Console.WriteLine("Sol ayakla " + takim + " takımında oynuyorum.");
        else
            Console.WriteLine("Sağ ayakla " + takim + " takımında oynuyorum.");
    }
    public Futbolcu(string ad, string soyad, DateTime tarih, char a, string takim) : base(ad, soyad, tarih)
    {
        this.ayak = a;
        this.takim = takim;
    }
    public Futbolcu() { }
  }
  public class FutbolUygulamasi
  {
    public static void Main(string[] args)
    {
        Futbolcu m = new Futbolcu("Muhammed", "Salah", Convert.ToDateTime("1992-09-13"), 'L', "Trabzonspor");
        m.selamla();
        m.tanit();
    }
  }
}
