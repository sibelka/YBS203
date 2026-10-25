using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Taksi 
{
  class TaksiSoforu
  {
    public string adSoyad;
    public DateTime dogumTarihi;
    public int yasHesapla()
    {
        return DateTime.Today.Year - dogumTarihi.Year;
    }
  }
  public class TaksiUygulama
  {
    public static void Main(string[] args)
    {
        TaksiSoforu ahmet = new TaksiSoforu();
        ahmet.adSoyad = "Ahmet YILMAZ";
        ahmet.dogumTarihi = new DateTime(2000, 2, 3);
        Console.Write(ahmet.adSoyad + ": ");
        Console.Write(ahmet.yasHesapla());
        Console.WriteLine(" yasinda");
    }
  }
}
