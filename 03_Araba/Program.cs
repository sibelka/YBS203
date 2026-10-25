using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaksiUygulama    
{
    class TaksiSoforu
    {
        public string adSoyad;
        public DateTime dogumTarihi;
        public int yas_hesapla()
        {
            return DateTime.Today.Year - dogumTarihi.Year;
        }
    }
    public class Araba
    {
        public int maxHiz;
        public int vitesSayisi;
        public string marka;
        public Araba() { }
        public Araba(int h, int v, string m)
        {
            this.maxHiz = h;
            this.vitesSayisi = v;
            this.marka = m;
        }
        public void arabaOzellikleriniYaz()
        {
            Console.WriteLine(marka + " marka araba " + vitesSayisi + " viteslidir ve saatte " + maxHiz + " km hiza cikabilir");
        }
    }
    public class Uygulama
    {
        public static void Main(string[] args)
        {
            TaksiSoforu ahmet = new TaksiSoforu();
            ahmet.adSoyad = "Ahmet Yilmaz";
            ahmet.dogumTarihi = Convert.ToDateTime("1996-03-08");
            Console.Write("Taksi soforu " + ahmet.adSoyad + " ");
            Console.Write(ahmet.yas_hesapla());
            Console.WriteLine(" yasinda");

            Araba duldul = new Araba();
            duldul.marka = "TOFAS Serce";
            duldul.vitesSayisi = 4;
            duldul.maxHiz = 150;
            duldul.arabaOzellikleriniYaz();

            Araba toptis = new Araba(160, 4, "VW Kaplumbağa");
            toptis.arabaOzellikleriniYaz();
        }
    }
}

