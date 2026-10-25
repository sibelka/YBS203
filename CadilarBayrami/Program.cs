
using System;
public class Karakter
{
    protected string ad;
    protected string emoji;
    public Karakter()
    {
        this.ad = "Cadılar Bayramı Karakteri";
        this.emoji = "";
    }
    public Karakter(string ad, string emoji)
    {
        this.ad = ad;
        this.emoji = emoji;
    }
    public void goster()
    {
        Console.WriteLine(ad + " " + emoji);
    }
}
public class Canavar : Karakter
{
    protected string korkutucu_cumle;
    public Canavar() : base()
    {
        this.korkutucu_cumle = "";
    }
    public Canavar(string ad, string emoji, string cumle) : base(ad,
emoji)
    {
        this.korkutucu_cumle = cumle;
    }
    public void korkut()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\n" + korkutucu_cumle + "\n");
        Console.ResetColor();
    }
}
public class Hayvan : Karakter
{
    protected string davranis;
    protected string renk;
    public Hayvan() : base()
    {
        this.davranis = "";
    }
    public Hayvan(string ad, string emoji, string davranis) : base(ad, emoji)
    {
        this.davranis = davranis;
    }
    public void davran()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\n" + ad + ": " + davranis + "\n");
        Console.ResetColor();
    }
}
class Halloween
{
    static void Main()
    {
        Console.WriteLine("🎃 Halloween 🎃\n\n");

        Canavar vampir = new Canavar("Kont Dracula", "🧛", "Senin kanını emerim!");
        vampir.goster();
        vampir.korkut();

        Canavar zombi = new Canavar("Zombi", "🧟️", "Beyin! Beyin! Beyin!");
        zombi.goster();
        zombi.korkut();

        Hayvan kurbaga = new Hayvan("Kurbağa", "🐸", "Vrak vrak der ve zıplar.");
        kurbaga.goster();
        kurbaga.davran();
        Console.WriteLine("\nMutlu Cadilar Bayrami!");
    }
}