using System;
public class Karakter
{
    protected string ad;
    protected string emoji;
    protected ConsoleColor renk;

    public Karakter()
    {
        this.ad = "Cadılar Bayramı Karakteri";
        this.emoji = "";
        this.renk = ConsoleColor.Blue;
    }
    public Karakter(string ad, string emoji, ConsoleColor renk)
    {
        this.ad = ad;
        this.emoji = emoji;
        this.renk = renk;
    }
    public virtual void goster()
    {
        Console.BackgroundColor = renk;
        Console.WriteLine(ad + " " + emoji);
        System.Threading.Thread.Sleep(1000);
        Console.ResetColor();
    }
}
public class Canavar : Karakter
{
    protected string korkutucu_cumle;
    public Canavar() : base()
    {
        this.korkutucu_cumle = "";
    }
    public Canavar(string ad, string emoji, string cumle)
        : base(ad, emoji, ConsoleColor.Red)
    {
        this.korkutucu_cumle = cumle;
    }
    public void korkut()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\n" + korkutucu_cumle + "\n");
        Console.ResetColor();
    }
    public override void goster()
    {
        base.goster(); // Atasının goster() fonksiyonu çağrıldı.
        korkut();
    }
}
public class Hayvan : Karakter
{
    protected string davranis;
    public Hayvan() : base()
    {
        this.davranis = "";
    }
    public Hayvan(string ad, string emoji, string davranis) :
        base(ad, emoji, ConsoleColor.Green)
    {
        this.davranis = davranis;
    }
    public void davran()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\n" + ad + ": " + davranis + "\n");
        Console.ResetColor();
    }
    public override void goster()
    {
        base.goster(); // Atasının goster() fonksiyonu çağrıldı.
        davran();
    }
}
class Halloween
{
    static void Main()
    {
        Console.WriteLine("🎃 Halloween 🎃\n\n");

        Canavar vampir = new Canavar("Kont Dracula", "🧛", "Senin kanını emerim!");
        vampir.goster();

        Canavar zombi = new Canavar("Zombi", "🧟️", "Beyin! Beyin! Beyin!");
        zombi.goster();

        Hayvan kurbaga = new Hayvan("Kurbağa", "🐸", "Vrak vrak der ve zıplar.");
        kurbaga.goster();

        Console.WriteLine("\nMutlu Cadilar Bayrami!");
    }
}